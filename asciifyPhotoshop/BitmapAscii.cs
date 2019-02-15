using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace asciifyPhotoshop
{
    class BitmapAscii
    {
        public string asciiImage { get; private set; } = "";
        public string[] charsByScale { get; set; } = { "#", "+", "!", "*", ".", " " };
        Bitmap grayScaledImage;
        public string Asciitize(Bitmap grayImage)
            //returns image as an image of ascii characters
        {
            //int[] kernelSize = { (int)numWidth_dec.Value, (int)numHeight_dec.Value };
            grayScaledImage = grayImage;
            int intNumberOfTotalPixels = (grayImage.Size.Width * grayImage.Size.Height);
            string asciiPicture = "";
            int x = 0;
            int y = 0;
            int pixelCount = 0;
            string setCharacter = "";
            while (pixelCount < intNumberOfTotalPixels)
            {
                //reads pixel value and normalizes it
                double normalizer = AveragePixel(grayScaledImage.GetPixel(x,y));

                //finds pixel's ascii replacement and places it in its correct position
                setCharacter = GrayToString(normalizer);
                asciiPicture = asciiPicture + setCharacter;

                //iterator
                x++;
                if (x == grayImage.Width)
                {
                    asciiPicture = asciiPicture + '\n';
                    x = 0;
                    y++;
                }
                pixelCount++;
            }

            asciiImage = asciiPicture;
            return asciiPicture;
        }
        double AveragePixel(int inputRed, int inputGreen, int inputBlue)
            //finds average pixel value of the integers passed and returns its normal value: should be used to find gray value of a pixel (ex. AveragePixel(grayImage.GetPixel(x, y).R + grayImage.GetPixel(x, y).G + grayImage.GetPixel(x, y).B))
        {
            return ((inputRed + inputGreen + inputBlue) / 3.0) / 255.0;
        }
        double AveragePixel(Color inputColor)
            //finds average pixel value of the integers passed and returns its normal value: should be used to find gray value of a pixel (ex. AveragePixel(grayImage.GetPixel(x,y))
        {
            int r, g, b;
            r = inputColor.R;
            g = inputColor.G;
            b = inputColor.B;

            return ((r + b + g) / 3.0) / 255.0;
        }
        double AverageColor(List<Color> ListOfColors)
            //finds average of a list of colors and normalizes it
        {
            double ColorAVG = 0;
            foreach(Color x in ListOfColors)
            {
                ColorAVG += AveragePixel(x);
            }
            return (ColorAVG / ListOfColors.Count()) / 255.0;
        }
        public string GrayToString(double GrayNormalizer)
            //takes a normal gray and convert it to its ascii symbol
        {
            if (GrayNormalizer < .12) { return charsByScale[0]; }
            else if (GrayNormalizer >= .12 && GrayNormalizer < .25) { return charsByScale[1]; }
            else if (GrayNormalizer >= .25 && GrayNormalizer < .51) { return charsByScale[2]; }
            else if (GrayNormalizer >= .51 && GrayNormalizer < .68) { return charsByScale[3]; }
            else if (GrayNormalizer >= .68 && GrayNormalizer < .85) { return charsByScale[4]; }
            else { return charsByScale[5]; }
        }
        public override string ToString()
            //returns asciiImage - the full uploaded image created by charsByScale 
        {
             return asciiImage;
        }
    }
}
        /*public string Asciitize(Bitmap grayImage, string[] selectedChars)
            //returns image as an image of ascii characters
        {
            grayScaledImage = grayImage;
            int charLoop = 0;
            foreach (string strChar in selectedChars)
            {
                if (strChar != "") {
                    charsByScale[charLoop] = strChar[0];
                }
                charLoop++;
            }
            int intNumberOfTotalPixels = (grayImage.Size.Width * grayImage.Size.Height);
            string asciiPicture = "";
            int x = 0;
            int y = 0;
            int pixelCount = 0;
            string setCharacter = " ";
            while (pixelCount < intNumberOfTotalPixels)
            {
                    //read pixel values and normalize
                double normalizer = AveragePixel(grayScaledImage.GetPixel(x,y));
                //set char
                setCharacter = GrayToString(normalizer);
                
                    //concatenate char to asciiPicture
                asciiPicture = asciiPicture + setCharacter;

                x++;//iterator
                if (x == grayImage.Width)//if x has reached the last pixel in the row
                {
                    asciiPicture = asciiPicture + '\n';//start a new line
                    x = 0;//traget pixel is now first pixel
                    y++;//in the next column
                }
                pixelCount++;
            }

            return asciiPicture;

        }
        */
