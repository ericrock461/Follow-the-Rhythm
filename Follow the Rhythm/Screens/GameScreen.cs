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


        Font drawFont = new Font("MS Reference Sans Serif", 12, FontStyle.Bold);
        SolidBrush barBrush = new SolidBrush(Color.Green);

        SolidBrush noteBrush = new SolidBrush(Color.Blue);

        private void missLabel_Click(object sender, EventArgs e)
        {
            //OOOOOOPS
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            //NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO    ;
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

            ///what I need to do:
            ///figure out how I'm going to draw/create all 4 note methods
            ///figure out when to create each new note (I also have to choose a song)
            ///figure out how to make it so the Boo Counter will NOT be active if multiple notes are over different boxes
            ///figure out how on earth I'll create a progress bar and a bar for how well you're doing
            ///I think there were more things... like... how to make the boo counter less sensitive?
            ///how to work the note counter (oh wait this can replace the progress bar!! (maybe)
            ///minor thing: how to make it so you can choose buttons with the arrow keys


            //PaintEventArgs e;

            //e.TranslateTransform(200, 50);
            //e.DrawString("| | | | | | |", drawFont, barBrush, new Rectangle());
            //e.RotateTransform(90);
           // e.ResetTransform();


            noteX = 100;
            noteY = 100;
            noteSize = 64;
            noteSpeed = 5;

            noteXList.Add(165);
            noteYList.Add(-100);

            noteXList.Add(245);
            noteYList.Add(-70);

            noteXList.Add(325);
            noteYList.Add(80);

            noteXList.Add(405);
            noteYList.Add(80);

            //MS Reference Sans Serif size 10
            //g.DrawString("Excellent", drawFont, drawBrush, 1, 66);
            // So I'm wondering if drawing all the labels would be better or worse, 
            //since I need like 5 different pens and things...


            ///Notes will all have the same properties, including size and speed.
            /// I just don't know how I'm going to create each new note...
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // opens a pause screen if escape is pressed. Depending on what is pressed
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

            //basic player 1 key down bools set below
            //(player 1 button presses)

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
            //basic player 1 key up bools set below
            //(player 1 button releases)

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
            //move arrows (notes) down the screen
            for (int i = 0; i < noteYList.Count; i++)
            {
                {
                    noteYList[i] = noteYList[i] + noteSpeed;
                }

                noteCounter.Text = noteYList.Count() + " / 100";              
            }

            //collisions checks 
            //(between the arrows themselves and the icons at the bottom of screen)

            Rectangle boxRec1 = new Rectangle(165, 300, 64, 64);
            Rectangle boxRec2 = new Rectangle(245, 300, 64, 64);
            Rectangle boxRec3 = new Rectangle(325, 300, 64, 64);
            Rectangle boxRec4 = new Rectangle(405, 300, 64, 64);

            for (int i = 0; i < noteYList.Count; i++)
            {
                if (noteYList[i] > this.Height)
                {
                    noteYList.RemoveAt(i);
                    noteXList.RemoveAt(i);

                    missCount++;
                    msCount.Text = missCount + "";
                    break;
                }
            }

            for (int i = 0; i < noteYList.Count; i++)
            {
                
                //Collision rectangle for all notes falling down the screen
                Rectangle noteRec = new Rectangle(noteXList[i], noteYList[i], noteSize, noteSize);

                if (noteRec.IntersectsWith(boxRec1))
                {

                    //if player presses key it dissapears and adds to a tally, which tally depends on the timing of
                    //the press in relation to the note's position over the note icon at the bottom

                    //while collision is happening, I need to program what can happen when you press
                    //a key depending on the location of the note in relation to the box

                    //I also need some way to make it so that the boo counter will not activate if there 
                    //are 2 notes coming down next to each other

                    //left arrow code
                    if (leftArrowDown == true)
                    {
                        noteYList.RemoveAt(i);
                        noteXList.RemoveAt(i);

                        excelCount++;
                        exCount.Text = excelCount + "";
                    }
                    if (downArrowDown == true || upArrowDown == true || rightArrowDown == true)
                    {
                        booCount++;
                        boCount.Text = booCount + "";
                    }
                    else if (noteRec.IntersectsWith(boxRec1) && noteRec.IntersectsWith(boxRec2))
                    {
                        //booCount = doesnt work;
                    }
                    else if (noteRec.IntersectsWith(boxRec1) && noteRec.IntersectsWith(boxRec3))
                    {

                    }
                    else if (noteRec.IntersectsWith(boxRec1) && noteRec.IntersectsWith(boxRec4))
                    {

                    }
                }

                if (noteRec.IntersectsWith(boxRec2))
               {
                    //down arrow code
                    if (downArrowDown == true)
                    {
                        noteYList.RemoveAt(i);
                        noteXList.RemoveAt(i);

                        excelCount++;
                        exCount.Text = excelCount + "";
                    }
                    if (leftArrowDown == true || upArrowDown == true || rightArrowDown == true)
                    {
                        booCount++;
                        boCount.Text = booCount + "";
                    }                   
                }

                if (noteRec.IntersectsWith(boxRec3))
                {
                    //up arrow code
                    if (upArrowDown == true)
                    {
                        noteYList.RemoveAt(i);
                        noteXList.RemoveAt(i);

                        excelCount++;
                        exCount.Text = excelCount + "";
                    }
                    if (leftArrowDown == true || downArrowDown == true || rightArrowDown == true)
                    {
                        booCount++;
                        boCount.Text = booCount + "";
                    }                   
                }

                if (noteRec.IntersectsWith(boxRec4))
                {
                    //right arrow down
                    if (rightArrowDown == true)
                    {
                        noteYList.RemoveAt(i);
                        noteXList.RemoveAt(i);

                        excelCount++;
                        exCount.Text = excelCount + "";
                    }
                    if (leftArrowDown == true || downArrowDown == true || upArrowDown == true)
                    {
                        booCount++;
                        boCount.Text = booCount + "";
                    }
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
