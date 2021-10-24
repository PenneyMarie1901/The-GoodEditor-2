using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libWiiSharp;
using TheGoodEditor2.EditorWindows.TextureEditors;

namespace TheGoodEditor2.EditorWindows
{
    public partial class TextureViewer : Form
    {
        public TextureViewer()
        {
            InitializeComponent();
        }
        public static byte[] customTextureData;
        private void TextureViewer_Load(object sender, EventArgs e)
        {
            byte[] untrimmed = MainWindow.x;
            byte[] trimmed = untrimmed.Skip(32).ToArray();
            var bmp = TPL.Load(trimmed);
            Bitmap newbmp = new Bitmap(bmp.ExtractTexture());
            lblActualWidth.Text = newbmp.Width.ToString();
            lblActuHeight.Text = newbmp.Height.ToString();
            textureViewerBox.Image = newbmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Portable Network Graphics Files (*.png) | *.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textureViewerBox.Image.Save(sfd.FileName, ImageFormat.Png);
            }
        }

        private void saveAsJpg_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Join Picture Experts Group Files (*.jpg) | *.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textureViewerBox.Image.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Image imgRight = textureViewerBox.Image;
            imgRight.RotateFlip(RotateFlipType.Rotate90FlipNone);
            textureViewerBox.Image = imgRight;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image imgRight = textureViewerBox.Image;
            imgRight.RotateFlip(RotateFlipType.Rotate270FlipNone);
            textureViewerBox.Image = imgRight;
        }

        private void btnImportTexture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] saveToArray = MainWindow.x;
                var newTextureFileFromImage =  textureViewerBox.Image = new Bitmap(ofd.FileName);
                textureViewerBox.Image = newTextureFileFromImage;
                
                
                Bitmap newTextureFile = new Bitmap(textureViewerBox.Image, 64, 64);
                var newTPLTEMP = TPL.FromImage(newTextureFile, TPL_TextureFormat.RGB565);
                byte[] finalNewTexture = newTPLTEMP.ToByteArray();

                string extraHeaderData32Bytes = "00 00 00 01 3F 80 00 00 00 02 00 00 78 C8 74 06 EE 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
                byte[] extraHeaderData = extraHeaderData32Bytes
                  .Split(' ')                               // Split into items 
                  .Select(item => Convert.ToByte(item, 16)) // Convert each item into byte
                  .ToArray();
                List<byte> list = new List<byte>();
                list.AddRange(extraHeaderData);
                list.AddRange(finalNewTexture);

                byte[] ActualFinalTexture = list.ToArray();



                customTextureData = ActualFinalTexture;

                MainWindow form = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
                if (form != null)
                {
                    form.saveNewCustomTexture(sender, e);
                    form.refreshTextureViewerPreviewBox();
                }
            }
        }

        private void detailsContainer_Enter(object sender, EventArgs e)
        {

        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Image imgRight = textureViewerBox.Image;
            imgRight.RotateFlip(RotateFlipType.RotateNoneFlipX);
            textureViewerBox.Image = imgRight;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Image imgRight = textureViewerBox.Image;
            imgRight.RotateFlip(RotateFlipType.RotateNoneFlipY);
            textureViewerBox.Image = imgRight;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                textureViewerBox.Image = null;
                int width = 64;
                int height = 64;
                Bitmap resultImage = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                resultImage.SetPixel(width, height, cld.Color);
                textureViewerBox.Image = resultImage;
                
            }
        }

        private void btnReplaceWithSolidColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                int Width = 64;
                int Height = 64;
                textureViewerBox.Image = new Bitmap(Width, Height);
                Graphics graphics = Graphics.FromImage(textureViewerBox.Image);

                Brush brush = new SolidBrush(cld.Color);

                graphics.FillRectangle(brush, new System.Drawing.Rectangle(0, 0, textureViewerBox.Width, textureViewerBox.Height));
                Bitmap newTextureFile = new Bitmap(textureViewerBox.Image, 64, 64);
                var newTPLTEMP = TPL.FromImage(newTextureFile, TPL_TextureFormat.RGB565);
                byte[] finalNewTexture = newTPLTEMP.ToByteArray();

                string extraHeaderData32Bytes = "00 00 00 01 3F 80 00 00 00 02 00 00 78 C8 74 06 EE 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
                byte[] extraHeaderData = extraHeaderData32Bytes
                  .Split(' ')                               // Split into items 
                  .Select(item => Convert.ToByte(item, 16)) // Convert each item into byte
                  .ToArray();
                List<byte> list = new List<byte>();
                list.AddRange(extraHeaderData);
                list.AddRange(finalNewTexture);

                byte[] ActualFinalTexture = list.ToArray();



                customTextureData = ActualFinalTexture;

                MainWindow form = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
                if (form != null)
                {
                    form.saveNewCustomTexture(sender, e);
                    form.refreshTextureViewerPreviewBox();
                }
            }
        }

        private void btnOpenIngameRotationEditor_Click(object sender, EventArgs e)
        {
            InGameRotationEditor inGameRotationEditorWindow = new InGameRotationEditor();
            inGameRotationEditorWindow.ShowDialog();
        }
        public void rotateImage90Right(object sender, EventArgs e)
        {
            
        }
        public void rotateImage90Left(object sender, EventArgs e)
        {
            Image imgLeft = textureViewerBox.Image;
            imgLeft.RotateFlip(RotateFlipType.Rotate90FlipNone);
            textureViewerBox.Image = imgLeft;
        }
    }
}
