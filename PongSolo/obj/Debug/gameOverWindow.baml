   M S B A M L   `   `   `  ����C  ?PongSolo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PongSoloPongSolo  5   	       PongSolo.gameOverWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PongSolo     5   	   J FXamlAnimatedGif, Version=1.2.3.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5   	   -   5        $��GOverWindow��5	   4     � Title$  	Game Over��6	   $	��475��6   $	��525��6(    � WindowStartupLocation$ CenterScreen=�6G    � Icon$ /Resources/preview.ico��6�    � 	Resources 5
         _ListBoxItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding	 J� SnapsToDevicePixels
 �� Triggers P� Property P� Value �� 
TargetName ��Name ��Name��%�  &	        '�� e    �� 5   
   " ��6*   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��_Border��6!   $ 2q�5   !   	 . ._�5      �� 5      
 5      P� 5       �@��
IsSelected . . �5   "   �� $ _Border��6)    6T   Z�  � ���� 5   "    � ��
 � � �6?   5      5      5      5      �� 5   
   " ��6   .�5      ��  � �� 5       �� 5!      " ��6&   .R�5"      �� $ border��6!   #��z��61   #��z��6]   #��z��6�   	 . ._�5#      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5$      
 5%      P� 5&       � {� .  . �5'   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5(      P� 5)       �@J�IsMouseOver . . �5*   "   �� $ border��6@    � �� �	#FF7EB4EA6T   5+      P� 5,       �@J�	IsFocused . . �5-   "   �� $ border��6@    6T   Z�  � ��5.      50      52      53      54      .��55      � ��56   
   !� 57       !� Visual 58      �� 59      '  !XamlAnimatedGif.AnimationBehavior   	SourceUri$ Resources/giphy.gif?�6      	AutoStart .    RepeatBehavior$ 1��6y   5;       � ColumnDefinitions 5=   
   �� 5>      6!   �� 5?      $
��1.7* �6   6.   �� 5@      6!    � RowDefinitions 5B   
   �� 5C      6   �� 5D      6   �� 5E      6   �� 5F      6   .+�5I   
   �� $��
Game Over!��6   
��� � �$��1��69   $��1��6I   $��VCR OSD MONO)�6V   $��20(�6p   $��Center=�6~   �� 5J   
   -   5        $��
scoreLabel��5J      $��Score: ��6"   
��� � �$��1��6H   $��1��6X   $��VCR OSD MONO)�6e   $��20(�6   $
��Left=�6�   $��Bottom=�6�   �� 5K   
   $��Save your record ��6   
��� � �$��1��6@   $��2��6P   $��VCR OSD MONO)�6]   $��20(�6w   $��Center=�6�   $	��Top=�6�   �� 5L   
   -   5         ��Name$ 
namePlayer��5L      $�� ��6&   
��� � �$��VCR OSD MONO)�6A   $��20(�6[   $��1��6i   $��2��6y   $��Center=�6�   $��Bottom=�6�    �� 	MaxLength$ 10��6�   ��6�   Z� ��6  Z�  �� SelectionBrush 6)  Z� �� 5N   
   $��Bottom=�6   #���   6-    J� IsHitTestVisible .  $��3��6   $��1��6�   $
��Auto=�5O      $
��Auto=�5P      
���������6D   Z� ��6n   Z� .@�5Q      �� -   5        $��	saveLabel��5Q   (   $��20(�6   $��VCR OSD MONO)�6Q   $��Center=�6k   $��Bottom=�6�   .��6�   Save6�   �� 5R      -   5        $��mainMenuLabel��5R   (   $��20(�6   $��VCR OSD MONO)�6Y   $��Center=�6s   $��Bottom=�6�   .��6�   Back to menu6�   5S      5T      5U      