namespace Lesson_2_Controls
{
    public partial class Calculator : Form
    {
        double num1, num2;
        char emel = ' ';
        char ber = ' ';
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sifir_MouseHover(object sender, EventArgs e)
        {
            sifir.BackColor = Color.DarkTurquoise;
        }

        private void noqte_MouseHover(object sender, EventArgs e)
        {
            noqte.BackColor = Color.DarkTurquoise;
        }

        private void plus_MouseHover(object sender, EventArgs e)
        {
            plus.BackColor = Color.DarkTurquoise;
        }

        private void minus_MouseHover(object sender, EventArgs e)
        {
            minus.BackColor = Color.DarkTurquoise;
        }

        private void uc_MouseHover(object sender, EventArgs e)
        {
            uc.BackColor = Color.DarkTurquoise;
        }

        private void iki_MouseHover(object sender, EventArgs e)
        {
            iki.BackColor = Color.DarkTurquoise;
        }

        private void bir_MouseHover(object sender, EventArgs e)
        {
            bir.BackColor = Color.DarkTurquoise;
        }

        private void dord_MouseHover(object sender, EventArgs e)
        {
            dord.BackColor = Color.DarkTurquoise;
        }

        private void bes_MouseHover(object sender, EventArgs e)
        {
            bes.BackColor = Color.DarkTurquoise;
        }

        private void alti_MouseHover(object sender, EventArgs e)
        {
            alti.BackColor = Color.DarkTurquoise;
        }

        private void vur_MouseHover(object sender, EventArgs e)
        {
            vur.BackColor = Color.DarkTurquoise;
        }

        private void bol_MouseHover(object sender, EventArgs e)
        {
            bol.BackColor = Color.DarkTurquoise;
        }

        private void doqquz_MouseHover(object sender, EventArgs e)
        {
            doqquz.BackColor = Color.DarkTurquoise;
        }

        private void sekkiz_MouseHover(object sender, EventArgs e)
        {
            sekkiz.BackColor = Color.DarkTurquoise;
        }

        private void yeddi_MouseHover(object sender, EventArgs e)
        {
            yeddi.BackColor = Color.DarkTurquoise;
        }

        private void sifir_MouseLeave(object sender, EventArgs e)
        {
            sifir.BackColor = Color.White;
        }

        private void noqte_MouseLeave(object sender, EventArgs e)
        {
            noqte.BackColor = Color.White;
        }

        private void plus_MouseLeave(object sender, EventArgs e)
        {
            plus.BackColor = Color.White;
        }

        private void minus_MouseLeave(object sender, EventArgs e)
        {
            minus.BackColor = Color.White;
        }

        private void uc_MouseLeave(object sender, EventArgs e)
        {
            uc.BackColor = Color.White;
        }

        private void iki_MouseLeave(object sender, EventArgs e)
        {
            iki.BackColor = Color.White;
        }

        private void bir_MouseLeave(object sender, EventArgs e)
        {
            bir.BackColor = Color.White;
        }

        private void vur_MouseLeave(object sender, EventArgs e)
        {
            vur.BackColor = Color.White;
        }

        private void alti_MouseLeave(object sender, EventArgs e)
        {
            alti.BackColor = Color.White;
        }

        private void bes_MouseLeave(object sender, EventArgs e)
        {
            bes.BackColor = Color.White;
        }

        private void dord_MouseLeave(object sender, EventArgs e)
        {
            dord.BackColor = Color.White;
        }

        private void yeddi_MouseLeave(object sender, EventArgs e)
        {
            yeddi.BackColor = Color.White;
        }

        private void sekkiz_MouseLeave(object sender, EventArgs e)
        {
            sekkiz.BackColor = Color.White;
        }

        private void doqquz_MouseLeave(object sender, EventArgs e)
        {
            doqquz.BackColor = Color.White;
        }

        private void bol_MouseLeave(object sender, EventArgs e)
        {
            bol.BackColor = Color.White;
        }

        private void C_MouseHover(object sender, EventArgs e)
        {
            C.BackColor = Color.DarkTurquoise;
        }

        private void C_MouseLeave(object sender, EventArgs e)
        {
            C.BackColor = Color.MediumTurquoise;
        }

        private void beraber_MouseHover(object sender, EventArgs e)
        {
            beraber.BackColor = Color.DarkTurquoise;
        }

        private void beraber_MouseLeave(object sender, EventArgs e)
        {
            beraber.BackColor = Color.MediumTurquoise;
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            if ((!(textBox1.Text == "0")) || textBox1.Text.Contains(".0"))
            {
                textBox1.Text += '0';
            }


        }

        private void noqte_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('.'))
                textBox1.Text += ".";
        }

        private void bir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "1";
        }

        private void iki_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "2";
        }

        private void uc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "3";
        }

        private void dord_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "4";
        }

        private void bes_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "5";
        }

        private void alti_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "6";
        }

        private void yeddi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "7";
        }

        private void sekkiz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "8";
        }

        private void doqquz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (emel == ' ')
            {
                emel = '+';
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (emel == ' ')
            {
                emel = '-';
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            }
        }

        private void vur_Click(object sender, EventArgs e)
        {
            if (emel == ' ')
            {
                emel = '*';
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            }
        }

        private void bol_Click(object sender, EventArgs e)
        {
            if (emel == ' ')
            {
                emel = '/';
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            }
        }

        private void beraber_Click(object sender, EventArgs e)
        {
            if(ber == ' ')
            {
                num2 = Convert.ToDouble(textBox1.Text);

                if (emel == '+')
                {
                    ber = '=';
                    textBox1.Text = Convert.ToString(num1 + num2);
                }

                else if (emel == '-')
                {
                    ber = '=';
                    textBox1.Text = Convert.ToString(num1 - num2);
                }

                else if (emel == '*')
                {
                    ber = '=';
                    textBox1.Text = Convert.ToString(num1 * num2);
                }

                else if (emel == '/')
                {
                    ber = '=';
                    textBox1.Text = Convert.ToString(num1 / num2);
                }
            }
          
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            emel = ' ';
            ber = ' ';
        }
    }
}