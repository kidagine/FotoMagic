   M S B A M L   `   `   `  ����D  @FotoMagic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FotoMagic	FotoMagic  5   	       FotoMagic.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:FotoMagic     5   	     � Title$  	Fotomagic��5   	   $��495.368��6   $��877.248��6,    � WindowStartupLocation$ CenterScreen=�6<    � Icon$( "Resources/Images/FotoMagicIcon.ico��6a   ���	#FFEBEBEB � 
ResizeMode$ NoResize=�6�    � 	Resources 5	         GridViewColumnHeaderStyle1 �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 �� Padding �� TextAlignment��%�  &	        �� 5   
   " ��63   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��0,0,0,1q�6!   
���   �
������ ._�5      �� $	 ContentHeader��6(   #��z��6?   $
 5,5,5,0q�6`   #��z��6r   $
 Left=�6�   5      5      5      �� 5       �@�OverridesDefaultStyle . 66   �� 5       � ��
 �   �6+   �� 5       � ��$ 
Montserrat)�6+   �� 5       � ��$ 20(�6)   5      5      .��5      ��  J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      -   5        dseMain��   
BlurRadius$ 4Q�5   0      Color$ Black��6?      Opacity$	 0.7Q�6M      ShadowDepth$	 0.4Q�6[   ._�5   
   � -   5         �Name$ grdMain��5      ���	#FFEBEBEB$��0,0,0,-8q�67   .+�5       �� ���	#FFF0F0F0$
��Left=�6)   $	��381��6D   $��0,56,0,0q�6Q   ���	#00000000$	��Top=�6v   $	��324��6�   �� 5!      -   5        $��Πρόσθεσε +��5!      $
��Left=�6*   $��0,0,90,0q�6E   $��
65,159,0,0q�6X   $	��Top=�6l   $	��235��6�   ���	#00000000���	#00000000���	#FF2D2D2D$��
Montserrat)�6�   $��20(�6  $��52��6    	ButtonNin#���  6  �� 5"      ���	#FF2D2D2D$
��Left=�6)   $��1��6D   $��	39,55,0,0q�6O   ���	#FF2D2D2D$	��Top=�6u   $	��785��6�   �� 5#      ���	#FF2D2D2D$
��Left=�6)   $��1��6D   $��
39,436,0,0q�6O   ���	#FF2D2D2D$	��Top=�6v   $	��785��6�   �� 5$      $��Πελάτες��6   $
��Left=�6&   $��	65,17,0,0q�6A   $	��Top=�6T   ���	#FF252526$��24(�6�   $��Montserrat Medium)�6�    J� RenderTransformOrigin$ 
0.51,1.483&�6�   �� 5%      -   5         ��Name$ 	txtSearch��5%      $
��Left=�6)   $��Center=�6E   $��57��6g   $��	57,71,0,0q�6s    �� TextWrapping$
 Wrap=�6�   $"��Ψάξε τον πελάτη��6�   $	��Top=�6�   $	��250��6�    �� TextAlignment$ Center=�6�   ���	#FF7E7E7E  
TextBoxNin#���  6c  ���	#FF2D2D2D6�  �� 5&      -   5         ��Name$ lstCustomers��5&      $	��370��6-   $��364,65,45,37q�6:   $	��Top=�6P   
������ $��
Montserrat)�6�   $��18(�6�   ���	#FF2D2D2D$
��Left=�6�     ListViewNin#���  6
   �� View 5'      �� 5(      ! �� ColumnHeaderContainerStyle# [  6   .P�5)      �� $��
Όνομα��6)    �� Width$	 140��5*   P    �� DisplayMemberBinding 6%   �� *	FirstName+6P   �� 5+      $��Επώνυμο��6)   $	 140��5,   O    6%   �� *
LastName+6O   �� 5-      $��Κόστος��6)   $	 140��5.   P    6%   �� *	OwedMoney+6P   5/      ��51      �� 52      " ��6   .�53      ��  � ��$ 0q�63   �� 54       � ��$ 0q�64   �� 55       � �� 56      �� 57   "   " ��62   .R�58   &   ��  J� SnapsToDevicePixels . #��z��59   )   #��z��5:   )   #��z��5;   )   ._�5<   *   �� $��Border��61   ���	#FFCDCDCD$��
0, 0, 0, 1q�6W   ._�5=   .   �  � RowDefinitions 5>   2   �� 5?   6   $��11��6D   �� 5@   6   .+�5B   2   �� $��UpperHighlight��6<   $y�	Collapsed=�6R   ���	#75FFFFFF6i   �� 5C   2   $��2��6G   #��z��5D   1   # z 5E   1   5F   /   5G   +   5H   '    �� Triggers 5I   &   P� 5J   *    P� Property �@J�IsMouseOver P� Value . . �5K   .   ��  � ��
 �����6K   �� 5L   .    � ��$ 2q�6P     N� EnterActions  5M   .   �� 5N   2   ! �� HandoffBehavior$! Compose=�6B   .��5O   6   �� .��5P   :   �� " g� Duration$" 0:0:0.5D�6I   # �� From$# 	#FF1769E0X�6\   	$ �� To$$ 	#FF1D9BF3X�6m   % g� AutoReverse% . & g� RepeatBehavior$& Forever��6�   ' �� TargetProperty$' BorderBrush.Color�6�   ( �� EasingFunction( 5Q   >   -  'System.Windows.Media.Animation.BackEase  5R   B   7  1System.Windows.Media.Animation.EasingFunctionBase)   
EasingMode$) 	EaseInOut=�6K   *   	Amplitude$* 2Q�6b   5T   ;   5U   7   5V   3   + N� ExitActions+ 5X   .   �� 5Y   2   $! SnapshotAndReplace=�6B   .��5Z   6   �� .��5[   :   �� $" 0:0:0D�6I   $$ TransparentX�6Z   $' BorderBrush.Color�6k   5\   7   5]   3   5_   +   P� 5`   *    �@��
IsSelected . . �5a   .   ��  � �� �	#FFFBFBFB6K   �� 5b   .    � �� �	#FF1D9BF36L   �� 5c   .    � ��$ 2q�6P   5d   +   5f   #   5h      5i      5k      �� 5l      -   5        , ��Name$, 	btnRemove��5l      $��Διέγραψε -��6(   $
��Left=�6=   $��0,0,96,0q�6X   $��
65,220,0,0q�6k   $	��Top=�6   $	��235��6�   ���	#00000000���	#00000000���	#FF2D2D2D$��
Montserrat)�6  $��20(�6  $��52��6'  #���  63  �� 5m      ���	#FFF90000$
��Left=�6)   $	��1.2��6D   $��
65,145,0,0q�6Q   ���	#FFCDCDCD$	��Top=�6x   $	��235��6�   �� 5n      -   5        - ��Name$- 	rctDarken��5n      $
��Left=�6+   $	��464��6F   ���	#FF2D2D2D$	��Top=�6f   $	��869��6~   ���	#FF2D2D2D. J� Opacity$
. 0.60Q�6�   $y�Hidden=�6�   6�   5o      5p      5q      