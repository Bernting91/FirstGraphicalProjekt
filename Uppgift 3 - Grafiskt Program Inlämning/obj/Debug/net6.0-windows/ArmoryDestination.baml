   M S B A M L   `   `   `  ����b  ^Uppgift 3 - Grafiskt Program Inlämning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning'Uppgift_3___Grafiskt_Program_Inlämning  5   	   ?    9Uppgift_3___Grafiskt_Program_Inlämning.ArmoryDestination   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning     5   	     � Title$  ArmoryDestination��5   	   $	��450��6#   $	��800��60   .��5	      � ��5
   
   �� 5       �� ImageSource$ art/armoryImage.jpeg��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��1��6   $��Center=�6$   $
��Wrap=�6?   
������� J� Opacity$	 0.4Q�6f   
���   �$��15(�6�   $��Oblique$�6�   $
��Bold"�6�   omYou arrived at the world famous armory. You notice the shopkeeper has an epic sword you need. What do you do?5      �� 5   
   -   5         ��Name$ 	buyButton��5      $��1��6$   $��2��64   $��20��6A   $��40��6M   $��	-50 0 0 0q�6X   .��6�   Buy it6�   �� 5   
   -   5        $ stealButton��5      $��1��6&   $��2��66   $��20��6C   $��40��6O   $��50 0 0 0q�6Z   .��6�   
Steal it6�   �� 5   
   -   5         ��Name$ foundWeaponLabel��5      $��0��6*   $��2��6:   $��Center=�6G   $��Center=�6k   $��12(�6�   $y�	Collapsed=�6�   .��6�   20You dont have any money, so you steal it anyway.6�   �� 5   
   -   5        $ greedyLabel��5      $��0��6&   $��2��66   $��Center=�6C   $��Center=�6g   $��14(�6�   $y�	Collapsed=�6�   .��6�   )'You already got a sword. dont be greedy6�   �� 5   
   -   5        $ 
stealLabel��5      $��2��6$   $��2��64   $��Center=�6A   $��Center=�6e   $��20(�6�   $y�	Collapsed=�6�   .��6�   You stole the sword!6�   �� 5   
   -   5        $ goBackButton1��5      $��1��6(   $��2��68   $��20��6E   $��60��6Q   $��0 50 0 0q�6\   .��6�   	Go Back6�   �� 5!   
   -   5        $��0��5!      $��0��6!   $
��Left=�6.   $	��Top=�6I   $��0 0 0 10q�6a   $��20��6s   $	��100��6   .��6�   Show Inventory6�   5"      5#      