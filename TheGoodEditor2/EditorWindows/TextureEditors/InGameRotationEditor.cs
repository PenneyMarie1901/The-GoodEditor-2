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
    public partial class InGameRotationEditor : Form
    {
        public InGameRotationEditor()
        {
            InitializeComponent();
        }

        private void btnRotate90Left_Click(object sender, EventArgs e)
        {
            TextureViewer form = Application.OpenForms.OfType<TextureViewer>().FirstOrDefault();
            if (form != null)
            {
                form.rotateImage90Left(sender, e);
            }
        }

        private void btnRotate90Right_Click(object sender, EventArgs e)
        {
            TextureViewer form = Application.OpenForms.OfType<TextureViewer>().FirstOrDefault();
            if (form != null)
            {
                form.rotateImage90Right(sender, e);
            }
        }
    }
}
