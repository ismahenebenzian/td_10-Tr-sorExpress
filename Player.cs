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
    internal class Player : GameItem
    {
        private const double size = 20;
        public Player(Point start)
        {
            Position = start;
        }
        public override void Draw(Canvas canvas)
        {
            Ellipse circle = new Ellipse()
            {
                Width = size,
                Height = size,
                Fill = Brushes.Blue
            };
            Canvas.SetLeft(circle, Position.X);
            Canvas.SetTop(circle, Position.Y);
            canvas.Children.Add(circle);
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Position.Y -= size;
                    break;
                case Direction.Down:
                    Position.Y += size;
                    break;
                case Direction.Left:
                    Position.X -= size;
                    break;
                case Direction.Right:
                    Position.X += size;
                    break;
            }
        }
    }
}

    
