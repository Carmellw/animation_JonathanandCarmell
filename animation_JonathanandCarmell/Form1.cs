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
        private double gravity = 0.0009; //גרביטציה
        private double time = 1;//ספירת הזמן שעבר
        private double velocityY = 0;//המהירות של הגוף בציר וואי
        private double velocityX = 7;//המהירות של הגוף בציר איקס
        private Label[] clouds = new Label[8];// מערך של כל העננים


        public Form1()
        {
            InitializeComponent();
            Setarr();
        }
        //פעולה המכניסה את העננים לתוך המערך
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

        //הטיימר של הכדור
        private void timer1_Tick(object sender, EventArgs e)
        {
                velocityY = velocityY + gravity * time;//חישוב המהירות
                if (Ball.Top + velocityY * time <= 285)// אם הכדור לא הגיע לרצפה 
                {
                    Ball.Top += Convert.ToInt32(velocityY * time);

                }
            else //אם הכדור הגיע לרצפה
                {
                    velocityY = -0.75 * velocityY;//תהפוך את המהירות ותוריד קצת בגלל חיכוך
                    velocityX = 0.95 * velocityX;//תוריד את המהירות בגלל חיכוך
                }
            Ball.Left += Convert.ToInt32(velocityX);
            time++;//ספירה של הזמן

        }

        
        //הטיימר של העננים
        private void timer2_Tick(object sender, EventArgs e)
        {
            //לולאת פור שמזיזה את העננים
            for (int i = 0; i < clouds.Length; i++)
            {
                if (clouds[i].Left < 600)//אם העננים לא יצאו מהפריים תזיז אותם
                {
                    clouds[i].Left += 1;
                }
                else// אם הם כן יצאו מהפריים תחזיר אותם להתחלה
                {
                    clouds[i].Left = -100;
                }
            }
        }
    }
}
