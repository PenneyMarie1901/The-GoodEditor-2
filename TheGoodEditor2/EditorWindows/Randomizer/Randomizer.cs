using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGoodEditor2.EditorWindows.Randomizer
{
    public partial class Randomizer : Form
    {
        public Randomizer()
        {
            InitializeComponent();
        }

        private void Randomizer_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow form = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
            if (form != null)
            {
                if (rdoSimpleObjects.Checked)
                {
                    if (chkPosX.Checked)
                    {
                        form.RandomizePositionXSimpleObject(sender, e);
                    }
                }
            }
        }
    }
}
