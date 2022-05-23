using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Kadir TUNA by creator The Task 1 ,
 * for Rezekne Technologies Academy ,
 */

namespace TheMemoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int[] buttonsOrgColor = new int[16];
        static int points;
        static int blackColorCounter;
        static int whiteButtonPressCounter;
        static int waitTime;
        static int delayTime;
        static int counterExpertMode;
        static int[] rndColor = new int[16];
        private void Form1_Load(object sender, EventArgs e)
        {
            passiveButtons();
            hardExpertMode();
        }
        private async void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            button18.Enabled = false;
            Button[] buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16 };
            foreach (Button button in buttons)
            {
                button.TabStop = false;
            }
            Random rnd = new Random();
            int rndBlackColorController = 1;
            int rndBlackColorCounter = 0;
                while (rndBlackColorController != 0)
            {
                for (int i = 0; i < 16; i++)
                { 
                    rndColor[i] = rnd.Next(0, 2);
                    if (rndColor[i] == 1)
                        rndBlackColorCounter++;
                    if (rndBlackColorCounter > 4 && rndBlackColorCounter < 13)
                    {
                        rndBlackColorController = 0;
                    }
                }
            }
            for (int i = 0; i < 16; i++)
            { 
                if (rndColor[i] == 0)
                    buttons[i].BackColor = Color.White;
                else
                    buttons[i].BackColor = Color.DimGray;        
            }
            for (int i = 0; i < 16; i++)
            {
                if (buttons[i].BackColor == Color.White)
                    buttonsOrgColor[i] = 0;
                else
                {
                    buttonsOrgColor[i] = 1;
                    blackColorCounter++;
                }
            }
            await Task.Delay(delayTime);
            convertButtonsColorOriginal();
            await Task.Delay(150);
            convertButtonsColorOriginalsReverse();
            await Task.Delay(150);
            foreach (Button button in buttons)
                button.Enabled = true;
            foreach (Button button in buttons)
                button.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (buttonsOrgColor[0] == 0)
            {
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button1.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (buttonsOrgColor[1] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button2.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (buttonsOrgColor[2] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button3.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (buttonsOrgColor[3] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button4.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (buttonsOrgColor[4] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button5.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (buttonsOrgColor[5] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button6.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            if (buttonsOrgColor[6] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button7.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (buttonsOrgColor[7] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button8.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            if (buttonsOrgColor[8] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button9.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            if (buttonsOrgColor[9] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button10.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            if (buttonsOrgColor[10] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button11.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            if (buttonsOrgColor[11] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button12.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            if (buttonsOrgColor[12] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button13.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            if (buttonsOrgColor[13] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button14.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            if (buttonsOrgColor[14] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button15.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            if (buttonsOrgColor[15] == 0)
            {
                points--;
                MessageBox.Show("You pushed the white button. You lost 1 point.\nYour point is : " + points.ToString());
                gameFailController();
            }
            else
            {
                button16.BackColor = Color.DimGray;
                points++;
                gameEndingController();
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            counterExpertMode++;
            if (counterExpertMode == 0)
                easyExpertMode();
            else if (counterExpertMode == 1)
                mediumExpertMode();
            else if (counterExpertMode == 2)
                hardExpertMode();
            else
            {
                extraHardExpertMode();
                counterExpertMode = -1;
            }
        }
        private async void gameEndingController()
        {
            blackColorCounter--;
            if (blackColorCounter == 0)
            {
                changeRegisteredBoxes();
                if (whiteButtonPressCounter == 0)
                {
                    points += 3;
                    MessageBox.Show("Your game successfully finished without fault!\nYour point is : " + points.ToString());
                }
                else
                {
                    MessageBox.Show("You finished the game with " + whiteButtonPressCounter + " fault!\nYour point is : " + points.ToString());
                }
                await Task.Delay(1000);
                convertButtonsColorOriginal();
                points = 0;
                whiteButtonPressCounter = 0;
                blackColorCounter = 0;
                button17.Enabled = true;
                button18.Enabled = true;
                passiveButtons();
            }
        }
        private async void gameFailController()
        {
            whiteButtonPressCounter++;
            if (whiteButtonPressCounter == 3)
            {
                changeRegisteredBoxes();
                MessageBox.Show("You lost total 3 points and game over!\nYour ending point is : " + points.ToString());
                await Task.Delay(1000);
                convertButtonsColorOriginal();
                points = 0;
                button17.Enabled = true;
                button18.Enabled = true;
                passiveButtons();
                whiteButtonPressCounter = 0;
                blackColorCounter = 0;
            }
        }
        private void convertButtonsColorOriginal()
        {
            button1.BackColor = Color.DimGray;
            button2.BackColor = Color.White;
            button3.BackColor = Color.DimGray;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.DimGray;
            button7.BackColor = Color.White;
            button8.BackColor = Color.DimGray;
            button9.BackColor = Color.DimGray;
            button10.BackColor = Color.White;
            button11.BackColor = Color.DimGray;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.DimGray;
            button15.BackColor = Color.White;
            button16.BackColor = Color.DimGray;
        }
        private void convertButtonsColorOriginalsReverse()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.DimGray;
            button3.BackColor = Color.White;
            button4.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button6.BackColor = Color.White;
            button7.BackColor = Color.DimGray;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.DimGray;
            button11.BackColor = Color.White;
            button12.BackColor = Color.DimGray;
            button13.BackColor = Color.DimGray;
            button14.BackColor = Color.White;
            button15.BackColor = Color.DimGray;
            button16.BackColor = Color.White;
        }
        private void passiveButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }
        private void easyExpertMode()
        {
            counterExpertMode = 0;
            label1.Text = "Easy Mode :\nWait 2 seconds for the white screen ";
            label1.BackColor = Color.Green;
            delayTime = 2000;
            //Console.WriteLine("Easy Mode is opened");
        }
        private void mediumExpertMode()
        {
            counterExpertMode = 1;
            label1.Text = "Medium Mode :\nWait 1 seconds for the white screen ";
            label1.BackColor = Color.Yellow;
            delayTime = 1000;
        }
        private void hardExpertMode()
        {
            counterExpertMode = 2;
            label1.Text = "Hard Mode :\nWait 0.3 seconds for the white screen ";
            label1.BackColor = Color.OrangeRed;
            delayTime = 300;
        }
        private void extraHardExpertMode()
        {
            counterExpertMode = 3;
            label1.Text = "Extra Hard Mode :\nWait 0.15 seconds for the white screen ";
            label1.BackColor = Color.Red;
            delayTime = 150;
        }
        private void changeRegisteredBoxes()
        {  
            if (rndColor[0] == 0)
            {
                button1.BackColor = Color.White;
            }
            else
                button1.BackColor = Color.DimGray;
            if (rndColor[1] == 0) { 
                button2.BackColor = Color.White;
            }
            else
                button2.BackColor = Color.DimGray;
            if (rndColor[2] == 0) { 
                button3.BackColor = Color.White;
                    }
            else
                button3.BackColor = Color.DimGray;
            if (rndColor[3] == 0) { 
                button4.BackColor = Color.White;
                }
            else
                button4.BackColor = Color.DimGray;
            if (rndColor[4] == 0) { 
                button5.BackColor = Color.White;
               }
            else
                button5.BackColor = Color.DimGray;
            if (rndColor[5] == 0) { 
                button6.BackColor = Color.White;
            }
            else
                button6.BackColor = Color.DimGray;
            if (rndColor[6] == 0) { 
                button7.BackColor = Color.White;
            }
            else
                button7.BackColor = Color.DimGray;
            if (rndColor[7] == 0) { 
                button8.BackColor = Color.White;
            }
            else
                button8.BackColor = Color.DimGray;
            if (rndColor[8] == 0) { 
                button9.BackColor = Color.White;
            }
            else
                button9.BackColor = Color.DimGray;
            if (rndColor[9] == 0)
            {
                button10.BackColor = Color.White;
            }
            else
                button10.BackColor = Color.DimGray;
            if (rndColor[10] == 0) { 
                button11.BackColor = Color.White;
            }
            else
                button11.BackColor = Color.DimGray;
            if (rndColor[11] == 0)
            {
                button12.BackColor = Color.White;
            }
            else
                button12.BackColor = Color.DimGray;
            if (rndColor[12] == 0) { 
                button13.BackColor = Color.White;
            }
            else
                button13.BackColor = Color.DimGray;
            if (rndColor[13] == 0) { 
                button14.BackColor = Color.White;
            }
            else
                button14.BackColor = Color.DimGray;
            if (rndColor[14] == 0) { 
                button15.BackColor = Color.White;
            }
            else
                button15.BackColor = Color.DimGray;
            if (rndColor[15] == 0) { 
                button16.BackColor = Color.White;
            }
            else
                button16.BackColor = Color.DimGray;
        }
    }
}

