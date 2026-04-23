using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;


namespace TrésorExpress
{
    internal class Treasure : GameItem
    {
        //dessiner carré dorré immobile
        private const double size = 20;

        public Treasure(Point position)
        {
            Position = position;
        }
        public override void Draw(Canvas canvas)
        {
            Rectangle rect = new Rectangle()
            {
                Width = size,
                Height = size,
                Fill = Brushes.Gold
            };
            Canvas.SetLeft(rect, Position.X);
            Canvas.SetTop(rect, Position.Y);
            canvas.Children.Add(rect);
        }




    }
}
