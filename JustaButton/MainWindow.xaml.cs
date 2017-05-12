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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFColorPickerLib;
using WpfPageTransitions;
using System.Threading;



namespace JustaButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSetup_Click(object sender, RoutedEventArgs e)
        {
            Setup win2 = new Setup();          
             win2.Show();
            this.Hide();
         
        }



        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
           GameModes win2 = new GameModes();
           win2.Show();
           this.Hide();
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
