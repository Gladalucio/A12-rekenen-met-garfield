using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LT
{
    public partial class Form2 : Form
    {
        public static int iGoed;
        public static int iFout;
        int iAnswer;
        int iRandom;
        int iOud = 11;
        int iRonde = 1;

        PictureBox[] marbles = new PictureBox[10];


        public Form2()
        {
            InitializeComponent();
        }

        // NAAM
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNaam.Text = Form1.SetName;

            marbles[0] = Marble1;
            marbles[1] = Marble2;
            marbles[2] = Marble3;
            marbles[3] = Marble4;
            marbles[4] = Marble5;
            marbles[5] = Marble6;
            marbles[6] = Marble7;
            marbles[7] = Marble8;
            marbles[8] = Marble9;
            marbles[9] = Marble10;

            Random();
        }
        // BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            iAnswer = 1;
            Answer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iAnswer = 2;
            Answer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iAnswer = 3;
            Answer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            iAnswer = 4;
            Answer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            iAnswer = 5;
            Answer();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            iAnswer = 6;
            Answer();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            iAnswer = 7;
            Answer();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            iAnswer = 8;
            Answer();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            iAnswer = 9;
            Answer();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            iAnswer = 10;
            Answer();
        }
       
        // END BUTTONS


        // BEREKENING

        private void Random()
        {
            if (iRonde < 11)
            {
                // Verbergt alle knikkers
                for (int reset = 1; reset < 10; reset++)
                {
                    marbles[reset].Hide();
                }

                // Genereert een random getal
                Random rng = new System.Random();
                iRandom = rng.Next(1, 10);

                if (iOud == iRandom)
                {
                    Random();
                }
                else
                {
                    for (int iRandom2 = iRandom; iRandom2 >= 1; iRandom2--)
                    {
                        marbles[iRandom2-1].Show();
                        // de "-1" staat er in, anders wordt de eerste Garfield-foto genegeerd en start alles vanaf de 2e
                    }
                    lblRonde.Text = iRonde.ToString();
                    iRonde++;

                    iOud = iRandom;
                    // Dit is zodat je niet meerdere keren dezelfde krijgt
                }

            }
            else
            {
                if (iFout < 4)
                {
                    textBoxReactie.Visible = true;
                    textBoxHappy.Visible = true;
                    picHappy.Visible = true;
                }
                else
                {
                    textBoxReactie.Visible = true;
                    textBoxHappy.Visible = true;
                    picSad.Visible = true;
                    btnReactie.Text = "Jammer...";
                }
                btnReactie.Visible = true;
                lblHint.Visible = true;

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
                // Dit is zodat de gebruiker niet per ongeluk door blijft drukken
            }

            

            //for (int iRandom = rng.Next (0, 9); iRandom >= 0; iRandom--)

            // MessageBox.Show(iRandom.ToString());
        }

        private void Answer()
        {
            if (iRandom == iAnswer)
            {
                iGoed = int.Parse(lblGoed.Text);
                iGoed++;
                lblGoed.Text = iGoed.ToString();
            }
            else
            {
                iFout = int.Parse(lblFout.Text);
                iFout++;
                lblFout.Text = iFout.ToString();
            }
            Random();
        }
        private void btnReactie_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Close();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
