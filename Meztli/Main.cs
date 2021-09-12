using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Data.OleDb;

namespace Meztli
{
    public partial class Main : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public Main()
        {
            InitializeComponent();
            LoadParts();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblWarning.Text = string.Empty;
            
            if(cmbPart.SelectedItem == null ||
                cmbVendorCode.SelectedItem == null ||
                cmbShift.SelectedItem == null ||
                cmbSerialNumber.SelectedItem == null)
            {
                lblWarning.Text = Resources.SELECCIONELOSCAMPOS;
                return;
            }

            int initialSerial = Convert.ToInt32(serialFrom.Value);
            int finalSerial = Convert.ToInt32(serialTo.Value);
            for (int i = initialSerial; i <= finalSerial; i++)
            {
                Bitmap FinalImage = generateImage(Resources.GENERATEFORSAVE, i.ToString());

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = i.ToString();
                FinalImage.Save(dialog.FileName + ".bmp");
            }

            MessageBox.Show("Las etiquetas fueron generadas exitosamente");
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
    }
}
