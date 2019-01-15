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

        //But... if I'm going to just use images for the notes, instead of drawing them.....
        //how does that work!? And what will I draw to the screen!? Nothing!?!?!
        //Or, I could create a note method to use for the falling notes and the icons
        //and what if I can't get note icons? Then I would have to draw the notes...

        //create a variable that tracks time between arrow appearances...?


        //TODO create your global game variables here
        int noteX, noteY;
        int noteSize = 0;
        int noteSpeed = 0;

        int excelCount = 0;
        int greatCount = 0;
        int okCount = 0;
        int missCount = 0;

        Rectangle box1 = new Rectangle(170, 320, 58, 50);

        List<int> noteXList = new List<int>();

        private void missLabel_Click(object sender, EventArgs e)
        {
            //OOOOOOPS
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            //NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO    ;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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
            noteSize = 38;
            noteSpeed = 5;

            noteXList.Add(150);
            noteYList.Add(0);      

            noteXList.Add(240);
            noteYList.Add(0);   

            noteXList.Add(330);
            noteYList.Add(0);

            noteXList.Add(420);
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

                case Keys.B:
                    bDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;                
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //TODO - basic player 1 key up bools set below. Add remaining key up
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

                case Keys.B:
                    bDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
            }
        }

        /// <summary>
        /// This is the Game Engine and repeats on each interval of the timer. For example
        /// if the interval is set to 16 then it will run each 16ms or approx. 50 times
        /// per second
        /// </summary>
        /// 
        // 170, 320
        //58x50
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //TODO move arrows (notes) down the screen
            for (int i = 0; i < noteYList.Count; i++)
            {              
                {
                    noteYList[i] = noteYList[i] + noteSpeed;
                }
                noteCounter.Text = noteYList.Count() + " / 100";
                //I wish I had a list for complete notes, not separate X and Y lists.......
                //I feel like it would be easier dealing with whole objects rather then separate X and Y lists

                /*if (noteYList[i] > this.Height)
                {
                    noteYList.Remove();
                    //how would I do this???
                }*/
            }

            /*if (noteYList[i] > this.Height)
            {
                noteYList.Remove(number placement of note. If it's note 2 you put 2);
            }*/

            //TODO collisions checks 
            //between the arrows themselves and the icons at the bottom of screen
            Rectangle noteIconRec1 = new Rectangle(noteX, noteY, noteSize, noteSize);
            Rectangle noteIconRec2 = new Rectangle(noteX, noteY, noteSize, noteSize);
            Rectangle noteIconRec3 = new Rectangle(noteX, noteY, noteSize, noteSize);
            Rectangle noteIconRec4 = new Rectangle(noteX, noteY, noteSize, noteSize);

            for (int i = 0; i < noteYList.Count; i++)
            {
                Rectangle noteRec = new Rectangle(noteXList[i], noteYList[i], noteSize, noteSize);

                while (noteIconRec1.IntersectsWith(noteRec) )
                {
                    //if player presses key it dissapears and adds to a tally, which tally depends on the timing of
                    //the press in relation to the note's position over the note icon at the bottom
                    // to delete a note, do noteList.Remove(2);
                }
            }

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

            for (int i = 0; i < 4; i++)
            {
                e.Graphics.DrawImage(Properties.Resources.down, 165 +i*80, 311, 62, 62);
            }

            //Pen notePen = new Pen(Color.White);
            //Notes(notePen, noteX, noteY, noteSize);
        }

        /*private void Notes(Pen notePen, float x, float y, float size)
        {
            Graphics g = this.CreateGraphics();

            float scale = size / 130;

            g.DrawLine(notePen, (55 * scale) + x, (55 * scale) + y, (405 * scale) + x, (151 * scale) + y);
            g.DrawLine(notePen, (405 * scale) + x, (151 * scale) + y, (295 * scale) + x, (238 * scale) + y);
            g.DrawLine(notePen, (295 * scale) + x, (238 * scale) + y, (425 * scale) + x, (357 * scale) + y);
            g.DrawLine(notePen, (425 * scale) + x, (357 * scale) + y, (354 * scale) + x, (422 * scale) + y);
            g.DrawLine(notePen, (354 * scale) + x, (422 * scale) + y, (210 * scale) + x, (292 * scale) + y);
            g.DrawLine(notePen, (210 * scale) + x, (292 * scale) + y, (91 * scale) + x, (427 * scale) + y);
            g.DrawLine(notePen, (91 * scale) + x, (427 * scale) + y, (55 * scale) + x, (55 * scale) + y);
        }*/
    }

}
