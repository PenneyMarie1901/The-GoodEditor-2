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

namespace TheGoodEditor2.EditorWindows
{
    public partial class TextureViewer : Form
    {
        public TextureViewer()
        {
            InitializeComponent();
        }

        private void TextureViewer_Load(object sender, EventArgs e)
        {
            byte[] untrimmed = MainWindow.x;
            byte[] trimmed = untrimmed.Skip(32).ToArray();
            var bmp = TPL.Load(trimmed);
            Bitmap newbmp = new Bitmap(bmp.ExtractTexture());

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
    }
}
