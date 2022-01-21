using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app5
{

    public partial class Form1 : Form
    {
        //public int[] vara = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        public int varb = 0;
        public Form1()
        {
            InitializeComponent();

            if (buttonMain.Text == "Play again")
            {
                buttonMain.Text = "Start ▷";
            }
        }
        public void DisableButton()
        {
            b11.Text = " ";
            b11.Visible = false;
            b12.Text = " ";
            b12.Visible = false;
            b13.Text = " ";
            b13.Visible = false;
            b21.Text = " ";
            b21.Visible = false;
            b22.Text = " ";
            b22.Visible = false;
            b23.Text = " ";
            b23.Visible = false;
            b31.Text = " ";
            b31.Visible = false;
            b32.Text = " ";
            b32.Visible = false;
            b33.Text = " ";
            b33.Visible = false;
            pictureBox1.Visible = false;
        }
        public void EnableButton()
        {
            b11.Text = " ";
            b11.Visible = true;
            b11.Enabled = true;



            b12.Text = " ";
            b12.Visible = true;
            b12.Enabled = true;
            b13.Text = " ";
            b13.Visible = true;
            b13.Enabled = true;
            b21.Text = " ";
            b21.Visible = true;
            b21.Enabled = true;
            b22.Text = " ";
            b22.Visible = true;
            b22.Enabled = true;
            b23.Text = " ";
            b23.Visible = true;
            b23.Enabled = true;
            b31.Text = " ";
            b31.Visible = true;
            b31.Enabled = true;
            b32.Text = " ";
            b32.Visible = true;
            b32.Enabled = true;
            b33.Text = " ";
            b33.Visible = true;
            b33.Enabled = true;
            pictureBox1.Visible = true;

        }
        public void WinO()
        {
            MessageBox.Show("Winner:o\nLoser:x");
            DisableButton();
            varb--;
            buttonMain.Text = "Start ▷";
        }
        public void WinX()
        {
            MessageBox.Show("Winner:x\nLoser:o");
            DisableButton();
            varb--;
            buttonMain.Text = "Start ▷";
        }
        public void Draw()
        {
            if (varb == 9)
            {
                MessageBox.Show("Draw");
                DisableButton();
                buttonMain.Text = "Start ▷";
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void labelOpt_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            EnableButton();
            lturn.Visible = true;
            labelOpt.Visible = true;
            pictureBox1.Visible = true;
            if (buttonMain.Text == "Start ▷")
            {
                buttonMain.Text = "Play again 🗘";
            }
            varb = 0;


        }

        private void b11_Click(object sender, EventArgs e)
        {
            b11.Text = labelOpt.Text;
            if (b11.Text == "x")
            {

                if (b12.Text == "x" && b13.Text == "x")
                {
                    WinX();
                }
                else if (b22.Text == "x" && b33.Text == "x")
                {
                    WinX();
                }
                else if (b21.Text == "x" && b31.Text == "x")
                {
                    WinX();
                }
                labelOpt.Text = "o";
                //vara[1] = 1;
            }
            else
            {

                if (b12.Text == "o" && b13.Text == "o")
                {
                    WinO();
                }
                else if (b22.Text == "o" && b33.Text == "o")
                {
                    WinO();
                }
                else if (b21.Text == "o" && b31.Text == "o")
                {
                    WinO();
                }
                labelOpt.Text = "x";
                //vara[1] = 0;
            }
            varb++;
            b11.Enabled = false;
            Draw();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            b12.Text = labelOpt.Text;
            if (b12.Text == "x")
            {

                if (b11.Text == "x" && b13.Text == "x")
                {
                    WinX();
                }
                else if (b22.Text == "x" && b32.Text == "x")
                {
                    WinX();
                }
                labelOpt.Text = "o";
                //vara[2] = 1;

            }
            else
            {
                if (b11.Text == "o" && b13.Text == "o")
                {
                    WinO();
                }
                else if (b22.Text == "o" && b32.Text == "o")
                {
                    WinO();
                }
                labelOpt.Text = "x";
                //vara[2] = 0;
            }
            varb++;
            b12.Enabled = false;
            Draw();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            b13.Text = labelOpt.Text;
            if (b13.Text == "x")
            {
                if (b12.Text == "x" && b11.Text == "x")
                {
                    WinX();
                }
                else if (b22.Text == "x" && b31.Text == "x")
                {
                    WinX();
                }
                else if (b23.Text == "x" && b33.Text == "x")
                {
                    WinX();
                }
                labelOpt.Text = "o";
                //vara[3] = 1;
            }
            else
            {
                if (b12.Text == "o" && b11.Text == "o")
                {
                    WinO();
                }
                else if (b22.Text == "o" && b31.Text == "o")
                {
                    WinO();
                }
                else if (b23.Text == "o" && b33.Text == "o")
                {
                    WinO();
                }
                labelOpt.Text = "x";
                //vara[3] = 0;
            }
            varb++;
            b13.Enabled = false;
            Draw();
        }

        private void b21_Click(object sender, EventArgs e)
        {
            b21.Text = labelOpt.Text;
            if (b21.Text == "x")
            {
                if (b11.Text == "x" && b31.Text == "x")
                {
                    WinX();
                }
                else if (b22.Text == "x" && b23.Text == "x")
                {
                    WinX();
                }
                labelOpt.Text = "o";
                //vara[4] = 1;
            }
            else
            {
                if (b11.Text == "o" && b31.Text == "o")
                {
                    WinO();
                }
                else if (b22.Text == "o" && b23.Text == "o")
                {
                    WinO();
                }
                labelOpt.Text = "x";
                //vara[4] = 0;
            }
            varb++;
            b21.Enabled = false;
            Draw();
        }

        private void b22_Click(object sender, EventArgs e)
        {
            b22.Text = labelOpt.Text;
            if (b22.Text == "x")
            {
                if (b11.Text == "x" && b33.Text == "x")
                {
                    WinX();
                }
                else if (b12.Text == "x" && b32.Text == "x")
                {
                    WinX();
                }
                else if (b13.Text == "x" && b31.Text == "x")
                {
                    WinX();
                }
                else if (b21.Text == "x" && b23.Text == "x")
                {
                    WinX();
                }
                labelOpt.Text = "o";
                //vara[5] = 1;
            }
            else
            {
                if (b11.Text == "o" && b33.Text == "o")
                {
                    WinO();
                }
                else if (b12.Text == "o" && b32.Text == "o")
                {
                    WinO();
                }
                else if (b13.Text == "o" && b31.Text == "o")
                {
                    WinO();
                }
                else if (b21.Text == "o" && b23.Text == "o")
                {
                    WinO();
                }

                labelOpt.Text = "x";
                //vara[5] = 0;
            }
            varb++;
            b22.Enabled = false;
            Draw();
        }

        private void b23_Click(object sender, EventArgs e)
        {
            b23.Text = labelOpt.Text;
            if (b23.Text == "x")
            {
                if (b13.Text == "x" && b33.Text == "x")
                {
                    WinX();
                }
                else if (b22.Text == "x" && b21.Text == "x")
                {
                    WinX();
                }
                labelOpt.Text = "o";
                //vara[6] = 1;
            }
            else
            {
                if (b13.Text == "o" && b33.Text == "o")
                {
                    WinO();
                }
                else if (b22.Text == "o" && b21.Text == "o")
                {
                    WinO();
                }
                labelOpt.Text = "x";
                //vara[6] = 0;
            }
            varb++;
            b23.Enabled = false;
            Draw();
        }

        private void b31_Click(object sender, EventArgs e)
        {
            b31.Text = labelOpt.Text;
            if (b31.Text == "x")
            {

                if (b32.Text == "x" && b33.Text == "x")
                {
                    WinX();
                }
                else if (b22.Text == "x" && b13.Text == "x")
                {
                    WinX();
                }
                else if (b21.Text == "x" && b11.Text == "x")
                {
                    WinX();
                }
                labelOpt.Text = "o";
                //vara[7] = 1;
            }
            else
            {
                if (b32.Text == "o" && b33.Text == "o")
                {
                    WinO();
                }
                else if (b22.Text == "o" && b13.Text == "o")
                {
                    WinO();
                }
                else if (b11.Text == "o" && b21.Text == "o")
                {
                    WinO();
                }
                labelOpt.Text = "x";
                //vara[7] = 0;
            }
            varb++;
            b31.Enabled = false;
            Draw();
        }

        private void b32_Click(object sender, EventArgs e)
        {
            b32.Text = labelOpt.Text;

            if (b32.Text == "x")
            {

                if (b31.Text == "x" && b33.Text == "x")
                {
                    WinX();
                }
                else if (b22.Text == "x" && b12.Text == "x")
                {
                    WinX();
                }
                labelOpt.Text = "o";
                //vara[8] = 1;
            }
            else
            {
                if (b31.Text == "o" && b33.Text == "o")
                {
                    WinO();
                }
                else if (b22.Text == "o" && b12.Text == "o")
                {
                    WinO();
                }
                labelOpt.Text = "x";
                //vara[8] = 0;
            }
            varb++;
            b32.Enabled = false;
            Draw();
        }

        private void b33_Click(object sender, EventArgs e)
        {

            b33.Text = labelOpt.Text;
            if (b33.Text == "x")
            {
                if (b32.Text == "x" && b31.Text == "x")
                {
                    WinX();
                }
                else if (b22.Text == "x" && b11.Text == "x")
                {
                    WinX();
                }
                else if (b23.Text == "x" && b13.Text == "x")
                {
                    WinX();
                }
                labelOpt.Text = "o";
                //vara[9] = 1;
            }
            else
            {
                if (b32.Text == "o" && b31.Text == "o")
                {
                    WinO();
                }
                else if (b22.Text == "o" && b11.Text == "o")
                {
                    WinO();
                }
                else if (b23.Text == "o" && b13.Text == "o")
                {
                    WinO();
                }
                labelOpt.Text = "x";
                //vara[9] = 0;
            }
            varb++;
            b33.Enabled = false;
            Draw();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
