using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

/**

* Esta clase contiene los métodos relacionados con los eventos que se presentan en la interfaz de usuario.

* @author: Lizbeth Peralta Malváez

* @version: 14/10/2016/C

*/

namespace DetecciónCromática
{
    public partial class Form1 : Form
    {
        //Campos de la clase
        int minR, maxR, minG, maxG, minB, maxB;
        int minH, maxH, minS, maxS, minV2, maxV2;

        string[] pathImages;
        Bitmap image;
        Bitmap copiaImagen;
        Color pixel;
        //Las imágenes serán guardadas Desktop
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public Form1()
        {
            InitializeComponent();
        }

        /**BTN_RGB_Click
        * Al dar click en "RGB", se  llama a la función getRGB
        */
        private void BTN_RGB_Click(object sender, EventArgs e)
        {
                getRGB();
        }

        /**BTN_YUV_Click
       * Al dar click en "YUV", se  llama a la función getYUV
         * Cuando el método termina, la interfaz pondrá un "DONE"
       */
        private void BTN_YUV_Click(object sender, EventArgs e)
        {
                getImagesYUV();
                LBL_STATUSYUV.Text = "DONE";
        }

        /**BTN_HSV_Click
       * Al dar click en "HSV", se  llama a la función getHSV
       */
        private void BTN_HSV_Click(object sender, EventArgs e)
        {
                getHSV();     
        }

        /**getRGB
        * Asigna el rango en RGB del color verde y llama al método getImagesRGB.
         * Cuando el método termina, la interfaz pondrá un "DONE"
        */
        public void getRGB()
        {
            minR = 0; minG = 35; minB = 0;
            maxR = 0; maxG = 255; maxB = 0;

            getImagesRGB();
            LBL_STATUSRGB.Text = "DONE";
        }

        /**getHSV
       * Asigna el rango en HSV del color verde y llama al método getImagesHSV.
        * Cuando el método termina, la interfaz pondrá un "DONE"
       */
        public void getHSV() 
        {
            minH = 90; maxH = 150;

            minS = 50;
            maxS = 100;

            minV2 = 15;
            maxV2 = 100;

            getImagesHSV();
            LBL_STATUSHSV.Text = "DONE";
        }

