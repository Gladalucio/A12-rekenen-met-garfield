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
    public partial class Form3 : Form
    {
        int iGoed = Form2.iGoed;
        int iFout = Form2.iFout;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblGoed.Text = iGoed.ToString();
            lblFout.Text = Form2.iFout.ToString();
            Start();
        }

        private void Start()
        {
            if (iGoed < 7)
            {
                lblConclusie.Text = "Wat jammer! Volgende keer maken wij hem beter!";
                lblConclusie2.Text = "Garfield weet dat je het kunt!";
                picSad1.Visible = true;
                picSad2.Visible = true;
            }
            else
            {
                lblConclusie.Text = "Wat goed! Ik wist dat je het kon, bravo!";
                lblConclusie2.Text = "Garfield is trots op je!";
                picHappy1.Visible = true;
                picHappy2.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
