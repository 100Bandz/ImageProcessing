using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmapImage;
        Color[,] ImageArray = new Color[320, 240];

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //   openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Image Browser";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    Image newImage = Image.FromStream(myStream);
                    bitmapImage = new Bitmap(newImage, 320, 240);
                    picImage.Image = bitmapImage;
                    myStream.Close();
                }
            }

            SetArayFromBitmap();
        }

        private void SetBitmapFromAray()
        {
            for (int row = 0; row < 320; row++)
            for (int col = 0; col < 240; col++)
            {
                bitmapImage.SetPixel(row, col, ImageArray[row, col]);
            }
        }

        private void SetArayFromBitmap()
        {
            for (int row = 0; row < 320; row++)
            for (int col = 0; col < 240; col++)
            {
                ImageArray[row, col] = bitmapImage.GetPixel(row, col);
            }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Green;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Green = col.G;

                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            ///Process the array data

            Byte Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            //The code extracts the color channel of a pixel and subtracts 255 from the color byte

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Color newColor = Color.FromArgb(255, 255 - Red, 255 - Green, 255 - Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            ///Process the array data

            int iWidth = 320;
            int iHeight = 240;

            //The code extracts the color channel of a pixel and add 20 to the colour value

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];


                    int Red = (col.R + 20); //If the color value is greater than 255 it will remain 255 regardless
                    if (Red > 255)
                    {
                        Red = 255;
                    }

                    int Green = (col.G + 20);
                    if (Green > 255)
                    {
                        Green = 255;
                    }


                    int Blue = (col.B + 20);
                    if (Blue > 255)
                    {
                        Blue = 255;
                    }

                    Color lighterColor = Color.FromArgb(col.A, Red, Green, Blue);

                    ImageArray[i, j] = lighterColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            {
                if (bitmapImage == null)
                    return;

                ///Process the array data

                int iWidth = 320;
                int iHeight = 240;

                //The code extracts the color channel of a pixel and subtracts 20 from the color value

                for (int i = 0; i < iWidth; i++)
                {
                    for (int j = 0; j < iHeight; j++)
                    {
                        Color col = ImageArray[i, j];

                        int Red = (col.R - 20);
                        if (Red < 0)           //If the color value is less than 0 it will remain 0 regardless
                        {
                            Red = 0;
                        }

                        int Green = (col.G - 20);
                        if (Green < 0)
                        {
                            Green = 0;
                        }


                        int Blue = (col.B - 20);
                        if (Blue < 0)
                        {
                            Blue = 0;
                        }

                        Color DarkerColor = Color.FromArgb(col.A, Red, Green, Blue);

                        ImageArray[i, j] = DarkerColor;

                    }
                }

                SetBitmapFromAray();
                picImage.Image = bitmapImage;
            }
        }

        private void btnSunset_Click(object sender, EventArgs e)
        {
            {
                if (bitmapImage == null)
                    return;

                ///Process the array data

                int iWidth = 320;
                int iHeight = 240;
                int Red, Green, Blue;

                //The code extracts the color channel of a pixel and divides the blue value

                for (int i = 0; i < iWidth; i++)
                {
                    for (int j = 0; j < iHeight; j++)
                    {
                        Color col = ImageArray[i, j];

                        Red = col.R;
                        Green = col.G;
                        Blue = col.B;

                        Red = Red * 2;
                        Green = Green + 0;
                        Blue = Blue / 2;

                        if (Red > 255) //If the colour value of Red is greater than 255 it will remain 255 regardless
                        {
                            Red = 255;

                        }

                        if (Blue < 0) //If the colour value of Blue is less than 0 it will remain 0 regardless
                        {

                            Blue = 0;
                        }

                        Color Sunset = Color.FromArgb(col.A, Red, Green, Blue);

                        ImageArray[i, j] = Sunset;

                    }
                }

                SetBitmapFromAray();
                picImage.Image = bitmapImage;
            }
        }

        private void btnPolarize_Click(object sender, EventArgs e)
        {
            {
                if (bitmapImage == null)
                    return;

                ///Process the array data

                int iWidth = 320;
                int iHeight = 240;

                //The code extracts the color channel of a pixel and subtracts 15 from the color byte

                for (int i = 0; i < iWidth; i++)
                {
                    for (int j = 0; j < iHeight; j++)
                    {
                        Color col = ImageArray[i, j];

                        int Red = col.R;
                        int Green = col.G;
                        int Blue = col.B;

                        if (Red >= 128)
                        {
                            Red = 250;
                        }

                        else if (Red < 127) //If and else statements that decides if the pixel value is greater or less than 128
                        {
                            Red = 0;
                        }

                        if (Green >= 128)
                        {
                            Green = 250;
                        }

                        else if (Green < 127)
                        {
                            Green = 0;
                        }

                        if (Blue >= 128)
                        {
                            Blue = 250;
                        }

                        else if (Blue < 127)
                        {
                            Blue = 0;
                        }

                        Color lighterColor = Color.FromArgb(col.A, Red, Green, Blue);

                        ImageArray[i, j] = lighterColor;

                    }
                }

                SetBitmapFromAray();
                picImage.Image = bitmapImage;
            }
        }

        private void btnGreyScale_Click(object sender, EventArgs e)
        {
            {

                int Red;
                int Blue;
                int Green;

                if (bitmapImage == null)
                    return;

                ///Process the array data

                int iWidth = 320;
                int iHeight = 240;

                //The code extracts the color channel of a pixel and averages the RGB values and changes each colour to the average value

                for (int i = 0; i < iWidth; i++)
                {
                    for (int j = 0; j < iHeight; j++)
                    {
                        Color col = ImageArray[i, j];


                        Red = col.R;
                        Green = col.G;
                        Blue = col.B;

                        int average = (Red + Green + Blue) / 3;

                        Red = average;
                        Green = average;
                        Blue = average;


                        Color GreyScale = Color.FromArgb(col.A, (int)Red, (int)Green, (int)Blue);

                        ImageArray[i, j] = GreyScale;

                    }
                }

                SetBitmapFromAray();
                picImage.Image = bitmapImage;
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            {
                if (bitmapImage == null)
                    return;

                int Red;
                int Blue;
                int Green;

                int iWidth = 320;
                int iHeight = 240;


                for (int i = 0; i < 160; i++)
                {
                    for (int j = 0; j < 120; j++)
                    {
                        Color col = ImageArray[i, j];
                        Color temp = ImageArray[i, j];

                        Red = col.R;
                        Green = col.G;
                        Blue = col.B;


                        Color newColor = Color.FromArgb(255, Red, Green, Blue); //Stores the previous pixels in temporary array
                        temp = ImageArray[i, j];
                        ImageArray[i, j] = ImageArray[iWidth / 2 + i, iHeight / 2 + j];
                        ImageArray[iWidth / 2 + i, iHeight / 2 + j] = temp; //Switches the top left and bottom right corners of the image

                    }
                }

                SetBitmapFromAray();
                picImage.Image = bitmapImage;
            }
        }

        private void btnRotate180_Click(object sender, EventArgs e)
        {
            {
                if (bitmapImage == null)
                    return;

                ///Process the array data

                int iWidth = 320;
                int iHeight = 240;

                for (int i = 0; i < iWidth; i++)
                {
                    for (int j = 0; j < 120; j++)
                    {
                        Color temp = ImageArray[i, j];
                        ImageArray[i, j] = ImageArray[i, 239 - j];
                        ImageArray[i, 239 - j] = temp;             //Stores the previous pixels in temporary array 
                    }
                }
                for (int i = 0; i < 160; i++)
                {
                    for (int j = 0; j < iHeight; j++)
                    {
                        Color temp = ImageArray[i, j];
                        ImageArray[i, j] = ImageArray[i, 239 - j]; //Stores the previous pixels in temporary array
                        ImageArray[i, 239 - j] = temp;
                    }
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnPixellate_Click(object sender, EventArgs e)
        {

            int Red;
            int Blue;
            int Green;

            if (bitmapImage == null)
                return;

            ///Process the array data

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i = i + 8)
            {
                for (int j = 0; j < iHeight; j = j + 8)
                {
                    Color col = ImageArray[i, j];


                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;


                    Color pixel = Color.FromArgb(col.A, Red, Green, Blue);

                    for (int m = 0; m <= 7; m++)
                    {
                        for (int n = 0; n <= 7; n++)
                        {
                            bool[,] PixelArray = new bool[i + m, j + n]; //Takes the average colour of the surronding pixels and puts them in an 8X8 block
                            ImageArray[i + m, j + n] = pixel;

                        }
                    }

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnScroll_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            ///Process the array data

            int iWidth = 320;
            int iHeight = 240;

            Color[,] TempArray = new Color[320, 240];

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j]; //Stores the previous pixels in temporary array

                }
            }

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    if (j + 10 < 240)
                    {
                        ImageArray[i, j + 10] = TempArray[i, j];
                    }
                    else
                    {
                        ImageArray[i, j + 10 - 240] = TempArray[i, j]; //Image scrolls down vertically in a loop
                    }
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            int Red;
            int Blue;
            int Green;

            if (bitmapImage == null)
                return;

            ///Process the array data

            int iWidth = 320;
            int iHeight = 240;

            Color[,] TempArray = new Color[320, 240];

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j]; //Stores the previous pixels in temporary array
                }
            }

            for (int i = 0; i < 320; i++)
            {
                for (int j = 0; j < 240; j++)  //Takes the average colour value of the surronding pixels and sets each pixel to that value
                {
                    if (i == 0 && j == 0) //If and else statements for the corners and edges as these pixels aren't fully surrounded
                    {
                        Red = (TempArray[i, j + 1].R + TempArray[i + 1, j + 1].R + TempArray[i + 1, j].R + TempArray[i, j].R) / 4;
                        Green = (TempArray[i, j + 1].G + TempArray[i + 1, j + 1].G + TempArray[i + 1, j].G + TempArray[i, j].G) / 4;
                        Blue = (TempArray[i, j + 1].B + TempArray[i + 1, j + 1].B + TempArray[i + 1, j].B + TempArray[i, j].B) / 4;
                    }
                    else if (i == iWidth - 1 && j == 0)
                    {
                        Red = (TempArray[i, j + 1].R + TempArray[i - 1, j].R + TempArray[i - 1, j + 1].R + TempArray[i, j].R) / 4;
                        Green = (TempArray[i, j + 1].G + TempArray[i - 1, j].G + TempArray[i - 1, j + 1].G + TempArray[i, j].G) / 4;
                        Blue = (TempArray[i, j + 1].B + TempArray[i - 1, j].B + TempArray[i - 1, j + 1].B + TempArray[i, j].B) / 4;
                    }
                    else if (i == iWidth - 1 && j == iHeight - 1)
                    {
                        Red = (TempArray[i, j - 1].R + TempArray[i - 1, j].R + TempArray[i - 1, j - 1].R + TempArray[i, j].R) / 4;
                        Green = (TempArray[i, j - 1].G + TempArray[i - 1, j].G + TempArray[i - 1, j - 1].G + TempArray[i, j].G) / 4;
                        Blue = (TempArray[i, j - 1].B + TempArray[i - 1, j].B + TempArray[i - 1, j - 1].B + TempArray[i, j].B) / 4;
                    }
                    else if (i == 0 && j == iHeight - 1)
                    {
                        Red = (TempArray[i, j - 1].R + TempArray[i + 1, j - 1].R + TempArray[i + 1, j].R + TempArray[i, j].R) / 4;
                        Green = (TempArray[i, j - 1].G + TempArray[i + 1, j - 1].G + TempArray[i + 1, j].G + TempArray[i, j].G) / 4;
                        Blue = (TempArray[i, j - 1].B + TempArray[i + 1, j - 1].B + TempArray[i + 1, j].B + TempArray[i, j].B) / 4;
                    }
                    else if (j == 0)
                    {
                        Red = (TempArray[i, j + 1].R + TempArray[i + 1, j].R + TempArray[i + 1, j + 1].R + TempArray[i - 1, j + 1].R + TempArray[i - 1, j].R + TempArray[i, j].R) / 6;
                        Green = (TempArray[i, j + 1].G + TempArray[i + 1, j].G + TempArray[i + 1, j + 1].G + TempArray[i - 1, j + 1].G + TempArray[i - 1, j].G + TempArray[i, j].G) / 6;
                        Blue = (TempArray[i, j + 1].B + TempArray[i + 1, j].B + TempArray[i + 1, j + 1].B + TempArray[i - 1, j + 1].B + TempArray[i - 1, j].B + TempArray[i, j].B) / 6;
                    }
                    else if (i == iWidth - 1)
                    {
                        Red = (TempArray[i, j + 1].R + TempArray[i - 1, j].R + TempArray[i - 1, j + 1].R + TempArray[i, j - 1].R + TempArray[i - 1, j - 1].R + TempArray[i, j].R) / 6;
                        Green = (TempArray[i, j + 1].G + TempArray[i - 1, j].G + TempArray[i - 1, j + 1].G + TempArray[i, j - 1].G + TempArray[i - 1, j - 1].G + TempArray[i, j].G) / 6;
                        Blue = (TempArray[i, j + 1].B + TempArray[i - 1, j].B + TempArray[i - 1, j + 1].B + TempArray[i, j - 1].B + TempArray[i - 1, j - 1].B + TempArray[i, j].B) / 6;
                    }
                    else if (j == iHeight - 1)
                    {

                        Red = (TempArray[i, j - 1].R + TempArray[i - 1, j].R + TempArray[i - 1, j - 1].R + TempArray[i + 1, j].R + TempArray[i + 1, j - 1].R + TempArray[i, j].R) / 6;
                        Green = (TempArray[i, j - 1].G + TempArray[i - 1, j].G + TempArray[i - 1, j - 1].G + TempArray[i + 1, j].G + TempArray[i + 1, j - 1].G + TempArray[i, j].G) / 6;
                        Blue = (TempArray[i, j - 1].B + TempArray[i - 1, j].B + TempArray[i - 1, j - 1].B + TempArray[i + 1, j].B + TempArray[i + 1, j - 1].B + TempArray[i, j].B) / 6;
                    }
                    else if (i == 0)
                    {

                        Red = (TempArray[i, j + 1].R + TempArray[i + 1, j].R + TempArray[i + 1, j + 1].R + TempArray[i, j - 1].R + TempArray[i + 1, j - 1].R + TempArray[i, j].R) / 6;
                        Green = (TempArray[i, j + 1].G + TempArray[i + 1, j].G + TempArray[i + 1, j + 1].G + TempArray[i, j - 1].G + TempArray[i + 1, j - 1].G + TempArray[i, j].G) / 6;
                        Blue = (TempArray[i, j + 1].B + TempArray[i + 1, j].B + TempArray[i + 1, j + 1].B + TempArray[i, j - 1].B + TempArray[i + 1, j - 1].B + TempArray[i, j].B) / 6;
                    }
                    else
                    {
                        Red = ((ImageArray[i, j].R + ImageArray[i - 1, j - 1].R + ImageArray[i - 1, j].R + ImageArray[i + 1, j - 1].R + ImageArray[i, j - 1].R + ImageArray[i + 1, j].R + ImageArray[i - 1, j + 1].R + ImageArray[i, j + 1].R + ImageArray[i + 1, j + 1].R) / 9);
                        Green = ((ImageArray[i, j].G + ImageArray[i - 1, j - 1].G + ImageArray[i - 1, j].G + ImageArray[i + 1, j - 1].G + ImageArray[i, j - 1].G + ImageArray[i + 1, j].G + ImageArray[i - 1, j + 1].G + ImageArray[i, j + 1].G + ImageArray[i + 1, j + 1].G) / 9);
                        Blue = ((ImageArray[i, j].B + ImageArray[i - 1, j - 1].B + ImageArray[i - 1, j].B + ImageArray[i + 1, j - 1].B + ImageArray[i, j - 1].B + ImageArray[i + 1, j].B + ImageArray[i - 1, j + 1].B + ImageArray[i, j + 1].B + ImageArray[i + 1, j + 1].B) / 9);
                    }
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int Red;
            int Blue;
            int Green;

            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    int average = (Red + Green + Blue) / 3;

                    Red = average;
                    Green = average;
                    Blue = average;

                    Color GreyScale = Color.FromArgb(col.A, Red, Green, Blue); //Converts image to greyscale

                    ImageArray[i, j] = GreyScale;

                }
            }

            for (int row = 0; row < 240; row = row + 1)
            {
                for (int i = 1; i < 320; i++)
                {
                    Color Value = ImageArray[i, row];
                    int j = i - 1;

                    while (j >= 0)
                    {
                        if (ImageArray[j, row].R > Value.R)
                        {
                            ImageArray[j + 1, row] = ImageArray[j, row]; //Sorts from lowest to greatest colour values horizontally
                        }

                        else
                        {
                            break;
                        }

                        j = j - 1;
                    }
                    ImageArray[j + 1, row] = Value;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnTile_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            Color[,] TempArray = new Color[160, 120];

            for (int i = 0; i < TempArray.GetLength(0); i++)
            {
                for (int j = 0; j < TempArray.GetLength(1); j++)
                {
                    Color q1 = ImageArray[2 * i + 1, 2 * j];  //Split up image into 4 quadrants
                    Color q2 = ImageArray[2 * i, 2 * j];
                    Color q3 = ImageArray[2 * i, 2 * j + 1];
                    Color q4 = ImageArray[2 * i + 1, 2 * j + 1];

                    int AverageRed = Convert.ToInt32((q1.R + q2.R + q3.R + q4.R) / 4);
                    int AverageGreen = Convert.ToInt32((q1.G + q2.G + q3.G + q4.G) / 4); //Take the average colour value from each quadrant
                    int AverageBlue = Convert.ToInt32((q1.B + q2.B + q3.B + q4.B) / 4);

                    TempArray[i, j] = Color.FromArgb(AverageRed, AverageGreen, AverageBlue);
                }

            }

            for (int i = 0; i < TempArray.GetLength(0); i++)    //For loops for each of the 4 quadrants
            {
                for (int j = 0; j < TempArray.GetLength(1); j++)  //Flips the two right images 
                {
                    ImageArray[i, j] = TempArray[i, j];
                }
            }

            for (int i = 0; i < TempArray.GetLength(0); i++)
            {
                for (int j = 0; j < TempArray.GetLength(1); j++)
                {
                    ImageArray[i + 160, j] = TempArray[i, 119 - j];
                }
            }

            for (int i = 0; i < TempArray.GetLength(0); i++)
            {
                for (int j = 0; j < TempArray.GetLength(1); j++)
                {
                    ImageArray[i, j + 120] = TempArray[159 - i, j];
                }
            }

            for (int i = 0; i < TempArray.GetLength(0); i++)
            {
                for (int j = 0; j < TempArray.GetLength(1); j++)
                {
                    ImageArray[i + 160, j + 120] = TempArray[159 - i, 119 - j];
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnExtractRed_Click(object sender, EventArgs e)
        {
            {
                if (bitmapImage == null)
                    return;

                /// Process the array data here!!!

                Byte Red;

                int iWidth = 320;
                int iHeight = 240;

                // The sample code extracts the Red channel of a pixel and assign the color only to Red channel

                for (int i = 0; i < iWidth; i++)
                {
                    for (int j = 0; j < iHeight; j++)
                    {
                        Color col = ImageArray[i, j];

                        //Get the red element of the color
                        Red = col.R;

                        Color newColor = Color.FromArgb(255, Red, 0, 0);
                        ImageArray[i, j] = newColor;

                    }
                }

                SetBitmapFromAray();
                picImage.Image = bitmapImage;
            }
        }

        private void btnExtractGreen_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            byte Green;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Green = col.G;

                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnExtractBlue_Click(object sender, EventArgs e)
        {
            {
                if (bitmapImage == null)
                    return;

                /// Process the array data here!!!

                Byte Blue;

                int iWidth = 320;
                int iHeight = 240;

                // The sample code extracts the Blue channel of a pixel and assign the color only to Blue channel

                for (int i = 0; i < iWidth; i++)
                {
                    for (int j = 0; j < iHeight; j++)
                    {
                        Color col = ImageArray[i, j];

                        //Get the blue element of the color
                        Blue = col.B;

                        Color newColor = Color.FromArgb(255, 0, 0, Blue);
                        ImageArray[i, j] = newColor;

                    }
                }

                SetBitmapFromAray();
                picImage.Image = bitmapImage;
            }
        }

        private void btnFlipHorizontal_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            for (int i = 0; i < 160; i++)
            {
                for (int j = 0; j < 240; j++)
                {
                    Color TempPix = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[319 - i, j]; //Stores pixels in temp Array
                    ImageArray[319 - i, j] = TempPix; //Flips image horizontally like a mirror
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipVertically_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            for (int i = 0; i < 320; i++)
            {
                for (int j = 0; j < 120; j++)
                {
                    Color temp = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[i, 239 - j]; //Stores pixels in temp Array
                    ImageArray[i, 239 - j] = temp; //Flips image vertically
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

/*            if (bitmapImage == null)
                return;*/
        }
    }
}
