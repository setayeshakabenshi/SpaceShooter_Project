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
            this.DoubleBuffered = true;
        }



        private void UpdatePlayerMovement(float deltaTime)
        {
            
            if (IsMovingLeft && player.X > 0)
                player.MoveLeft();

            if (IsMovingRight && player.X + player.Width < this.ClientSize.Width)
                player.MoveRight();

            if (IsMovingUp && player.Y > 0)
                player.MoveUp();

            if (IsMovingDown && player.Y + player.Height < this.ClientSize.Height)
                player.MoveDown();
        }

        private void GameForm_KeDown(object sender, KeyEventArgs e)
        {

        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
