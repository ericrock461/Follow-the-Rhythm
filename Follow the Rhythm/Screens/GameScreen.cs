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
using System.Threading;
using System.IO;
//using System.Windows.Media;

namespace Follow_the_Rhythm
{
    public partial class GameScreen : UserControl
    {
        System.Windows.Media.MediaPlayer gamemusicPlayer;

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
        int noteSize = 0;
        int noteSpeed = 0;
        int noteNumber = 0;

        int excelCount = 0;
        int greatCount = 0;
        int okCount = 0;
        int missCount = 0;
        int booCount = 0;

        int tempCounter = 0;

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
            gamemusicPlayer = new System.Windows.Media.MediaPlayer();
            gamemusicPlayer.Open(new Uri(Application.StartupPath + "/Resources/music.mp3"));
            //gamemusicPlayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler;
            gamemusicPlayer.Play();

           
            Thread.Sleep(2900);
            
            //TODO - setup all your initial game values here. Use this method
            // each time you restart your game to reset all values.                       

            noteSize = 64;
            noteSpeed = 10;

            //x values: 165, 245, 325, 405. y value: -64
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
            tempCounter++;

            timerCount.Text = tempCounter + "";

            //first 6 notes of main melody
            if (tempCounter == 10)
            {
                noteXList.Add(165);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 15)
            {
                noteXList.Add(405);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 25)
            {
                noteXList.Add(165);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 30)
            {
                noteXList.Add(405);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 40)
            {
                noteXList.Add(165);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 45)
            {
                noteXList.Add(405);
                noteYList.Add(-64);
                noteNumber++;
            }

            //notes in the background tune
            if (tempCounter == 55)
            {
                noteXList.Add(245);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 65)
            {
                noteXList.Add(165);
                noteYList.Add(-64);
                noteNumber++;

                noteXList.Add(405);
                noteYList.Add(-64);
                noteNumber++;
            }

            if (tempCounter == 80)
            {
                noteXList.Add(325);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 90)
            {
                noteXList.Add(165);
                noteYList.Add(-64);
                noteNumber++;

                noteXList.Add(405);
                noteYList.Add(-64);
                noteNumber++;
            }

            if (tempCounter == 100)
            {
                noteXList.Add(245);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 110)
            {
                noteXList.Add(165);
                noteYList.Add(-64);
                noteNumber++;

                noteXList.Add(405);
                noteYList.Add(-64);
                noteNumber++;
            }

            if (tempCounter == 120)
            {
                noteXList.Add(325);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 130)
            {
                noteXList.Add(165);
                noteYList.Add(-64);
                noteNumber++;

                noteXList.Add(405);
                noteYList.Add(-64);
                noteNumber++;
            }

            //main melody
            if (tempCounter == 155)
            {
                noteXList.Add(405);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 163)
            {
                noteXList.Add(245);
                noteYList.Add(-64);
                noteNumber++;
            }

            if (tempCounter == 173)
            {
                noteXList.Add(165);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 178)
            {
                noteXList.Add(325);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 184)
            {
                noteXList.Add(405);
                noteYList.Add(-64);
                noteNumber++;
            }

            if (tempCounter == 198)
            {
                noteXList.Add(245);
                noteYList.Add(-64);
                noteNumber++;
            }


            if (tempCounter == 215)
            {
                noteXList.Add(245);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 220)
            {
                noteXList.Add(325);
                noteYList.Add(-64);
                noteNumber++;
            }

            if (tempCounter == 230)
            {
                noteXList.Add(325);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 235)
            {
                noteXList.Add(225);
                noteYList.Add(-64);
                noteNumber++;
            }
            if (tempCounter == 240)
            {
                noteXList.Add(165);
                noteYList.Add(-64);
                noteNumber++;
            }           

            //your free trial has ended :) have a nice day

            //displays the number of notes that have been created
            noteCounter.Text = noteNumber + " / 100";

            //move arrows (notes) down the screen
            for (int i = 0; i < noteYList.Count; i++)
            {
                {
                    noteYList[i] = noteYList[i] + noteSpeed;
                }             
            }
            
            if (missCount > 0)
            {
                msCount.ForeColor = Color.Yellow;
            }
            else if (missCount > 19)
            {
                msCount.ForeColor = Color.Orange;
            }
            else if (missCount > 44)
            {
                msCount.ForeColor = Color.Red;
            }

