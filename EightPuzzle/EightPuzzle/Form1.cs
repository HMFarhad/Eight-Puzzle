using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EightPuzzle
{
    public partial class Form1 : Form
    {

        int time = 0;
        bool on = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!on)
            {
                play();
            }
            
            if (!timer1.Enabled)
            { 
                timer1.Start();
                button14.Text = "Pause";
            }
            else
            {
                timer1.Stop();
                button14.Text = "Resume";
                on = false;
            }

        }

        public void genRandom()
        {
            Random R = new Random();
           
            var randomNumbers = Enumerable.Range(0, 9).OrderBy(x => R.Next()).Take(9).ToList();

            button1.Text = Convert.ToString(randomNumbers[0]);
            button2.Text = Convert.ToString(randomNumbers[1]);
            button3.Text = Convert.ToString(randomNumbers[2]);
            button4.Text = Convert.ToString(randomNumbers[3]);
            button5.Text = Convert.ToString(randomNumbers[4]);
            button6.Text = Convert.ToString(randomNumbers[5]);
            button7.Text = Convert.ToString(randomNumbers[6]);
            button8.Text = Convert.ToString(randomNumbers[7]);
            button9.Text = Convert.ToString(randomNumbers[8]);
        }


        public void play()
        {
            genRandom();
            buttonColor();
            on = true;
            label1.Text = "Click Up/Down/Left/Right to Move the Block accordingly";
        }



        //Reset Button
        private void button16_Click(object sender, EventArgs e)
        {   
            genRandom();
            buttonColor();
            timer1.Stop();
            time = 0;
            on = false;
            button14.Text = "Play";
            label3.Text = "0 Seconds";
            label1.Text = " Reseted !";
            

        }


        public void buttonColor()
        {

            button10.ForeColor = Color.Green;
            button11.ForeColor = Color.Green;
            button12.ForeColor = Color.Green;
            button13.ForeColor = Color.Green;
            button17.ForeColor = Color.Blue;
            button18.ForeColor = Color.Blue;
            button19.ForeColor = Color.Blue;
            button20.ForeColor = Color.Blue;
            button21.ForeColor = Color.Blue;
            button22.ForeColor = Color.Blue;
            button23.ForeColor = Color.Blue;
            button24.ForeColor = Color.Blue;
            button25.ForeColor = Color.Green;

            if (button1.Text == Convert.ToString(0))
            {
                buttonColorBlue();
                button1.BackColor = Color.Green;
            }
            else if (button2.Text == Convert.ToString(0))
            {
                buttonColorBlue();
                button2.BackColor = Color.Green;
            }
            else if (button3.Text == Convert.ToString(0))
            {
                buttonColorBlue();
                button3.BackColor = Color.Green;
            }
            else if (button4.Text == Convert.ToString(0))
            {
                buttonColorBlue();
                button4.BackColor = Color.Green;
            }
            else if (button5.Text == Convert.ToString(0))
            {
                buttonColorBlue();
                button5.BackColor = Color.Green;
            }
            else if (button6.Text == Convert.ToString(0))
            {
                buttonColorBlue();
                button6.BackColor = Color.Green;
            }
            else if (button7.Text == Convert.ToString(0))
            {
                buttonColorBlue();
                button7.BackColor = Color.Green;
            }
            else if (button8.Text == Convert.ToString(0))
            {
                buttonColorBlue();
                button8.BackColor = Color.Green;
            }
            else if (button9.Text == Convert.ToString(0))
            {
                buttonColorBlue();
                button9.BackColor = Color.Green;
            }
        }

        public void buttonColorBlue()
        {
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Blue;
            button5.BackColor = Color.Blue;
            button6.BackColor = Color.Blue;
            button7.BackColor = Color.Blue;
            button8.BackColor = Color.Blue;
            button9.BackColor = Color.Blue;
        }

        //Button UP
        private void button11_Click(object sender, EventArgs e)
        {
            if (on)
            {
                moveUp();
            }
            else label1.Text = "Clicked Play Button to Start the Game!!!";
        }


        //Button Left
        private void button10_Click(object sender, EventArgs e)
        {
            if (on)
            {
                moveLeft();
            }
            else label1.Text = "Clicked Play Button to Start the Game!!!";
        }


        //Button Right
        private void button12_Click(object sender, EventArgs e)
        {
            if (on)
            {
                moveRight();
            }
            else label1.Text = "Clicked Play Button to Start the Game!!!";
        }

        //Button Down
        private void button13_Click(object sender, EventArgs e)
        {
            if (on)
            {
                moveDown();
            }
            else label1.Text = "Clicked Play Button to Start the Game!!!"; 
        }

        //Swap 
        public void swap(Button temp1, Button temp2)
        {
            string temp;
            temp = temp1.Text;
            temp1.Text = temp2.Text;
            temp2.Text = temp;
            buttonColor();
            label1.Text = "Moved!";
            checkResult();
        }


        //Solve Button ;)
        private void button15_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "0";
            buttonColor();
            checkResult();
        }

        //Check Result
        public void checkResult()
        {
            if (button1.Text == "1" &&
            button2.Text == "2" &&
            button3.Text == "3" &&
            button4.Text == "4" &&
            button5.Text == "5" &&
            button6.Text == "6" &&
            button7.Text == "7" &&
            button8.Text == "8" &&
            button9.Text == "0")
            {
                label1.Text = "Solved! Congratulation!!";
                timer1.Stop();
            }
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label3.Text = time.ToString() + " Seconds";
        }

        //Move Up
        public void moveUp()
        {
            if (button1.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button2.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button3.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button4.Text == Convert.ToString(0))
            {
                swap(button4, button1);
            }
            else if (button5.Text == Convert.ToString(0))
            {
                swap(button5, button2);
            }
            else if (button6.Text == Convert.ToString(0))
            {
                swap(button6, button3);
            }
            else if (button7.Text == Convert.ToString(0))
            {
                swap(button7, button4);
            }
            else if (button8.Text == Convert.ToString(0))
            {
                swap(button8, button5);
            }
            else if (button9.Text == Convert.ToString(0))
            {
                swap(button9, button6);
            }
            else label1.Text = "Inside Up!!";
        }


        //Move Left
        public void moveLeft()
        {
            if (button1.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button2.Text == Convert.ToString(0))
            {
                swap(button2, button1);
            }
            else if (button3.Text == Convert.ToString(0))
            {
                swap(button3, button2);
            }
            else if (button4.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button5.Text == Convert.ToString(0))
            {
                swap(button5, button4);
            }
            else if (button6.Text == Convert.ToString(0))
            {
                swap(button6, button5);
            }
            else if (button7.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button8.Text == Convert.ToString(0))
            {
                swap(button8, button7);
            }
            else if (button9.Text == Convert.ToString(0))
            {
                swap(button9, button8);
            }
            else label1.Text = "Inside Left!!";
        }


        //Move Right
        public void moveRight()
        {
            if (button1.Text == Convert.ToString(0))
            {
                swap(button1, button2);
            }
            else if (button2.Text == Convert.ToString(0))
            {
                swap(button2, button3);
            }
            else if (button3.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button4.Text == Convert.ToString(0))
            {
                swap(button4, button5);
            }
            else if (button5.Text == Convert.ToString(0))
            {
                swap(button5, button6);
            }
            else if (button6.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button7.Text == Convert.ToString(0))
            {
                swap(button7, button8);
            }
            else if (button8.Text == Convert.ToString(0))
            {
                swap(button8, button9);
            }
            else if (button9.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else label1.Text = "Inside Right!!";
        }

        //Move Down
        public void moveDown()
        {
            if (button1.Text == Convert.ToString(0))
            {
                swap(button1, button4);
            }
            else if (button2.Text == Convert.ToString(0))
            {
                swap(button2, button5);
            }
            else if (button3.Text == Convert.ToString(0))
            {
                swap(button3, button6);
            }
            else if (button4.Text == Convert.ToString(0))
            {
                swap(button4, button7);
            }
            else if (button5.Text == Convert.ToString(0))
            {
                swap(button5, button8);
            }
            else if (button6.Text == Convert.ToString(0))
            {
                swap(button6, button9);
            }
            else if (button7.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button8.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else if (button9.Text == Convert.ToString(0))
            {
                label1.Text = "Wrong Move !!";
            }
            else label1.Text = "Inside Down!!";
        }


    }
}
