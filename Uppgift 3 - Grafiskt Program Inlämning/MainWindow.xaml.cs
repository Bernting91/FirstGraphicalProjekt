using System;
using System.Collections.Generic;
using System.IO;
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

namespace Uppgift_3___Grafiskt_Program_Inlämning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        string username = "Robert";
        string password = "password";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void registerScreenButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerwindow = new RegisterWindow();
            registerwindow.mainWindow = this;
            registerwindow.Show();
        }
        public void RegisterUser(string username, string password)
        {
            this.username = username;
            this.password = password;
            User newUser = new User(username, password);
            users.Add(newUser);
            availableUsersListBox.Items.Add(newUser);
            availableUsersListBox.Items.Refresh();
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = loginUserNameBox.Text;
            string password = loginPasswordBox.Text;
                foreach (User user in users)
                {
                    if (user.Username == username && user.Password == password)
                    {
                        CharacterScreen characterScreen = new CharacterScreen();
                        characterScreen.Show();
                    }
                }
        }
        private void showAvailableUsersButton_Click(object sender, RoutedEventArgs e)
        {
            availableUsersListBox.Opacity = 0.2;
            removeUserButton.Opacity = 1;
            saveUsersButton.Opacity = 1;
            loadUsersButton.Opacity = 1;
        }
        private void removeUserButton_Click(object sender, RoutedEventArgs e)
        {
            User selectedUser = availableUsersListBox.SelectedItem as User;
                if (selectedUser != null)
                {
                    users.Remove(selectedUser);
                    availableUsersListBox.Items.Remove(selectedUser);
                    
                    removeUserLabel.Content = "User removed";
                }
                else
                {
                    removeUserLabel.Content = "No user selected";
                }
        }
            string path = "SavedUsers.csv";

        private void saveUsersButton_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (User user in users)
                {
                    writer.WriteLine(user.GetCSV());
                }
            }
        }

        private void loadUsersButton_Click(object sender, RoutedEventArgs e)
        {
            users.Clear();
            availableUsersListBox.Items.Clear();
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                  string[] strings = line.Split(",");
                  string username = strings[0];
                  string password = strings[1];
                  User user = new User(username, password);
                  users.Add(user);
                  availableUsersListBox.Items.Add(user);
                  line = reader.ReadLine();
                }
            }
        }
        private void AvailableUsersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User selectedUser = availableUsersListBox.SelectedItem as User;
            if (selectedUser != null)
            {
                loginUserNameBox.Text = selectedUser.Username;
                loginPasswordBox.Text = selectedUser.Password;
            }
            else
            {
                loginUserNameBox.Text = string.Empty;
                loginPasswordBox.Text = string.Empty;
            }
        }
    }
}
