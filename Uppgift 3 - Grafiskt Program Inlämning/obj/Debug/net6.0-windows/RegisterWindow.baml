   M S B A M L   `   `   `  ����b  ^Uppgift 3 - Grafiskt Program Inlämning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning'Uppgift_3___Grafiskt_Program_Inlämning  5   	   <    6Uppgift_3___Grafiskt_Program_Inlämning.RegisterWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Uppgift_3___Grafiskt_Program_Inlämning     5   	     � Title$  RegisterWindow��5   	   $	��450��6    $	��800��6-   .��5	      � ��5
   
   �� 5       �� ImageSource$ Art/registerScreen3.jpg��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6   $
��Left=�6-   $��	20 40 0 0q�6H   .��6\   Desired Username5      �� 5   
   $��1��6   $��1��6   $
��Left=�6-   $��	20 70 0 0q�6H   .��6\   Desired Password5      �� 5   
   -   5         ��Name$ registerUsernameTextBox��5      $	��120��63   $��20��6?   $��1��6K   $��1��6X   $��100 -35 0 0q�6h   
�������6�   �� 5   
   -   5        $ registerPasswordTextBox��5      $	��120��63   $��20��6?   $��1��6K   $��1��6X   $��
100 22 0 0q�6h   
�������6�   �� 5    
   $��1��6   $��1��6!   �� 5!   
   -   5         ��Name$ goBackButton��5!      $��1��6'   $��1��67   $��20��6D   $��60��6P   $��
-20 90 0 0q�6[   
��� ���.��6�   	Go Back6�   �� 5"   
   -   5        $ registerButton��5"      $��1��6)   $��1��69   $��20��6F   $��50��6R   $��
100 90 0 0q�6]   
��� ���.��6�   
Register6�   5#      5$      