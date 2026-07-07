using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpaceShooter.Core
{
    public static class GameAssets
    {
        public static Image PlayerImg;
        public static Image BulletImg;
        public static Image StandardEnemyImg;
        public static Image ScoutEnemyImg;
        public static Image ShooterEnemyImg;
        public static Image HeavyTankEnemyImg;
        public static Image TerroristEnemyImg;
        public static Image BackgroundImg;

        public static void Load()
        {
            PlayerImg = MakeTransparent(Properties.Resources.player);
            StandardEnemyImg = MakeTransparent(Properties.Resources.standardenemy);
            ScoutEnemyImg = MakeTransparent(Properties.Resources.scoutenemy);
            ShooterEnemyImg = MakeTransparent(Properties.Resources.shooterenemy);
            HeavyTankEnemyImg = MakeTransparent(Properties.Resources.heavytankenemy);
            TerroristEnemyImg = MakeTransparent(Properties.Resources.terroristenemy);
            BulletImg = MakeTransparent(Properties.Resources.bullet);
            BackgroundImg = Properties.Resources.background;
        }

        private static Bitmap MakeTransparent(Bitmap source)
        {
            Bitmap result = new Bitmap(source);
            Color bgColor = Color.White;

            FloodFillEdge(result, 0, 0, bgColor);
            FloodFillEdge(result, result.Width - 1, 0, bgColor);
            FloodFillEdge(result, 0, result.Height - 1, bgColor);
            FloodFillEdge(result, result.Width - 1, result.Height - 1, bgColor);

            for (int x = 0; x < result.Width; x++)
            {
                FloodFillEdge(result, x, 0, bgColor);
                FloodFillEdge(result, x, result.Height - 1, bgColor);
            }

            for (int y = 0; y < result.Height; y++)
            {
                FloodFillEdge(result, 0, y, bgColor);
                FloodFillEdge(result, result.Width - 1, y, bgColor);
            }

            return result;
        }

        private static void FloodFillEdge(Bitmap bmp, int x, int y, Color targetColor)
        {
            if (x < 0 || x >= bmp.Width || y < 0 || y >= bmp.Height)
                return;

            Color pixelColor = bmp.GetPixel(x, y);

            if (pixelColor.A == 0 || !ColorsMatch(pixelColor, targetColor))
                return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point pt = pixels.Pop();

                if (pt.X < 0 || pt.X >= bmp.Width || pt.Y < 0 || pt.Y >= bmp.Height)
                    continue;

                Color current = bmp.GetPixel(pt.X, pt.Y);

                if (current.A == 0 || !ColorsMatch(current, targetColor))
                    continue;

                bmp.SetPixel(pt.X, pt.Y, Color.Transparent);

                pixels.Push(new Point(pt.X + 1, pt.Y));
                pixels.Push(new Point(pt.X - 1, pt.Y));
                pixels.Push(new Point(pt.X, pt.Y + 1));
                pixels.Push(new Point(pt.X, pt.Y - 1));
            }
        }

        private static bool ColorsMatch(Color c1, Color c2, int tolerance = 30)
        {
            return Math.Abs(c1.R - c2.R) <= tolerance &&
                   Math.Abs(c1.G - c2.G) <= tolerance &&
                   Math.Abs(c1.B - c2.B) <= tolerance;
        }

    }

}
