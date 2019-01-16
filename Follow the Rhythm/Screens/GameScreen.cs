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
        int booCount = 0;

        List<int> noteXList = new List<int>();
        List<int> noteYList = new List<int>();

        SolidBrush noteBrush = new SolidBrush(Color.Blue);

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
            noteSize = 64;
            noteSpeed = 5;

            noteXList.Add(165);
            noteYList.Add(0);

            noteXList.Add(245);
            noteYList.Add(0);

            noteXList.Add(325);
            noteYList.Add(0);

            noteXList.Add(405);
            noteYList.Add(0);

            //g.DrawString("Excellent", drawFont, drawBrush, 1, 66);
            // So I'm wondering if drawing all the labels would be better, 
            //since I need like 5 different pens and things...


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
            //how do I remove arrows altogether if they go offscreen?

            /*if (noteYList[i] > this.Height)
            {
                noteYList.Remove(number placement of note. If it's note 2 you put 2);
            }*/

            //TODO collisions checks 
            //between the arrows themselves and the icons at the bottom of screen

            //Rectangle noteRec2 = new Rectangle(noteX, noteY, noteSize, noteSize);

            //Rectangle noteBox3 = new Rectangle(noteX, noteY, noteSize, noteSize);
            //Rectangle noteBox4 = new Rectangle(noteX, noteY, noteSize, noteSize);

            Rectangle boxRec1 = new Rectangle(165, 310, 64, 64);
            Rectangle boxRec2 = new Rectangle(245, 310, 64, 64);
            Rectangle boxRec3 = new Rectangle(325, 310, 64, 64);
            Rectangle boxRec4 = new Rectangle(405, 310, 64, 64);

            for (int i = 0; i < noteYList.Count; i++)
            {
                if (noteYList[i] > this.Height)
                {
                    noteYList.RemoveAt(i);
                    noteXList.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < noteYList.Count; i++)
            {
                Rectangle noteRec1 = new Rectangle(noteXList[i], noteYList[i], noteSize, noteSize);

                if (noteRec1.IntersectsWith(boxRec1))
                {
                    noteXList[i]++;

                    //if player presses key it dissapears and adds to a tally, which tally depends on the timing of
                    //the press in relation to the note's position over the note icon at the bottom
                    // to delete a note, do noteList.Remove(2);

                    //while collision is happening, I need to program what can happen when you press
                    //a key depending on the location of the note in relation to the box

                    if (leftArrowDown == true)
                    {
                        noteYList.RemoveAt(i);
                        noteXList.RemoveAt(i);
                       
                        excelCount++;
                        exCount.Text = excelCount + "";
                        //noteYList.Remove(0);
                    }
                    if (rightArrowDown == true || upArrowDown == true || rightArrowDown == true)
                    {
                        booCount++;
                        boCount.Text = booCount + "";
                    }
                }

                //if (noteYList(i).IntersectsWith(boxRec2))
               // {

                //}
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
                e.Graphics.DrawImage(Properties.Resources.down, 165 + i * 80, 311, 64, 64);
            }

            Pen notePen = new Pen(Color.White);
            //Notes(notePen, noteX, noteY, noteSize);
            int x = noteX;
            int y = noteY;
            float scale = noteSize / 130;

            e.Graphics.DrawLine(notePen, (55 * scale) + x, (55 * scale) + y, (405 * scale) + x, (151 * scale) + y);
            e.Graphics.DrawLine(notePen, (405 * scale) + x, (151 * scale) + y, (295 * scale) + x, (238 * scale) + y);
            e.Graphics.DrawLine(notePen, (295 * scale) + x, (238 * scale) + y, (425 * scale) + x, (357 * scale) + y);
            e.Graphics.DrawLine(notePen, (425 * scale) + x, (357 * scale) + y, (354 * scale) + x, (422 * scale) + y);
            e.Graphics.DrawLine(notePen, (354 * scale) + x, (422 * scale) + y, (210 * scale) + x, (292 * scale) + y);
            e.Graphics.DrawLine(notePen, (210 * scale) + x, (292 * scale) + y, (91 * scale) + x, (427 * scale) + y);
            e.Graphics.DrawLine(notePen, (91 * scale) + x, (427 * scale) + y, (55 * scale) + x, (55 * scale) + y);

            SolidBrush collisionBrush = new SolidBrush(Color.Red);
            
            //to help visualize collision
            e.Graphics.FillRectangle(collisionBrush, 165, 310, 64, 64);
            e.Graphics.FillRectangle(collisionBrush, 245, 310, 64, 64);
            e.Graphics.FillRectangle(collisionBrush, 325, 310, 64, 64);
            e.Graphics.FillRectangle(collisionBrush, 405, 310, 64, 64);
        }

        //Notes(Pen notePen, float x, float y, float size)
    }

}
