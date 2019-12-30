using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCS
{
    public partial class form1 : Form
    {

        int aqreng = 1;
        public form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            string eded = button1.Text.ToString();

            txtBsecond.Text = eded;
           
                txtB3.Text += txtBsecond.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string eded = button2.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string eded = button3.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string eded = button4.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string eded = button5.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string eded = button6.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string eded = button7.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string eded = button8.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string eded = button9.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtB3.Text = "";
            txtBmain.Text = "";
            txtBsecond.Text= "";
            txtError.Text = "";
            txtError.BackColor = Color.White;
            txtError.Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //int a = txtB3.Text.Length;
            //string b = txtB3.Text.ToString();
            //int c = int.Parse(((b[a - 1]).ToString()));

            //txtB3.Text = (int.Parse(b) - c).ToString();

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           
            txtOp.Text = btnPlus.Text.ToString();
            txtBmain.Text = txtB3.Text;
            txtB3.Text = string.Empty;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtOp.Text = btnMinus.Text.ToString();
            txtBmain.Text = txtB3.Text;
            txtB3.Text = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtOp.Text = btnDivide.Text.ToString();
            txtBmain.Text = txtB3.Text;
            txtB3.Text = string.Empty;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBmain.Text == "" || txtB3.Text == "")
                {
                    txtError.Visible = true;
                    txtError.Text = "Temizle reqem daxil et!!";
                    txtError.BackColor = Color.Yellow;
                    txtError.ForeColor = Color.Black;
                    

                }

                if (txtBmain.Text != "")
                {

                    double a = double.Parse(txtBmain.Text.ToString());
                    double b = double.Parse(txtB3.Text.ToString());
                    string qwer = txtOp.Text.ToString();

                    if (txtBmain.Text == null)
                    {
                        txtBmain.Text = "qaqa neyi hesablayim?";
                    }

                    if (qwer == "+")
                    {
                        double z = a + b;

                        txtBmain.Text = z.ToString();
                        txtBsecond.Text = txtOp.Text = txtB3.Text = "";
                    }
                    if (qwer == "-")
                    {
                        double z = a - b;

                        txtBmain.Text = z.ToString();
                        txtBsecond.Text = txtOp.Text = txtB3.Text = "";
                    }
                    if (qwer == "/")
                    {
                        double z = a / b;

                        txtBmain.Text = z.ToString();
                        txtBsecond.Text = txtOp.Text = txtB3.Text = "";
                    }
                    if (qwer == "*")
                    {
                        double z = a * b;

                        txtBmain.Text = z.ToString();
                        txtBsecond.Text = txtOp.Text = txtB3.Text = "";
                    }

                }


            }
            catch (Exception)
            {

                txtError.Text = "her seyi temizle";
                txtError.ForeColor = Color.Black;
                txtError.Visible = true;

            }

           
            
            
            

        }

        private void button0_Click(object sender, EventArgs e)
        {
            string eded = button0.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            string eded = btnDot.Text.ToString();
            txtBsecond.Text = eded;
            txtB3.Text += txtBsecond.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtOp.Text = btnMultiple.Text.ToString();
            txtBmain.Text = txtB3.Text;
            txtB3.Text = string.Empty;
            aqreng++;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            SystemSounds.Beep.Play();
            if (aqreng == 1)
            {
                txtBmain.BackColor = Color.AliceBlue;

            }
            if (aqreng == 2)
            {
                txtBmain.BackColor = Color.AntiqueWhite;
            }

            if (aqreng == 3)
            {
                txtBmain.BackColor = Color.Red;
            }
            aqreng++;
              
                
            
        }
    }
}
