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
    public partial class Form1 : Form
    {
        public static string SetName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lstNaam.SelectedIndex == -1)
            {
                lstNaam.BackColor = Color.HotPink;
                lblGeenNaam.Visible = true;
            }
            else
            {
                string temp = lstNaam.GetItemText(lstNaam.SelectedItem) + "!";
                SetName = temp.Remove(0, 5);
                Form2 frm2 = new Form2();
                frm2.Show();
                lstNaam.ClearSelected();
                lstNaam.BackColor = Color.DodgerBlue;
                lblGeenNaam.Visible = false;
            }
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNaam_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
