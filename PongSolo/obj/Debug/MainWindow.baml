   M S B A M L   `   `   `  ����C  ?PongSolo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PongSoloPongSolo  5   	       PongSolo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PongSolo     5   	   J FXamlAnimatedGif, Version=1.2.3.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5   	   -   5        $��mainMenu��5	   ]     � Title$  	Pong solo��6	   $	��600��6   $��735.927��6(    � WindowStartupLocation$ CenterScreen=�68    � Cursor$
 None��6�    � Icon$ /Resources/preview.ico��6�    � 	Resources 5
         _ListBoxItemStyle �� 
TargetType �� Property �� Value �� 
TargetType	 �� Padding
 J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName��%o  &	        �� 5   
   " ��6*   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��_Border��6!   $	 2q�5   !   
 . ._�5      �� 5       5      P� 5       �@��
IsSelected . . �5   "   �� $ _Border��6)    6T   Z�  � ���� 5   "    � ��
 � � �6?   5      5      5      5      5      .��5      � ��5    
   !� 5!       !� Visual 5"      �� 5#      '  !XamlAnimatedGif.AnimationBehavior   	SourceUri$ Resources/giphy.gif?�6      	AutoStart .    RepeatBehavior$ 1��6y   5%       � RowDefinitions 5(   
   �� 5)      6   �� 5*      6   �� 5+      6    � ColumnDefinitions 5-   
   �� 5.      6!   �� 5/      6!   �� 50      6!   .+�53   
   �� #���   6    J� IsHitTestVisible .  $��1��6d   $��1��6q   $
��Auto=�54      $
��Auto=�55      
���������6D   Z� ��6n   Z� .@�56      �� -   5        $��	playLabel��56   r   $��Center=�6   $��Center=�67   $��30(�6R    �� 
IsSelected . $��VCR OSD MONO)�6�   .��6�   PLAY6�   �� 57      -   5        $��leaderboardButton��57   `   $��Center=�6   $��Center=�67   $��30(�6R   $��VCR OSD MONO)�6y   .��6�   LEADERBOARD6�   �� 58      -   5        $��
exitButton��58   `   $��Center=�6   $��Center=�67   $��30(�6R   $��VCR OSD MONO)�6�   .��6�   EXIT6�   59      5;      5=      