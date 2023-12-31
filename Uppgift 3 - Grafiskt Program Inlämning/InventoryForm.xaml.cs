﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
    /// Interaction logic for InventoryForm.xaml
    /// </summary>
    public partial class InventoryForm : Window
    {
        private Hero player;
        public InventoryForm(Hero player)
        {
            InitializeComponent();
            this.player = player;
            itemListBox.ItemsSource = player.GetItems();
            itemListBox.Items.Refresh();
        }
    }
}
