using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceShooter.Core;
using System.Drawing;

namespace SpaceShooter.Entities
{
    class Bullet:GameEngin
    {
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }
        public bool IsPlayerBullet { get; set; }
        

        public Bullet(float x, float y, int width, int height, int speedX, int speedY, bool isPlayerBullet = true)

        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            SpeedX = speedX;
            SpeedY = speedY;
            IsPlayerBullet = isPlayerBullet;
        }

        public override void Update(float deltaTime)
        {
            X += SpeedX * deltaTime;
            Y += SpeedY * deltaTime;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = IsPlayerBullet ? Brushes.Yellow : Brushes.OrangeRed;
            g.FillRectangle(brush, Bounds);
        }
    }
}
