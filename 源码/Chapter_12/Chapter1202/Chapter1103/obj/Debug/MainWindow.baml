   M S B A M L   `   `   `  ����  Chapter1103    Chapter1103.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �� 
����ح�
���   �$��2q�5       �� CornerRadius$ 45��5       �� Padding$ 25q�5	      ._�5
   
   � 
������� � ShowGridLines .  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� -   5        $��StackPanel1��5   Q   $��0��6   $��0��6)   $
��Left=�66   $	��Top=�6d   .+�5      �� $��18(�6   $��Center=�6*   $��0,0,0,15q�6G   StackPanel16f   �� 5      $��	0,10,0,10q�6   .��6,   
Button 166   �� 5      $��	0,10,0,10q�6   .��6,   
Button 266   �� 5      $��	0,10,0,10q�6   .��6,   
Button 366   �� 5      ColumnDefinition.Width="Auto"6;   �� 5      '%StackPanel.HorizontalAlignment="Left"6C   �� 5      $"StackPanel.VerticalAlignment="Top"6@   �� 5      #!StackPanel.Orientation="Vertical"6?   �� 5      Button.Margin="0,10,0,10"67   5      �� 5      -   5        $��StackPanel2��5   T   $��1��6   $��0��6)   $��Stretch=�66   $	��Top=�6g    �� Orientation$ Vertical=�6   .+�5      �� $��18(�6   $��Center=�6*   $��0,0,0,15q�6G   StackPanel26f   �� 5      $��	10,0,10,0q�6   .��6,   
Button 466   �� 5       $��	10,0,10,0q�6   .��6,   
Button 566   �� 5!      $��	10,0,10,0q�6   .��6,   
Button 666   �� 5"      $��Center=�6   ColumnDefinition.Width="*"6U   �� 5#      $��Center=�6   *(StackPanel.HorizontalAlignment="Stretch"6c   �� 5$      $��Center=�6   $"StackPanel.VerticalAlignment="Top"6]   �� 5%      $��Center=�6   %#StackPanel.Orientation="Horizontal"6^   �� 5&      $��Center=�6   Button.Margin="10,0,10,0"6T   5'      �� 5)      -   5        $��StackPanel3��5)   Q   $��2��6   $��0��6)   $
��Left=�66   $	��Top=�6d   .+�5*      �� $��18(�6   $��Center=�6*   $��0,0,0,15q�6G   StackPanel36f   �� 5+      $��10q�6   .��6%   
Button 76/   �� 5,      $��10q�6   .��6%   
Button 86/   �� 5-      $��10q�6   .��6%   
Button 96/   �� 5.      ColumnDefinition.Width="Auto"6;   �� 5/      '%StackPanel.HorizontalAlignment="Left"6C   �� 50      $"StackPanel.VerticalAlignment="Top"6@   �� 51      #!StackPanel.Orientation="Vertical"6?   �� 52      Button.Margin="10"60   53      54      55      56      