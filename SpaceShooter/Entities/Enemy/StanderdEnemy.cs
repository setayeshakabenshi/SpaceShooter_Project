using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceShooter.Entities.Enemy;
using System.Drawing;

namespace SpaceShooter.Entities.Enemy
{
    class StanderdEnemy:EnemyBase
    {
        public StanderdEnemy(int x, int y, Rectangle bound) : base(x, y, 35, 35, 120f, 20, 100, bound)
        {

        }

        public override void Update(float deltaTime)
        {
            Y += Speed * deltaTime;
            if (Y > gameBounds.Height)
                IsAlive = false;



        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Crimson, Bounds);
        }
    }
}
