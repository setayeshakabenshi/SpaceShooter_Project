using System.Drawing;
using SpaceShooter.Core;

namespace SpaceShooter.Entities.Enemies
{
    public class ShooterEnemy : Enemy
    {
        private float _shootTimer = 0f;
        private const float ShootInterval = 1.5f;
        private const float Speed = 80f;

        public ShooterEnemy(float x, float y) : base(x, y, 32, 32)
        {
            Health = 50;
            MaxHealth = 50;
            ScoreValue = 30;
            CoinValue = 15;
            Color = Color.Purple;
            Velocity = new PointF(0, Speed);
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);

            _shootTimer += deltaTime;
            if (_shootTimer >= ShootInterval)
            {
                Shoot();
                _shootTimer = 0f;
            }

            if (Position.Y > 900)
            {
                IsActive = false;
            }
        }

        protected override void Shoot()
        {
            FireBullet(0f, 300f);
        }
    }
}
