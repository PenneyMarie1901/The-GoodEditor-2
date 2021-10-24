using HiHoFile;
using libWiiSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGoodEditor2.EditorWindows.TextureEditors
{
    public partial class ExtraTextureOptionsWindow : Form
    {
        public ExtraTextureOptionsWindow()
        {
            InitializeComponent();
        }

        private void ExtraTextureOptionsWindow_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow form = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
            if (form != null)
            {
                form.setColors();
            }
        }
    }
}
