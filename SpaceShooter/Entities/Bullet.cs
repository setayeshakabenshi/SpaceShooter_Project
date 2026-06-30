using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceShooter.Core;

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
    }
}
