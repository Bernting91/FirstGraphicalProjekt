using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
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
    /// Interaction logic for CaveLocation.xaml
    /// </summary>
    public partial class CaveLocation : Window
    {
        public Hero player;
        public Location location;
        public CaveLocation(Hero player, Location location)
        {
            InitializeComponent();
            this.player = player;
            this.location = location;
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            if (player.GetItems().Contains(location.Loot))
            {
                foundWeaponLabel.Visibility = Visibility.Collapsed;
                greedyLabel.Visibility = Visibility.Visible;
            }
            else
            {
                foundWeaponLabel.Visibility = Visibility.Visible;
                greedyLabel.Visibility = Visibility.Collapsed;
                player.AddItem(location.Loot);
            }
        }
        private void runButton_Click(object sender, RoutedEventArgs e)
        {
            runLabel.Visibility = Visibility.Visible;
        }

        private void goBackButton1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void showInventory_click(object sender, RoutedEventArgs e)
        {
             InventoryForm inventoryform = new InventoryForm(player);
             inventoryform.ShowDialog();
            
        }
    }
}
