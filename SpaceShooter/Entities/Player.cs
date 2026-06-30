using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceShooter.Core;
using System.Drawing;

namespace SpaceShooter.Entities
{
    class Player: GameEngin

    {
        public int Speed { get; set; }

        public Player(int x, int y, int width, int height, int speed)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Speed = speed;
        }

        public override void Update(float deltaTime)
        {

        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Cyan, Bounds);
        }

    }
}
