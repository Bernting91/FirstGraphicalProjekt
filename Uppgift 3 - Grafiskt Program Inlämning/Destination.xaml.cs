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
    /// Interaction logic for Destination.xaml
    /// </summary>
    public partial class Destination : Window
    {
        Item Sword;
        Item Bow;
        Item Wand;

        private Hero player;
        public Destination(Hero Player, Item Sword, Item Bow, Item Wand)
        {
            InitializeComponent();
            this.player = Player;
            this.Sword = Sword;
            this.Bow = Bow;
            this.Wand = Wand;
        }

        private void textBlockLake_click(object sender, MouseButtonEventArgs e)
        {
            Location Lake = new Location("Lake", Wand);
            Hero Player = this.player;
            LakeDestination lakeDestination = new LakeDestination(Player, Lake);
            lakeDestination.Show();
        }

        private void textBlockCave_click(object sender, MouseButtonEventArgs e)
        {
            Location Cave = new Location("Cave", Bow);
            Hero Player = this.player;
            CaveLocation caveLocation = new CaveLocation(Player, Cave);
            caveLocation.Show();
        }

        private void textBlockArmory_click(object sender, MouseButtonEventArgs e)
        {
            Location Armory = new Location("Armory", Sword);
            Hero Player = this.player;
            ArmoryDestination armorydestination = new ArmoryDestination(Player, Armory);
            armorydestination.Show();
        }

        private void textBlockGoHome_click(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        private void textBlockFaceDemon_click(object sender, MouseButtonEventArgs e)
        {
            if (player.GetItems().Contains(Sword) && player.GetItems().Contains(Bow) && player.GetItems().Contains(Wand))
            {
                EndBoss endboss = new EndBoss();
                endboss.Show();
            }
            else
            {
                notReadyLabel.Visibility = Visibility.Visible;
            }

        }

        private void goBackCharacterScreenButton_Click(object sender, RoutedEventArgs e)
        {
            if (Owner is CharacterScreen characterscreen)
            {
                characterscreen.Visibility = Visibility.Visible;
            }
            this.Close();
        }

        private void destination_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D1:
                    HandleKeyPress(textBlockLake_click);
                    break;
                case Key.D2:
                    HandleKeyPress(textBlockCave_click);
                    break;
                case Key.D3:
                    HandleKeyPress(textBlockArmory_click);
                    break;
                case Key.D4:
                    HandleKeyPress(textBlockGoHome_click);
                    break;
                case Key.D5:
                    HandleKeyPress(textBlockFaceDemon_click);
                    break;
            }
        }
        private void HandleKeyPress(MouseButtonEventHandler MouseEvent)
        {
            // Call the specified click event logic
            MouseEvent?.Invoke(this, new MouseButtonEventArgs(Mouse.PrimaryDevice, 0, MouseButton.Left));
        }

        private void showInventory_click(object sender, RoutedEventArgs e)
        {
            InventoryForm inventoryform = new InventoryForm(player);
            inventoryform.ShowDialog();
        }


    }
}
