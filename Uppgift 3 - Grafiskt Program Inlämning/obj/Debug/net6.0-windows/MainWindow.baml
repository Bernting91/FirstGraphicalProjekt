   M S B A M L   `   `   `  ����b  ^Uppgift 3 - Grafiskt Program Inlämning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning'Uppgift_3___Grafiskt_Program_Inlämning  5   	   8    2Uppgift_3___Grafiskt_Program_Inlämning.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   ��5   
   �� 5       �� ImageSource$ art/loginScreen.jpg��6   .+�5   
   �� $��1��6   $��1��6   $
��Left=�6-   $��	50 40 0 0q�6H   ��6[   Z� .��6r   
Username5      �� 5   
   $��1��6   $��1��6   $
��Left=�6-   $��	50 70 0 0q�6H   ��6[   Z� .��6r   
Password5      �� 5   
   -   5         ��Name$ loginUserNameBox��5      $	��120��6,   $��20��68   $��1��6D   $��1��6Q   $��100 -35 0 0q�6a   
�������6�   �� 5   
   -   5        $ loginPasswordBox��5      $	��120��6-   $��20��69   $��1��6E   $��1��6R   $��
100 22 0 0q�6b   
�������6�   �� 5   
   $��1��6   $��1��6!   �� 5    
   -   5         ��Name$ loginButton��5       $��1��6&   $��1��66   $��20��6C   $��40��6O   $��0 90 0 0q�6Z   
��� ���.��6�   Login6�   �� 5!   
   -   5        $ registerScreenButton��5!      $��1��6/   $��1��6?   $��20��6L   $��50��6X   $��
100 90 0 0q�6c   
��� ���.��6�   
Register6�   �� 5"   
   -   5        $ showAvailableUsersButton��5"      $��1��63   $��0��6C   $��10 10 10 10q�6P   $��30��6e   $	��120��6q   $	��Top=�6}   
�������.��6�   Show Available users6�   �� 5#   
   -   5         ��Name$ availableUsersListBox��5#      $��0,0,0,0q�61   $��2��6B   
���   �
������� J� Opacity$ -1Q�6�   �� 5$   
   -   5        $ removeUserButton��5$      $��2��6+   $��0��68   $��50 50 50 50q�6H   $ -1Q�6]   .��6�   Remove User6�   �� 5%   
   -   5         ��Name$ removeUserLabel��5%      $��2��6)   $��0��66   $��50 0 100 120q�6F   
�������$��10(�6o   $	��150��6}   $��40��6�   6�   �� 5&   
   -	   5        $ saveUsersButton��5&      $��2��6*   $��0��67   $��150 10 10 10q�6G   $��bottom=�6]   $ -1Q�6x   .��6�   
Save users6�   �� 5'   
   -
   5        $ loadUsersButton��5'      $��2��6*   $��0��67   $��10 10 150 10q�6G   $��Bottom=�6]   $ -1Q�6x   .��6�   
Load users6�   5(      5)      