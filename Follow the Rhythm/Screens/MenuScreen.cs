﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSystemServices;

namespace Follow_the_Rhythm
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "GameScreen");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "Instructions");
        }

        private void button_Enter(object sender, EventArgs e)
        {
            //start by changing all the buttons to the default colour
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    c.BackColor = Color.Aquamarine;
            }

            //change the current button to the active colour
            Button btn = (Button)sender;
            btn.BackColor = Color.Gold;
        }

        private void title_Click(object sender, EventArgs e)
        {
            //ooooooooops
        }

        private void subtitle_Click(object sender, EventArgs e)
        {
            //why is this happening!?!?!?!?!
        }
    }
}
