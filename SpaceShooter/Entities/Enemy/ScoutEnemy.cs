using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceShooter.Entities.Enemy;
using System.Drawing;

namespace SpaceShooter.Entities.Enemy
{
    class ScoutEnemy:EnemyBase
    {
        private float AliveTime = 0f;

        public ScoutEnemy(int x, int y, Rectangle bound) : base(x, y, 35, 34, 180f, 10, 150, bound)
        {

        }

        public override void Update(float daltaTime)
        {
            AliveTime += daltaTime;
            Y += Speed * daltaTime;
            X += (float)Math.Sin(AliveTime * 4f) * 150f * daltaTime;

            if (Y > Bounds.Height)
                IsAlive = false;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.MediumSpringGreen, Bounds);
        }
    }
}
