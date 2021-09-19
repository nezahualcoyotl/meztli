﻿using System;
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

        private void VerifyDefaultLocation()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=meztlidb.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Settings WHERE parameter='dump_folder'";
            dr = cmd.ExecuteReader();

            dr.Read();
            string loc = dr["val"].ToString();
            con.Close();

            if (loc == "default")
            {
                updt = new OleDbCommand();
                con.Open();
                updt.Connection = con;
                updt.CommandText = "UPDATE Settings SET val='" + System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "' WHERE parameter='dump_folder'";
                updt.ExecuteNonQuery();
                con.Close();
                VerifyDefaultLocation();
            } else {
                lnkDumpFolder.Tag = loc;
                lnkDumpFolder.Text = loc;
            }
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
            for (int i = initialSerial; i <= finalSerial; i++)
            {
                Bitmap FinalImage = generateImage(Resources.GENERATEFORSAVE, i.ToString());

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = i.ToString();
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
            System.IO.Directory.CreateDirectory("test");

            MessageBox.Show(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", lnkDumpFolder.Tag.ToString());
        }
    }
}
