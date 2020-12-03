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
        private double gravity = 10;
        private int constant = 5;
        private double mass = 1;
        private double force;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            force = mass*gravity;
            label1.Height += Convert.ToInt32(force);
        }
    }
}
