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
    /// Interaction logic for TriviaSetup.xaml
    /// </summary>
    public partial class TriviaSetup : Window
    {
        public TriviaSetup()
        {
            InitializeComponent();
        }

        private void btnSubPlayer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddPlayer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubTeam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddTeam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNewBank_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddRounds_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubRounds_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddQuestion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubQuestion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.QuestionSteal=true;
            Properties.Settings.Default.Save();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            GameModes win2 = new GameModes();
            win2.Show();
            this.Close();
        }
    }
}
