   M S B A M L   `   `   `  ����C  ?PongSolo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PongSoloPongSolo  5   	       PongSolo.Game   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PongSolo     5   	   J FXamlAnimatedGif, Version=1.2.3.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5   	   -   5          � Title$
  Game��5	   	   $��610.142��6   $��735.679��6'    � WindowStartupLocation$ CenterScreen=�6N    � Icon$ /Resources/preview.ico��6�    � 	Resources 5
         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers	 P� Property
 P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5      	 �@J�IsMouseOver
 . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5      .��5      � 
���   � � ColumnDefinitions 5    
   �� 5!      6!    � RowDefinitions 5$   
   �� 5%      6   �� 5&      $��3* �6   6*   .+�5)   
   �� -   5        $��superBorder��5)      
�������$��10q�68   $��1��6M   ._�5*      �� -   5        $��superCanvas��5*      .+�5+      �� -   5         ��Name$ 	superRect��5+      
����  �$	��100��6;   $��15��6G   
 �� Top$ 0��6S    �� Left$ 0��6c   A� 5,      -   5         A�Name$ 	superElly��5,      
���� ��$��20��6;   $��20��6F   $��1��6R   $ 0��6_   $ 0��6n   5-      5.      �� 5/   
   -   5        $��
scoreLabel��5/   b   $��VCR OSD MONO)�6   $��Center=�6*   $��Center=�6E   $��Punteggio: 0��6t   $
��Bold"�6�   $��20(�6�   $��0��6�   $��40��6�   
��� � �6�   51      52      