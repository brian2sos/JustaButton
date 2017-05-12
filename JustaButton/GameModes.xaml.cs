using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JustaButton
{
    /// <summary>
    /// Interaction logic for GameModes.xaml
    /// </summary>
    public partial class GameModes : Window
    {
        public GameModes()
        {
            InitializeComponent();
        }

        private void btnTrivia_Click(object sender, RoutedEventArgs e)
        {
            TriviaSetup win2 = new TriviaSetup();
            win2.Show();
            this.Close();
        }

        private void btnSimonSays_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMusicalChairs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBattle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCopsNRobers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlayatune_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Show();
            this.Close();
        }
    }
}
