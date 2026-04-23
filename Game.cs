using System;
using System.Windows;
using System.Windows.Controls;

namespace TrésorExpress
{
    internal class Game
    {
        private Canvas canva;
        private Player player;
        private Treasure treasure;
        private const double size = 20; // Taille de la grille (20x20 pixels)

        public Game()
        {
            this.canva = new Canvas();
            player = new Player(new Point(0, 0)); // Position de départ du joueur
            treasure = new Treasure(new Point(100, 100)); // Position du trésor
        }

        public void MovePlayer(Direction direction)
        {
            player.Move(direction);
            CheckVictory();
        }

        public void Draw(Canvas canvas)
        {
            canvas.Children.Clear(); // Nettoie les anciens dessins
            player.Draw(canvas);
            treasure.Draw(canvas);
        }

        public bool CheckVictory()
        {
            return Math.Abs(player.Position.X - treasure.Position.X) < size &&
                   Math.Abs(player.Position.Y - treasure.Position.Y) < size;
        }
    }
}