            if (missCount >= 50)
            {
            //game end
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
                        leftArrowDown = false;
                        break;
                    }
                }
                else if (leftArrowDown == true && !noteRec.IntersectsWith(boxRec1))
                {
                    missCount++;
                    //msCount.Text = missCount + "";
                    leftArrowDown = false;
                    break;
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
                        downArrowDown = false;
                        break;
                    }                                    
                }
                else if (downArrowDown == true && !noteRec.IntersectsWith(boxRec2))
                {
                   missCount++;
                   // msCount.Text = missCount + "";
                    downArrowDown = false;
                    break;
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
                        upArrowDown = false;
                        break;
                    }                                
                }
                else if (upArrowDown == true && !noteRec.IntersectsWith(boxRec3))
                {
                    missCount++;
                    // msCount.Text = missCount + "";
                    upArrowDown = false;
                    break;
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
                        rightArrowDown = false;
                        break;
                    }
                }
                else if (rightArrowDown == true && !noteRec.IntersectsWith(boxRec4))
                {
                    missCount++;
                    //msCount.Text = missCount + "";
                    rightArrowDown = false;
                    break;
                }
            }

            //calls the GameScreen_Paint method to draw the screen.
            Refresh();
        }
        Pen notePen = new Pen(Color.White);
        //Everything that is to be drawn on the screen should be done here
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < noteXList.Count; i++)
            {
                //float scale = noteSize / 130;
                float scale = 0.15f;

                e.Graphics.DrawLine(notePen, (55 * scale) + noteXList[i], (55 * scale) + noteYList[i], (405 * scale) + noteXList[i], (151 * scale) + noteYList[i]);
                e.Graphics.DrawLine(notePen, (405 * scale) + noteXList[i], (151 * scale) + noteYList[i], (295 * scale) + noteXList[i], (238 * scale) + noteYList[i]);
                e.Graphics.DrawLine(notePen, (295 * scale) + noteXList[i], (238 * scale) + noteYList[i], (425 * scale) + noteXList[i], (357 * scale) + noteYList[i]);
                e.Graphics.DrawLine(notePen, (425 * scale) + noteXList[i], (357 * scale) + noteYList[i], (354 * scale) + noteXList[i], (422 * scale) + noteYList[i]);
                e.Graphics.DrawLine(notePen, (354 * scale) + noteXList[i], (422 * scale) + noteYList[i],(210 * scale) + noteXList[i], (292 * scale) + noteYList[i]);
                e.Graphics.DrawLine(notePen, (210 * scale) + noteXList[i], (292 * scale) + noteYList[i],  (91 * scale) + noteXList[i], (427 * scale) + noteYList[i]);
                e.Graphics.DrawLine(notePen, (91 * scale) + noteXList[i], (427 * scale) + noteYList[i], (55 * scale) + noteXList[i], (55 * scale) + noteYList[i]);

               // e.Graphics.FillRectangle(noteBrush, noteXList[i], noteYList[i], noteSize, noteSize);
            }


            //Pen notePen = new Pen(Color.White);
            ////Notes(notePen, noteX, noteY, noteSize);
            //int x = noteX;
            //int y = noteY;
            //float scale = noteSize / 130;

            //e.Graphics.DrawLine(notePen, (55 * scale) + x, (55 * scale) + y, (405 * scale) + x, (151 * scale) + y);
            //e.Graphics.DrawLine(notePen, (405 * scale) + x, (151 * scale) + y, (295 * scale) + x, (238 * scale) + y);
            //e.Graphics.DrawLine(notePen, (295 * scale) + x, (238 * scale) + y, (425 * scale) + x, (357 * scale) + y);
            //e.Graphics.DrawLine(notePen, (425 * scale) + x, (357 * scale) + y, (354 * scale) + x, (422 * scale) + y);
            //e.Graphics.DrawLine(notePen, (354 * scale) + x, (422 * scale) + y, (210 * scale) + x, (292 * scale) + y);
            //e.Graphics.DrawLine(notePen, (210 * scale) + x, (292 * scale) + y, (91 * scale) + x, (427 * scale) + y);
            //e.Graphics.DrawLine(notePen, (91 * scale) + x, (427 * scale) + y, (55 * scale) + x, (55 * scale) + y);

            Pen collisionPen = new Pen(Color.Red);

            //to help visualize collision
            e.Graphics.DrawRectangle(collisionPen, 165, 310, 64, 64);
            e.Graphics.DrawRectangle(collisionPen, 245, 310, 64, 64);
            e.Graphics.DrawRectangle(collisionPen, 325, 310, 64, 64);
            e.Graphics.DrawRectangle(collisionPen, 405, 310, 64, 64);

            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            e.Graphics.DrawString("Left", drawFont, drawBrush, 172, 328);
            e.Graphics.DrawString("Down", drawFont, drawBrush, 244, 328);
            e.Graphics.DrawString("Up", drawFont, drawBrush, 337, 328);
            e.Graphics.DrawString("Right", drawFont, drawBrush, 406, 328);
        }
    }

}
