using System;
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
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //player2 button control keys - DO NOT CHANGE
        //Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown;

        private void label2_Click(object sender, EventArgs e)
        {
            //NOOOOOOOOOOOOOO
        }

        //TODO create your global game variables here
        int noteX, noteY;
        int noteSize = 0;
        int noteSpeed = 0;

        int excelCount = 0;
        int greatCount = 0;
        int okCount = 0;
        int missCount = 0;

        List<int> noteXList = new List<int>();

        private void missLabel_Click(object sender, EventArgs e)
        {
            //OOOOOOPS
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            //NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO    ;
        }

        List<int> noteYList = new List<int>();

        SolidBrush noteBrush = new SolidBrush(Color.Blue);

        public GameScreen()
        {
            InitializeComponent();
            InitializeGameValues();
        }

        public void InitializeGameValues()
        {
            //TODO - setup all your initial game values here. Use this method
            // each time you restart your game to reset all values.
            noteX = 100;
            noteY = 100;
            noteSize = 20;
            noteSpeed = 5;

            noteXList.Add(100);
            noteYList.Add(0);      

            noteXList.Add(200);
            noteYList.Add(0);   

            noteXList.Add(300);
            noteYList.Add(0);

            noteXList.Add(400);
            noteYList.Add(0);

            ///remember to make a list for all 4 areas you will need notes. Do you even need one though?
            ///Wait..... do I need a separate list for each note-drop point?
            ///Notes will all have the same properties, including size and speed.
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // opens a pause screen is escape is pressed. Depending on what is pressed
            // on pause screen the program will either continue or exit to main menu
            if (e.KeyCode == Keys.Escape && gameTimer.Enabled)
            {
                gameTimer.Enabled = false;
                rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

                DialogResult result = PauseForm.Show();

                if (result == DialogResult.Cancel)
                {
                    gameTimer.Enabled = true;
                }
                else if (result == DialogResult.Abort)
                {
                    MainForm.ChangeScreen(this, "MenuScreen");
                }
            }

            //TODO - basic player 1 key down bools set below. Add remainging key down
            // required for player 1 or player 2 here.

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //TODO - basic player 1 key up bools set below. Add remainging key up
            // required for player 1 or player 2 here.

            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        /// <summary>
        /// This is the Game Engine and repeats on each interval of the timer. For example
        /// if the interval is set to 16 then it will run each 16ms or approx. 50 times
        /// per second
        /// </summary>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //TODO move arrows (notes) down the screen
            for (int i = 0; i < noteYList.Count; i++)
            {              
                {
                    noteYList[i] = noteYList[i] + noteSpeed;
                }
            }

            if (noteY > this.Height)
            {
                noteY = 0; //how to make notes disappear?
            }

            //TODO collisions checks 
            //between the arrows themselves and the icons at the bottom of screen

            //calls the GameScreen_Paint method to draw the screen.
            Refresh();
        }


        //Everything that is to be drawn on the screen should be done here
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < noteXList.Count; i++)
            {
                e.Graphics.FillRectangle(noteBrush, noteXList[i], noteYList[i], noteSize, noteSize);
            }
        }
    }

}
