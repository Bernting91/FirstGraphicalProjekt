   M S B A M L   `   `   `  ����b  ^Uppgift 3 - Grafiskt Program Inlämning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning'Uppgift_3___Grafiskt_Program_Inlämning  5   	   5    /Uppgift_3___Grafiskt_Program_Inlämning.EndBoss   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning     5   	     � Title$  EndBoss��5   	   $	��450��6   $	��800��6&   .��5	      � ��5
   
   �� 5       �� ImageSource$ art/manbearpigImage.jpg��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��1��6   $��Center=�6$   $
��Wrap=�6?   
������� J� Opacity$	 0.4Q�6f   
���   �$��15(�6�   $��Oblique$�6�   $
��Bold"�6�   ��When you go to face the demon to save the princess. You notice that Princess manbearpig has already pinned down the demon and doesnt need any help. What do you do?5      �� 5   
   -   5         ��Name$ 
helpButton��5      $��1��6%   $��2��65   $��20��6B   $��40��6N   $��	-50 0 0 0q�6Y   .��6�   Help6�   �� 5   
   -   5        $ watchButton��5      $��1��6&   $��2��66   $��20��6C   $��40��6O   $��50 0 0 0q�6Z   .��6�   Watch6�   �� 5   
   -   5         ��Name$ helpTextBlock��5      $��0��6+   $��2��6;   $��Center=�6H   $
��Wrap=�6c   
�������$	 0.4Q�6�   
���   �$��15(�6�   $��Oblique$�6�   $
��Bold"�6�   $y�	Collapsed=�6�   VTYou help the princess beat down the demon. You then run of into the sunset together.6M  �� 5   
   -   5        $ watchTextBlock��5      $��2��6,   $��2��6<   $��Center=�6I   $
��Wrap=�6d   
�������$	 0.4Q�6�   
���   �$��15(�6�   $��Oblique$�6�   $
��Bold"�6�   $y�	Collapsed=�6�   %#You stand around and enjoy the show6  �� 5   
   -   5        $ 
exitButton��5      $��1��6%   $��2��65   $��20��6B   $��60��6N   $��0 50 0 0q�6Y   .��6�   	Exit game6�   5       5!      