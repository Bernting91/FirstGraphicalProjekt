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

namespace Uppgift_3___Grafiskt_Program_Inlämning
{
    /// <summary>
    /// Interaction logic for EndBoss.xaml
    /// </summary>
    public partial class EndBoss : Window
    {
        public EndBoss()
        {
            InitializeComponent();
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            helpTextBlock.Visibility = Visibility.Visible;
        }

        private void watchButton_Click(object sender, RoutedEventArgs e)
        {
            watchTextBlock.Visibility = Visibility.Visible;
        }
        private void exitButton_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
