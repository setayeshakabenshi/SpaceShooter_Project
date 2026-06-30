using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            GameForm gameform = new GameForm();
            gameform.ShowDialog();

            this.Show();
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopform = new ShopForm();
            shopform.ShowDialog();
            this.Show();
        }

        private void btn_Option_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionForm optionform = new OptionForm();
            optionform.ShowDialog();
            this.Show();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutForm aboutform = new AboutForm();
            aboutform.ShowDialog();
            this.Show();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
