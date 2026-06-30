using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpaceShooter.Core
{
    public abstract class GameEngin
    {
        public float X { get; set; }
        public float Y { get; set; }

        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public bool IsAlive { get; set; } = true;

        public Rectangle Bounds
        {
            get { return new Rectangle((int)X, (int)Y, Width, Height); }
        }

        public abstract void Update(float deltaTime);
        public abstract void Draw(Graphics g);
    }
}
