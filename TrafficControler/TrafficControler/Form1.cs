using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficControler
{
    public partial class Form1 : Form
    {
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        int green;
        int yellow;

        int t1;
        int t2;
        int t3;
        int t4;
        int ans;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtTime4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            counter1++;
            if (counter1 < green)
            {
                btnG1.BackColor = Color.Lime;
                btnR2.BackColor = Color.Red;
                btnR3.BackColor = Color.Red;
                btnR4.BackColor = Color.Red;
                
            }
            else if (counter1 < (green + yellow))
            {
                btnY1.BackColor = Color.Yellow;
                btnG1.BackColor = Color.FromArgb(224, 224, 224);
                btnR2.BackColor = Color.Red;
                btnR3.BackColor = Color.Red;
                btnR4.BackColor = Color.Red;
            }
            else if (counter1 == (green + yellow))
            {
                btnR1.BackColor = Color.Red;
                btnY1.BackColor = Color.FromArgb(224, 224, 224);
                btnR2.BackColor = Color.Red;
                btnR3.BackColor = Color.Red;
                btnR4.BackColor = Color.Red;
            }

            else if (counter1 > (green + yellow))
            {
                counter2++;
                if (counter2 < green)
                {
                    btnG2.BackColor = Color.Lime;
                    btnR2.BackColor = Color.FromArgb(224, 224, 224); 
                    btnR1.BackColor = Color.Red;
                    btnR3.BackColor = Color.Red;
                    btnR4.BackColor = Color.Red;
                 
                }
                else if (counter2 < (green + yellow))
                {
                    btnY2.BackColor = Color.Yellow;
                    btnG2.BackColor = Color.FromArgb(224, 224, 224);

                    btnR1.BackColor = Color.Red;
                    btnR3.BackColor = Color.Red;
                    btnR4.BackColor = Color.Red;

                }
                else if (counter2 == (green + yellow))
                {
                    btnR2.BackColor = Color.Red;
                    btnY2.BackColor = Color.FromArgb(224, 224, 224);

                    btnR1.BackColor = Color.Red;
                    btnR2.BackColor = Color.Red;
                    btnR4.BackColor = Color.Red;

                }

                else if (counter2 > (green + yellow))
                {
                    counter3++;
                    if (counter3 < green)
                    {
                        btnG3.BackColor = Color.Lime;
                        btnR3.BackColor = Color.FromArgb(224, 224, 224);

                        btnR1.BackColor = Color.Red;
                        btnR2.BackColor = Color.Red;
                        btnR4.BackColor = Color.Red;
                    }
                    else if (counter3 < (green + yellow))
                    {
                        btnY3.BackColor = Color.Yellow;
                        btnG3.BackColor = Color.FromArgb(224, 224, 224);

                        btnR1.BackColor = Color.Red;
                        btnR2.BackColor = Color.Red;
                        btnR4.BackColor = Color.Red;

                    }
                    else if (counter3 == (green + yellow))
                    {
                        btnR3.BackColor = Color.Red;
                        btnY3.BackColor = Color.FromArgb(224, 224, 224);
                        btnR1.BackColor = Color.Red;
                        btnR2.BackColor = Color.Red;
                        btnR4.BackColor = Color.Red;
                    }
                    else if (counter3 > (green + yellow))
                    {
                        counter4++;
                        if (counter4 < green)
                        {
                            btnG4.BackColor = Color.Lime;
                            btnR4.BackColor = Color.FromArgb(224, 224, 224);

                            btnR1.BackColor = Color.Red;
                            btnR2.BackColor = Color.Red;
                            btnR3.BackColor = Color.Red;
                        }
                        else if (counter4 < (green + yellow))
                        {
                            btnY4.BackColor = Color.Yellow;
                            btnG4.BackColor = Color.FromArgb(224, 224, 224);

                            btnR1.BackColor = Color.Red;
                            btnR2.BackColor = Color.Red;
                            btnR3.BackColor = Color.Red;

                        }
                        else if (counter4 == (green + yellow))
                        {
                            btnR4.BackColor = Color.Red;
                            btnY4.BackColor = Color.FromArgb(224, 224, 224);
                            btnR2.BackColor = Color.Red;
                            btnR4.BackColor = Color.Red;
                            btnR1.BackColor = Color.FromArgb(224, 224, 224);
                            btnG1.BackColor = Color.Lime;
                        }
                         else
                        {
                            counter1 = 1;
                            counter2 = 0;
                            counter3 = 0;
                            counter4 = 0;
                        }
                    }

                }
            }
        }




        private void txtTimeGreen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimeYellow_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        private void txtTime1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            green = Convert.ToInt32(txtTimeGreen.Text);
            yellow = Convert.ToInt32(txtTimeYellow.Text);
            ans = green + yellow;
            t1 = ans * 4;
            t2 = ans * 4;
            t3 = ans * 4;
            t4 = ans * 4;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t1--;
            if (t1 ==0)
            {
                t1 = ans*4;
            }
            txtTime1.Text = t1.ToString();
        }
        private void timer5_Tick_1(object sender, EventArgs e)
        {
            t2--;
            if (t2 == 0)
            {
                t2 = ans * 4;
            }
            txtTime2.Text = t2.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            t3--;
            if (t3 == 0)
            {
                t3 = ans * 4;
            }
            txtTime3.Text = t3.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            t4--;
            if (t4 == 0)
            {
                t4 = ans * 4;
            }

            txtTime4.Text = t4.ToString();
        }


        private void txtTime2_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTime3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
