using System;
using System.Windows;
using System.Windows.Controls;

namespace TrésorExpress
{
    public class Game
    {
        private Player player;
        private Treasure treasure;

        public Game()
        {
            // Position de départ (à ajuster plus tard)
            player = new Player(new Point(0, 0));
            treasure = new Treasure(new Point(350, 350));
        }

        public void MovePlayer(Direction direction)
        {
            player.Move(direction);
        }

        public void Draw(Canvas canvas)
        {
            canvas.Children.Clear(); // Nettoie les anciens dessins
            player.Draw(canvas);
            treasure.Draw(canvas);
        }

        public bool CheckVictory()
        {
            // Comparer les positions (tolérance 0)
            return player.Position.X == treasure.Position.X &&
                   player.Position.Y == treasure.Position.Y;
        }
    }
}