        /**getImagesRGB
         * Primero se crea una carpeta donde se guardarán las imágenes modificadas.
         * Se obtendrá de cada imagen su RGB. Si éste está dentro del rango obtenido en el método
         * getRGB, se pintará de blanco el pixel. Si no está dentro del rango, se quedará con su color
         * original.
         * Cuando se termine de modificar cada imagen, se sumará el parámetro number, el cual es 
         * utilizado en la interfaz para indicar al usuario cuánto falta para que termine el programa.
        */
        public void getImagesRGB() 
        {
            string path = filePath + @"\BSR_RGB\";
            System.IO.Directory.CreateDirectory(path);
            int r = 0; int g = 0;  int b = 0;
            int number = 1;
            pathImages = Directory.GetFiles(@"...\BSR\BSDS500\data\images\train", "*.jpg");
            for (int i = 0; i < pathImages.Length; i++) {
                image = new Bitmap((Bitmap) Image.FromFile(pathImages[i], true));
                copiaImagen = new Bitmap(image);
                for (int x = 0; x < copiaImagen.Width; x++)
                {
                    for (int y = 0; y < copiaImagen.Height; y++)
                    {
                        pixel = copiaImagen.GetPixel(x, y);
                        if ((pixel.R > minR || pixel.R < maxR) && (pixel.G > minG || pixel.G < maxG) &&
                        (pixel.B > minB || pixel.B < maxB))
                        {
                            r = 255;
                            g = 255;
                            b = 255;
                        }
                        else {
                            r = pixel.R;
                            g = pixel.G;
                            b = pixel.B;
                        }
                        copiaImagen.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
                copiaImagen.Save(path + number.ToString() + ".jpg");
                LBL_IMAGERGB.Text = number.ToString();
                LBL_IMAGERGB.Refresh();
                number++;
            }
        }

        /**getImagesYUV
        * Primero se crea una carpeta donde se guardarán las imágenes modificadas.
        * Se obtendrá de cada imagen su YUV. Si la Y es mayor a .6 (rango de verde), 
         * se pintará de blanco el pixel. Si no está dentro del rango, se quedará con su color
        * original.
        * Cuando se termine de modificar cada imagen, se sumará el parámetro number, el cual es 
        * utilizado en la interfaz para indicar al usuario cuánto falta para que termine el programa.
       */
        public void getImagesYUV()
        {
            string path = filePath + @"\BSR_YUV\";
            System.IO.Directory.CreateDirectory(path);
            int r = 0; int g = 0; int b = 0;
            double Y = 0; double U = 0; double V = 0;
            int number = 1;
            pathImages = Directory.GetFiles(@"...\BSR\BSDS500\data\images\train", "*.jpg");
            for (int i = 0; i < pathImages.Length; i++)
            {
                image = new Bitmap((Bitmap)Image.FromFile(pathImages[i], true));
                copiaImagen = new Bitmap(image);
                for (int x = 0; x < copiaImagen.Width; x++)
                {
                    for (int y = 0; y < copiaImagen.Height; y++)
                    {
                        pixel = copiaImagen.GetPixel(x, y);
                        Y = Math.Abs(((.299 * pixel.R) + (.587 * pixel.G) + (.114 * pixel.B))/255);
                        U = Math.Abs((-(.147 * pixel.R) - (.289 * pixel.G) + (.436 * pixel.G))/255);
                        V = Math.Abs(((.615 * pixel.R) - (.515 * pixel.G) - (.100 * pixel.B))/255);
                        if (Y >= .6)
                        {
                            r = 255;
                            g = 255;
                            b = 255;
                        }
                        else
                        {
                            r = pixel.R;
                            g = pixel.G;
                            b = pixel.B;
                        }
                        copiaImagen.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
                copiaImagen.Save(path + number.ToString() + ".jpg");
                LBL_IMAGEYUV.Text = number.ToString();
                LBL_IMAGEYUV.Refresh();
                number++;
            }
        }

        /**getImagesHSV
        * Primero se crea una carpeta donde se guardarán las imágenes modificadas.
        * Se obtendrá de cada imagen su HSV. Si éste está dentro del rango obtenido en el método
        * getHSV, se pintará de blanco el pixel. Si no está dentro del rango, se quedará con su color
        * original.
        * Cuando se termine de modificar cada imagen, se sumará el parámetro number, el cual es 
        * utilizado en la interfaz para indicar al usuario cuánto falta para que termine el programa.
       **/
        public void getImagesHSV()
        {
            string path = filePath + @"\BSR_HSV\";
            System.IO.Directory.CreateDirectory(path);

            double rNorm ; 
            double gNorm = 0; 
            double bNorm = 0;

            double max = 0; double min = 0; double chroma = 0;
            int r = 0; int g = 0; int b = 0;
            double H = 0; double S = 0; double V = 0;
            int number = 1;

            pathImages = Directory.GetFiles(@"...\BSR\BSDS500\data\images\train", "*.jpg");
            
            for (int i = 0; i < pathImages.Length; i++)
            {
                image = new Bitmap((Bitmap)Image.FromFile(pathImages[i], true));
                copiaImagen = new Bitmap(image);

                for (int x = 0; x < copiaImagen.Width; x++)
                {
                    for (int y = 0; y < copiaImagen.Height; y++)
                    {
                        pixel = copiaImagen.GetPixel(x, y);
                        rNorm = (double)pixel.R/(double)255;
                        gNorm = (double)pixel.G/(double)255;
                        bNorm = (double)pixel.B/(double)255;

                        max = Math.Max(rNorm, Math.Max(gNorm, bNorm));
                        min = Math.Min(rNorm, Math.Min(gNorm, bNorm));
                        chroma = max - min;

                        if (max == rNorm)
                        {
                            H = 60 * (((gNorm - bNorm) / chroma) % 6);
                        }
                        else if (max == gNorm)
                        {
                            H = 60 * (((bNorm - rNorm) / chroma) +2);
                        }
                        else if (max == bNorm)
                        {
                            H = 60 * (((rNorm - gNorm) / chroma) + 4);
                        }

                        if (max == 0) {S = 0;}
                        if (max != 0) { S = (chroma / max) * 100; }

                        V = max * 100;

                        if (H > minH && H < maxH)
                        {
                            if (S > maxS)
                            {
                                r = 255;
                                g = 255;
                                b = 255;
                            }
                            if (S < minS)
                            {
                                r = 255;
                                g = 255;
                                b = 255;
                            }
                        }
                        else {
                            r = pixel.R;
                            g = pixel.G;
                            b = pixel.B;
                        }
                        copiaImagen.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
                copiaImagen.Save(path + number.ToString() + ".jpg");
                LBL_IMAGEHSV.Text = number.ToString();
                LBL_IMAGEHSV.Refresh();
                number++;
            }
        }
    }
}