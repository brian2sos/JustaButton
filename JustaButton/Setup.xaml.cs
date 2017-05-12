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
    /// Interaction logic for Setup.xaml
    /// </summary>
    public partial class Setup : Window
    {
        public Setup()
        {
            InitializeComponent();
        }



        private void BtnScan_Click(object sender, RoutedEventArgs e)
        {
            ButtonList win2 = new ButtonList();   
            win2.Show();
            this.Close();
        
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
          App.Current.MainWindow.Show();
          this.Close();          
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnFx_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNetwork_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
