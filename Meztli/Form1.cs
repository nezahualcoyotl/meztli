using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;

namespace Meztli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }

        private Bitmap generateImage(string type, string serialNumber)
        {
            CollectionHandler ci = new CollectionHandler();
            Information info = new Information(cmbVendorCode.Text, dtpDate.Value, serialNumber, cmbShift.Text);
            Part part = ci.FindPart(cmbPart.Text);
            Drawer dr = new Drawer();

            return dr.GenerateTag(info, part);
        }
    }
}
