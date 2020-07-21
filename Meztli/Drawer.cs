using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Meztli
{
    class Drawer
    {
        /// <summary>
        ///           406px
        /// _______________________
        /// |  10px         10px    |
        /// | text 1     *********  |
        /// | text 2     *********30|  203 px
        /// | text 3     *********px|
        /// | text 4     *********  |
        /// |_______________________|
        /// //Printer 203dpi - Tag 2"x1" (406px x 203px)
        /// 
        /// </summary>
        /// <param name="info">information</param>
        /// <param name="part">part</param>
        /// <param name="type"></param>
        /// <returns>Generated image</returns>
        public Bitmap GenerateTag(Information info, Part part)
        {
            EncodeHelper encoder = new EncodeHelper(info, part);
            //Pixels from border to image
            int padding = 10;
            //Added space from the right border of the sticker.
            int rightoffset = 20;
            //Printer resolution
            int dpi = 203;
            //Sticker size in pixels
            Point size = new Point(406, 203);
            //QR size in pixels
            Point qrsize = new Point(160, 160);
            //Top left corner of QR code position in sticker
            Point qrPosition = new Point(size.X - qrsize.Y - padding - rightoffset, padding);
            //Rectangle where information will be displayed
            RectangleF stringRect = new RectangleF(10, 15, 200, 180);
            //Font information
            Font font = new Font("Impact", 26, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);

            //Create empty sticker bitmap
            Bitmap image = new Bitmap(size.X, size.Y);
            image.SetResolution(dpi, dpi);

            //Generate QR Code, make sure resolutions match
            Bitmap qrimage = GenerateQRCode(encoder.qRString);
            qrimage.SetResolution(dpi, dpi);

            //Set graphics mode
            Graphics graphics = Graphics.FromImage(image);
            graphics.Clear(Color.White);
            graphics.SmoothingMode = SmoothingMode.None;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            //Uncomment the following command to see the label's boundaries
            //graphics.DrawRectangle(new Pen(Color.Black, 1f), new Rectangle((int)stringRect.X, (int)stringRect.Y, (int)stringRect.Width, (int)stringRect.Height));
            //Draw string and image to the sticker
            graphics.DrawString(encoder.message, font, new SolidBrush(Color.Black), stringRect);
            graphics.DrawImage(qrimage, qrPosition);
            graphics.Flush();

            return image;
        }

        private static Bitmap GenerateQRCode(string qrstring)
        {

            //GENERATE QR IMAGE
            CollectionHandler ci = new CollectionHandler();

            DataMatrix.net.DmtxImageEncoder dIE = new DataMatrix.net.DmtxImageEncoder();
            DataMatrix.net.DmtxImageEncoderOptions opts = new DataMatrix.net.DmtxImageEncoderOptions();
            opts.Scheme = DataMatrix.net.DmtxScheme.DmtxSchemeAscii;
            opts.MarginSize = 0;
            opts.ModuleSize = 5;
            Bitmap finalQRImage = dIE.EncodeImage(qrstring, opts);
            return finalQRImage;
        }

        public Bitmap GenerateTag(Information info, Part part, string type)
        {
            EncodeHelper encoder = new EncodeHelper(info, part);

            //GENERATE MESSAGE IMAGE
            Bitmap finalMessageImage = new Bitmap(1, 1);

            int intWidth = 0;
            int intHeight = 0;
            Font objFont = null;

            //Printer 203dpi - Tag 2"x1" (406px x 203px)
            Point size = new Point(406, 203);
            Point qrsize = new Point(150, 150);

            if (type.Equals(Resources.GENERATEFORPREV))
            {
                // Create the Font object for the image text drawing.
                objFont = new Font("Arial", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

                // This is where the bitmap size is determined.
                intWidth = 215;
                intHeight = 139;
            }
            else if (type.Equals(Resources.GENERATEFORSAVE))
            {
                objFont = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Pixel);

                // This is where the bitmap size is determined.
                intWidth = 75;
                intHeight = 75;
            }

            // Create a graphics object to measure the text's width and height.
            Graphics objGraphics = Graphics.FromImage(finalMessageImage);

            // Create the bmpImage again with the correct size for the text and font.
            finalMessageImage = new Bitmap(finalMessageImage, new Size(intWidth, intHeight));

            // Add the colors to the new bitmap.
            objGraphics = Graphics.FromImage(finalMessageImage);

            // Set Background color
            objGraphics.Clear(Color.White);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            objGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            objGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            objGraphics.DrawString(encoder.messageString, objFont, new SolidBrush(Color.Black), 0, 0);
            objGraphics.Flush();

            //GENERATE QR IMAGE
            CollectionHandler ci = new CollectionHandler();

            DataMatrix.net.DmtxImageEncoder dIE = new DataMatrix.net.DmtxImageEncoder();
            DataMatrix.net.DmtxImageEncoderOptions opts = new DataMatrix.net.DmtxImageEncoderOptions();
            opts.Scheme = DataMatrix.net.DmtxScheme.DmtxSchemeAscii;

            Bitmap finalQRImage = dIE.EncodeImage(encoder.qRString, opts);

            if (type.Equals(Resources.GENERATEFORSAVE))
            {
                finalQRImage = new Bitmap(finalQRImage, new Size(75, 75));
            }

            return (CombineMessageAndQR(new Image[] { finalMessageImage, finalQRImage }));
        }

        public Bitmap CombineMessageAndQR(Image[] files)
        {
            //read all images into memory
            List<Bitmap> images = new List<Bitmap>();
            Bitmap finalImage = null;

            try
            {
                int width = 0;
                int height = 0;

                foreach (Image image in files)
                {
                    //create a Bitmap from the file and add it to the list
                    Bitmap bitmap = new Bitmap(image);

                    //update the size of the final bitmap
                    width += bitmap.Width;
                    height = bitmap.Height > height ? bitmap.Height : height;

                    images.Add(bitmap);
                }

                //create a bitmap to hold the combined image
                finalImage = new Bitmap(width, height);

                //get a graphics object from the image so we can draw on it
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    //set background color
                    g.Clear(Color.White);

                    //go through each image and draw it on the final image
                    int offset = 0;
                    foreach (System.Drawing.Bitmap image in images)
                    {
                        g.DrawImage(image,
                          new System.Drawing.Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                //clean up memory
                foreach (System.Drawing.Bitmap image in images)
                {
                    image.Dispose();
                }
            }
        }
    }
}
