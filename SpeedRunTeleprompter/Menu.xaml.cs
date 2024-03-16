using System.IO;
using System.Windows.Controls;

namespace SpeedRunTeleprompter
{
    /// <summary>
    /// Interaktionslogik für Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
            var games = Directory.GetDirectories(Utilities.defaultStorageLocation);
            foreach (var game in games)
            {
                Utilities.speedRunningGames.Add(new Contexts.GamesContext
                {
                    Name = Path.GetDirectoryName(game),
                    Path = game
                });
            }
        }

        private void lbGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
