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
using System.Xaml;

namespace Uppgift_3___Grafiskt_Program_Inlämning
{
    /// <summary>
    /// Interaction logic for CharacterScreen.xaml
    /// </summary>
    public partial class CharacterScreen : Window
    {
        Item Sword = new Item("Sword");
        Item Bow = new Item("Bow");
        Item Wand = new Item("Wand");
        
        public CharacterScreen()
        {
            InitializeComponent();
            
        }

        private void knightSelectionCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            knightSelectionGrid.Visibility = Visibility.Visible;
            knightSelectionGrid.IsHitTestVisible = true;
            knightSelectionCheckBox.IsChecked = false;
        }

        private void rangerSelectionCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            rangerSelectionGrid.Visibility = Visibility.Visible;
            rangerSelectionGrid.IsHitTestVisible = true;
            rangerSelectionCheckBox.IsChecked = false;
        }

        private void wizardSelectionCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            wizardSelectionGrid.Visibility = Visibility.Visible;
            wizardSelectionGrid.IsHitTestVisible= true;
            wizardSelectionCheckBox.IsChecked = false;
        }

        private void goBackButtonKnight_Click(object sender, RoutedEventArgs e)
        {
            knightSelectionGrid.Visibility = Visibility.Collapsed;
            knightSelectionGrid.IsHitTestVisible = false;
        }

        private void goBackButtonWizard_Click(object sender, RoutedEventArgs e)
        {
            wizardSelectionGrid.Visibility=Visibility.Collapsed;
            wizardSelectionGrid.IsHitTestVisible = false;
        }

        private void goBackButtonRanger_Click(object sender, RoutedEventArgs e)
        {
            rangerSelectionGrid.Visibility = Visibility.Collapsed;
            rangerSelectionGrid.IsHitTestVisible = false;
        }

        private void chooseKnightButton_click(object sender, RoutedEventArgs e)
        {
            Hero Player = new Hero("Knight", Sword);
            Destination destination = new Destination();
            destination.Owner = this;
            destination.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void chooseRangerButton_Click(object sender, RoutedEventArgs e)
        {
            Hero Player = new Hero("Ranger", Bow);
            Destination destination = new Destination();
            destination.Owner = this;
            destination.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void chooseWizardButton_Click(object sender, RoutedEventArgs e)
        {
            Hero Player = new Hero("Wizard", Wand);
            Destination destination = new Destination();
            destination.Owner = this;
            destination.Show();
            this.Visibility = Visibility.Collapsed;
        }
    }
}
