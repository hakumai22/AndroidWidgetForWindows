   M S B A M L   `   `   `  ����R  NAndroidWidgetForWindows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:AndroidWidgetForWindowsAndroidWidgetForWindows  5   	   %    AndroidWidgetForWindows.Window1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:AndroidWidgetForWindows     5   	     � Title$  Window1��5   	   $	��800��6   $	��500��6&   
������� � 
ResizeMode$ NoResize=�5
   	    � WindowStyle$
 None=�5   	    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1	 �� 
TargetType
 �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   "	 ��6%   .�5       ��  �@�FocusVisualStyle8   61   �� 5!       � ��8  6+   �� 5"       � ��8  6,   �� 5#       � ��# � ��6+   �� 5$       � ��$ 1q�60   �� 5%       � ��$ Center=�6;   �� 5&       � ��$ Center=�69   �� 5'       � ��$ 1q�6(   �� 5(       � �� 5)      �� 5*      "
 ��6&   .R�5+      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   ._�5,      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5-       5.      P� 5/       �@��IsDefaulted$
 true��6=   . �50   "   �� $ border��6@    � �� �	#000000006T   51      P� 52       �@J�IsMouseOver$
 true��6=   . �53   "   �� $ border��6?    � �� �	#506060606S   �� 54   "   $ border��6@    � �� �	#010101016T   55      P� 56       � ��$
 true��6;   . �57   "   �� $ border��6?    � �� �	#200000006S   �� 58   "   $ border��6@    � �� �	#000000006T   59      P� 5:       � {�$ false��6;   . �5;   "   �� $ border��6?   8   � ��6S   �� 5<   "   $ border��6@   8   � ��6T   �� 5=   "   $ contentPresenter��6K   8   � ��6i   5>      5@      5B      5C      5D      .��5E      � .+�5F   
   �� $�� AndroidWidgetForWindows��6   $��
0,88,0,612q�63   $��36(�6G   $
��Bold"�6U   �� 5G   
   $	��100��6   $��/widget.png��6   $��200,10,200,690q�62   $��UniformToFill=�6J   $	��100��6b    �� StretchDirection$ DownOnly=�6n   �� 5H   
   -   5        #��� 
 5H      ���	#01010101$��0,138,0,562q�6O   $	��100��6d   5I      �� 5J   
   $	��100��6   $��
/cross.png��6    J� RenderTransformOrigin$ 	0.5,-0.12&�60   $��200,163,200,587q�6R   5L      5M      