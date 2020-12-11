using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animation_JonathanandCarmell
{

    public partial class Form1 : Form
    {
        private double gravity = 0.0001;
        private double mass = 10;
        private double forceY;
        private double forceX = 3;
        private double time = 1;
        private double vY = 0;
        private double vX = 1;
        private Label[] clouds = new Label[8];


        public Form1()
        {
            InitializeComponent();
            Setarr();
        }

        public void Setarr()
        {
            clouds[0] = label1;
            clouds[1] = label2;
            clouds[2] = label3;
            clouds[3] = label4;
            clouds[4] = label5;
            clouds[5] = label6;
            clouds[6] = label7;
            clouds[7] = label8;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                vY = vY + gravity * time;
                if (Ball.Top + vY * time <= 285)
                {
                    Ball.Top += Convert.ToInt32(vY * time);
                    time++;
                }
                else
                {
                    vY = -0.75 * vY;
                    forceX = 0.95 * forceX;
                }

                vX = forceX;
                Ball.Left += Convert.ToInt32(vX);
            

             


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < clouds.Length; i++)
            {
                if (clouds[i].Left < 600)
                {
                    clouds[i].Left += 1;
                }
                else
                {
                    clouds[i].Left = -100;
                }
            }
        }
    }
}
