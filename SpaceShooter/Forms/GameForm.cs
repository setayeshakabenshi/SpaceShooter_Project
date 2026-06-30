using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceShooter.Entities;

namespace SpaceShooter.Forms
{
    public partial class GameForm : Form
    {
        private Timer GameTimer;

        private Player player;

        private bool IsMovingLeft;
        private bool IsMovingRight;
        private bool IsMovingUp;
        private bool IsMovingDown;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_KeDown(object sender, KeyEventArgs e)
        {

        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
