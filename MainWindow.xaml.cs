using System.Windows;
using System.Windows.Input;
using TrésorExpress;

namespace appli
{
    public partial class MainWindow : Window
    {
        private Game game;

        public MainWindow()
        {
            InitializeComponent();
            game = new Game();                     // constructeur sans paramètre
            game.Draw(GameCanvas);                // dessin initial
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Direction? dir = null;

            if (e.Key == Key.Up) dir = Direction.Up;
            else if (e.Key == Key.Down) dir = Direction.Down;
            else if (e.Key == Key.Left) dir = Direction.Left;
            else if (e.Key == Key.Right) dir = Direction.Right;

            if (dir.HasValue)
            {
                game.MovePlayer(dir.Value);
                game.Draw(GameCanvas);

                if (game.CheckVictory())
                    MessageBox.Show("Victoire !");
            }
        }
    }
}