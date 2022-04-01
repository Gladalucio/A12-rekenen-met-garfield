using System;
using System.Drawing;
using System.Windows.Forms;

namespace LT
{
    public partial class Menu : Form
    {
        public static string SetName = "";

        public Menu()
        {
            InitializeComponent();
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
                var temp = lstNaam.GetItemText(lstNaam.SelectedItem) + "!";
                SetName = temp.Remove(0, 5);
                var frm2 = new Game();
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
    }
}
