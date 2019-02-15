using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asciifyPhotoshop
{
    public partial class asciify_Form : Form
    {
        public asciify_Form()
        {
            InitializeComponent();
        }
        string filePath;
        Bitmap grayImage;
        BitmapAscii asciiImage = new BitmapAscii();
        private void menuImport_Click(object sender, EventArgs e)
            //user imports image file | filter: image files (.jpg, .png, .bmp, .tiff, .gif)
        {
            if (diaImportFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = diaImportFile.FileName;
                Bitmap importedImage = new Bitmap(filePath);
                picNormal.Image = importedImage;
                grayImage = (Bitmap)importedImage.Clone();
                int x = 0;
                int y = 0;
                int pixelCount = 0;
                int intNumberOfTotalPixels = (grayImage.Size.Height * grayImage.Size.Width);
                while (pixelCount < intNumberOfTotalPixels) { 

                    //read pixel values
                    Color col_currentPixel = grayImage.GetPixel(x,y);

                    //find gray value
                    int grayFinder = (col_currentPixel.R + col_currentPixel.G + col_currentPixel.B) / 3;

                    //set gray value
                    Color gray_Scale = Color.FromArgb(grayFinder, grayFinder, grayFinder);
                    grayImage.SetPixel(x, y, gray_Scale);

                    x++;
                    if(x == grayImage.Width)
                    {
                        x = 0;
                        y++;
                    }
                    pixelCount++;
                }
                picGray.Image = grayImage;
            }
        }

        private void btnAsciify_Click(object sender, EventArgs e)
        //shows imported picture as selected ascii chars
        {
            asciiImage.charsByScale[0]=txtRange1_Char.Text;
            asciiImage.charsByScale[1]=txtRange2_Char.Text;
            asciiImage.charsByScale[2]=txtRange3_Char.Text;
            asciiImage.charsByScale[3]=txtRange4_Char.Text;
            asciiImage.charsByScale[4]=txtRange5_Char.Text;
            asciiImage.charsByScale[5]=txtRange6_Char.Text;

            rtxShowAscii.Text = asciiImage.Asciitize(grayImage);
        }

    }
}
