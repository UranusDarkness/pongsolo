   M S B A M L   `   `   `  ����C  ?PongSolo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PongSoloPongSolo  5   	       PongSolo.Leaderboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PongSolo     5   	   J FXamlAnimatedGif, Version=1.2.3.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5   	   -   5        $��leaderboardWindow��5	        � Title$  Leaderboard��6	   $	��685��66   $	��615��6C    � WindowStartupLocation$ CenterScreen=�6O    � Icon$ /Resources/preview.ico��6�    � 	Resources 5
         _ListBoxItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding	 J� SnapsToDevicePixels
 �� Triggers P� Property P� Value �� 
TargetName��%o  &	        �� 5   
   " ��6*   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��_Border��6!   $ 2q�5   !   	 . ._�5      �� 5      
 5      P� 5       �@��
IsSelected . . �5   "   �� $ _Border��6)    6T   Z�  � ���� 5   "    � ��
 � � �6?   5      5      5      5      5      .��5       � ��5!   
   !� 5"       !� Visual 5#      �� 5$      '  !XamlAnimatedGif.AnimationBehavior   	SourceUri$ Resources/giphy.gif?�6      	AutoStart .    RepeatBehavior$ 1��6y   5&       � ColumnDefinitions 5(   
   �� 5)      6!   �� 5*      $��3* �6   6,   �� 5+      6!    � RowDefinitions 5-   
   �� 5.      6   �� 5/      $
��0.4* �6   6,   �� 50      $��3* �6   6*   �� 51      $
��0.3* �6   6,   �� 52      $��1* �6   6*   .+�54   
   �� $��Top 10 Players��6   
�������$��1��6=   $��1��6M   $��VCR OSD MONO)�6Z   $��20(�6t   $��Center=�6�   $��Center=�6�   &   System.Windows.Controls.DataGrid  55   
   -   5        $��dataGridLeaderboard��55   L     CanUserAddRows .     CanUserSortColumns .     AutoGenerateColumns .     CanUserDeleteRows .     
IsReadOnly .    CanUserReorderColumns .  $��2��6�   $��1��6�      RowBackground
 ���� 
��� � �$��VCR OSD MONO)�6$  $��20(�6>  ��6�   Z� ��6�   Z�    Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ Player��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65      
FontFamily$ VCR OSD MONO)�6_      FontSize$ 20Q�6y   1  +System.Windows.Controls.DataGridBoundColumn    Binding  6?   �� *name_player+!   ElementStyle! 59      �� 5:      " ��6    .�5;      ��  � ��$ Center=�6D   5<      5>        5?      $ Score��6%   $ * 64   $ VCR OSD MONO)�6_   $ 20Q�6y     6>   �� *score_player+! 5@      �� 5A      " ��6    .�5B      ��  � ��$ Center=�6D   5C      5E      "   ColumnHeaderStyle" 5G      �� 5H      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5I      ��  � ��
 ���� 63   �� 5J       � ��$ Center=�6C   5K      #   RowHeaderStyle# 5N      �� 5O      :  4System.Windows.Controls.Primitives.DataGridRowHeader"  6   .�5P      ��  � ��
 ���� 63   5Q      5T      �� 5U   
   #���   6   $ J� IsHitTestVisible$ .  $��3��6d   $��1��6q   $
��Auto=�5V      $
��Auto=�5W      
���������6D   Z� ��6n   Z� .@�5X      �� -   5        $��	menuLabel��5X   r   % �� 
IsSelected% . $��Center=�6,   $��Center=�6I   $��20(�6d   $��VCR OSD MONO)�6�   .��6�   Back to menu6�   5Y      5Z      5[      