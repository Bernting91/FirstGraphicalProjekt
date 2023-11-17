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
        private Hero player;
        public Destination()
        {
            InitializeComponent();
            this.player = player;
            
        }
        
        private void textBlockLake_click(object sender, MouseButtonEventArgs e)
        {

        }

        private void textBlockCave_click(object sender, MouseButtonEventArgs e)
        {

        }

        private void textBlockArmory_click(object sender, MouseButtonEventArgs e)
        {

        }

        private void textBlockGoHome_click(object sender, MouseButtonEventArgs e)
        {

        }

        private void textBlockFaceDragon_click(object sender, MouseButtonEventArgs e)
        {

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
                    HandleKeyPress(textBlockFaceDragon_click);
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
