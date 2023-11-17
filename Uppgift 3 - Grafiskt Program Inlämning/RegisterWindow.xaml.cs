using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public MainWindow mainWindow { get; set; }
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void registerButton_click(object sender, RoutedEventArgs e)
        {
            mainWindow.RegisterUser(registerUsernameTextBox.Text, registerPasswordTextBox.Text);
            Close();
        }
    }
}
