   M S B A M L   `   `   `  ����b  ^Uppgift 3 - Grafiskt Program Inlämning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning'Uppgift_3___Grafiskt_Program_Inlämning  5   	   :    4Uppgift_3___Grafiskt_Program_Inlämning.CaveLocation   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning     5   	     � Title$  CaveLocation��5   	   $	��450��6   $	��800��6+   .��5	      � ��5
   
   �� 5       �� ImageSource$ art/crabPeopleImage.jpg��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��1��6   $��Center=�6$   $
��Wrap=�6?   
������� J� Opacity$	 0.4Q�6f   
���   �$��15(�6�   $��Oblique$�6�   $
��Bold"�6�   ��You arrived at the cave. You are met by angry crab people. Behind them, you see a bow you know to be perfect for your quest. What do you do?5      �� 5   
   -   5         ��Name$ 	yesButton��5      $��1��6$   $��1��64   $��20��6A   $��40��6M   $��	-50 0 0 0q�6X   .��6�   Fight!6�   �� 5   
   -   5        $ 	runButton��5      $��1��6$   $��1��64   $��20��6A   $��40��6M   $��50 0 0 0q�6X   .��6�   Run!6�   �� 5   
   -   5         ��Name$ foundWeaponLabel��5      $��0��6*   $��1��6:   $��Center=�6G   $��Center=�6k   $��30(�6�   
�������$y�	Collapsed=�6�   .��6�   You found a Bow!6�   �� 5   
   -   5        $ greedyLabel��5      $��0��6&   $��1��66   $��Center=�6C   $��Center=�6g   $��14(�6�   
�������$y�	Collapsed=�6�   .��6�   '%You already got a bow. dont be greedy6�   �� 5   
   -   5        $ runLabel��5      $��2��6"   $��1��62   $��Center=�6?   $��Center=�6c   $��20(�6�   
�������$y�	Collapsed=�6�   .��6�   You ran away, coward.6�   �� 5   
   -   5        $ goBackButton1��5      $��1��6(   $��1��68   $��20��6E   $��60��6Q   $��0 50 0 0q�6\   .��6�   	Go Back6�   �� 5!   
   -   5        $��0��5!      $��0��6!   $
��Left=�6.   $	��Top=�6I   $��0 0 0 10q�6a   $��20��6s   $	��100��6   .��6�   Show Inventory6�   5"      5#      