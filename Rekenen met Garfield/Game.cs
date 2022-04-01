using System;
using System.Windows.Forms;

namespace LT
{
    public partial class Game : Form
    {
        public static int iGoed;
        public static int iFout;
        int iRandom;
        int iOud = 11;
        int iRonde = 1;

        PictureBox[] marbles = new PictureBox[10];

        public Game()
        {
            InitializeComponent();
        }

        // NAAM
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNaam.Text = LT.Menu.SetName;

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

        private void answer_Click(object sender, EventArgs e)
        {
            Answer(int.Parse((sender as Button).Text));
        }

        private void Random()
        {
            if (iRonde <= 10)
            {
                // Hides all marbles
                for (var reset = 1; reset < 10; reset++)
                {
                    marbles[reset].Hide();
                }

                // Generates a random number
                var rng = new System.Random();
                iRandom = rng.Next(1, 10);

                if (iOud == iRandom)
                {
                    Random();
                }
                else
                {
                    for (var iRandom2 = iRandom; iRandom2 >= 1; iRandom2--)
                    {
                        marbles[iRandom2 - 1].Show();
                        // "-1" is there so that the first Garfield-image is ignored and they all start from the second
                    }
                    lblRonde.Text = iRonde.ToString();
                    iRonde++;

                    iOud = iRandom;
                    // Prevents the same number from showing twice
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
                // Prevents the player from pressing buttons after the game is done
            }
        }

        private void Answer(int iAnswer)
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
            var frm3 = new GameEnd();
            frm3.Show();
            this.Close();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
