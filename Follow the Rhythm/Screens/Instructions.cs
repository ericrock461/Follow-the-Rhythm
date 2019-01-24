using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Follow_the_Rhythm
{
    public partial class Instructions : UserControl
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "MenuScreen");
        }
    }
}
