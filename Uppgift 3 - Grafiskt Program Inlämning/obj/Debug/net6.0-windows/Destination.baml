   M S B A M L   `   `   `  ����b  ^Uppgift 3 - Grafiskt Program Inlämning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning'Uppgift_3___Grafiskt_Program_Inlämning  5   	   9    3Uppgift_3___Grafiskt_Program_Inlämning.Destination   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning     5   	   -   5          � Title$  Destination��5   	   $	��450��6   $	��800��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   ��5   
   �� 5       �� ImageSource$ art/townSquareImage.jpg��6   .+�5   
   � $��1��6   $��3��6$   $	��220��65    � Orientation$ Vertical=�6D   .+�5      �� -   5         ��Name$ chooseDestinationText��5      $
��Wrap=�68   
������� J� Opacity$	 0.4Q�6_   
���   �$��15(�6�   $��Oblique$�6�   $
��Bold"�6�   ��Hello Adventurer! Where do you want to go and search for the items you need? You need all three weapons to defeat the demon that has the princess captive.6Q  �� 5      $
��Wrap=�6   
�������$	 0.4Q�6@   
���   �$��15(�6a   $��Oblique$�6o   $
��Bold"�6�   6�   5      �� 5   
   
������  �� Orientation$ Vertical=�6.   $��2��6E   $��3��6U   .+�5      �� -   5        
�������$
��Wrap=�5   +   $��20(�6?   $��10 10 10 10q�6M   $!��1, I want to go to the lake��6b   6�   �� 5      -   5        
�������$
��Wrap=�5   +   $��20(�6?   $��10 10 10 10q�6M   $!��2, I want to go to the cave��6b   6�   �� 5      -   5        
�������$
��Wrap=�5   +   $��20(�6?   $��10 10 10 10q�6M   $#��3, I want to go to the armory��6b   6�   �� 5      -   5        
�������$
��Wrap=�5   +   $��20(�6?   $��10 10 10 10q�6M   $!��4, I'd rather just go home.��6b   6�   �� 5       -   5        
�������$
��Wrap=�5    +   $��20(�6?   $��10 10 10 10q�6M   $$��5, Im ready to face the demon!��6b   6�   5"      �� 5#   
   -   5        $��1��5#      $��2��6!   $��Center=�6.   $��Bottom=�6K   $��0 0 0 10q�6f   $��20��6x   $��50��6�   .��6�   	Go Back6�   �� 5$   
   -	   5        $��0��5$      $��0��6!   $
��Left=�6.   $	��Top=�6I   $��0 0 0 10q�6a   $��20��6s   $	��100��6   .��6�   Show Inventory6�   �� 5%   
   -
   5         ��Name$ notReadyLabel��5%      $��1��6'   $��1��67   $��Center=�6D   $��Center=�6h   $��15(�6�   
�������$y�	Collapsed=�6�   .��6�   (&You're not ready. You need all weapons6�   5&      5'      