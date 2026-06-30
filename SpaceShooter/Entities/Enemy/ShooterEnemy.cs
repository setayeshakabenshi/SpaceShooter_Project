using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceShooter.Core;
using System.Drawing;

namespace SpaceShooter.Entities.Enemy
{
     class ShooterEnemy :EnemyBase
    {
        private float shootTimer;
        private float fireRate = 1.5f;
        private List<Bullet> enemyBullets;

    }
}
