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
            pbQRCode.Image = generateImage(Resources.GENERATEFORPREV);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pbQRCode.Image == null)
            {
                lblWarning.Text = Resources.GENEREELCODIGOPORFAVOR;
                return;
            }

            Bitmap FinalImage = generateImage(Resources.GENERATEFORSAVE);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = Resources.FILENAME;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FinalImage.Save(dialog.FileName, ImageFormat.Bmp);
            }
        }

        private Bitmap generateImage(string type)
        {
            CollectionHandler ci = new CollectionHandler();
            Information info = new Information(cmbVendorCode.Text, dtpDate.Value, cmbSerialNumber.Text, cmbShift.Text);
            Part part = ci.FindPart(cmbPart.Text);
            Drawer dr = new Drawer();

            return dr.GenerateTag(info, part);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (pbQRCode.Image == null)
            {
                lblWarning.Text = Resources.GENEREELCODIGOPORFAVOR;
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
            else
            {
                MessageBox.Show(Resources.IMPRESIONCANCELADA);
            }
        }

        private void PrintImage(object sender, PrintPageEventArgs e)
        {
            Image image = generateImage(Resources.GENERATEFORSAVE);

            e.Graphics.DrawImage(image,0,10);
        }
    }
}
