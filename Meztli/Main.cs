using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Data.OleDb;
using System.Reflection;
using System.Diagnostics;

namespace Meztli
{
    public partial class Main : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbCommand updt;
        OleDbDataReader dr;

        public Main()
        {
            InitializeComponent();
            LoadParts();
            LoadVendorCodes();

            VerifyDefaultLocation();
        }

        private string GetCurrentLocation()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=meztlidb.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Settings WHERE parameter='dump_folder'";
            dr = cmd.ExecuteReader();

            dr.Read();

            string location = dr["val"].ToString();
            con.Close();

            return location;
        }

        private void VerifyDefaultLocation()
        {
            string loc = GetCurrentLocation();

            if (loc == "default")
            {
                UpdateDumpFolder(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
                VerifyDefaultLocation();
            } else {
                lnkDumpFolder.Tag = loc;
                lnkDumpFolder.Text = loc;
            }
        }

        private void UpdateDumpFolder(string location)
        {
            updt = new OleDbCommand();
            con.Open();
            updt.Connection = con;
            updt.CommandText = "UPDATE Settings SET val='" + location + "' WHERE parameter='dump_folder'";
            updt.ExecuteNonQuery();
            con.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblWarning.Text = string.Empty;

            if (cmbPart.SelectedItem == null ||
                cmbVendorCode.SelectedItem == null ||
                cmbShift.SelectedItem == null)
            {
                lblWarning.Text = Resources.SELECCIONELOSCAMPOS;
                return;
            }

            int initialSerial = Convert.ToInt32(serialFrom.Value);
            int finalSerial = Convert.ToInt32(serialTo.Value);
            string destinyLocation = GetCurrentLocation() + "\\" + dtpDate.Value.ToString("MM-dd-yyyy") + "_" + cmbPart.Text;

            System.IO.Directory.CreateDirectory(destinyLocation);

            for (int i = initialSerial; i <= finalSerial; i++)
            {
                Bitmap FinalImage = generateImage(Resources.GENERATEFORSAVE, i.ToString());

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = destinyLocation + "\\" + i.ToString();
                FinalImage.Save(dialog.FileName + ".bmp");
            }

            MessageBox.Show("The labels were created successfully");
        }

        private Bitmap generateImage(string type, string serialNumber)
        {
            CollectionHandler ci = new CollectionHandler();
            Information info = new Information(cmbVendorCode.Text, dtpDate.Value, serialNumber, cmbShift.Text);
            Part part = ci.FindPart(cmbPart.Text);
            Drawer dr = new Drawer();

            return dr.GenerateTag(info, part);
        }

        private void btnPartsForm_Click(object sender, EventArgs e)
        {
            Parts partsForm = new Parts();
            partsForm.FormClosing += delegate { this.GoBackToMain(); };
            partsForm.Show();
            this.Hide();
        }

        private void GoBackToMain()
        {
            this.Show();
            LoadParts();
            LoadVendorCodes();
        }

        private void LoadParts()
        {
            cmbPart.Items.Clear();

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=meztlidb.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Part";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbPart.Items.Add(dr["number"]);
            }
            con.Close();
        }

        private void LoadVendorCodes()
        {
            cmbVendorCode.Items.Clear();

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=meztlidb.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Vendor";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbVendorCode.Items.Add(dr["code"]);
            }
            con.Close();
        }

        private void btnVendorCodes_Click(object sender, EventArgs e)
        {
            VendorCodes vendorCodesForm = new VendorCodes();
            vendorCodesForm.FormClosing += delegate { this.GoBackToMain(); };
            vendorCodesForm.Show();
            this.Hide();
        }

        private void cmbPartChanged(object sender, EventArgs e)
        {
            string value = ((ComboBox)sender).SelectedItem.ToString();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=meztlidb.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Part WHERE number='"+ value + "'";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblPartDesc.Text = dr["name"].ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    UpdateDumpFolder(fbd.SelectedPath);
                    MessageBox.Show("Dump folder updated to " + fbd.SelectedPath);
                    VerifyDefaultLocation();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", lnkDumpFolder.Tag.ToString());
        }
    }
}
