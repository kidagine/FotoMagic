   M S B A M L   `   `   `  ����D  @FotoMagic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FotoMagic	FotoMagic  5   	   !    FotoMagic.AddCustomerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:FotoMagic     5   	     � Title$  AddCustomerWindow��5   	   $	��425��6#   $	��660��60    � WindowStartupLocation$ CenterOwner=�6<    � ShowInTaskbar .   � 
ResizeMode$ NoResize=�6v    � WindowStyle$
 None=�6�    � AllowsTransparency . 
������ 
������ .��5	      �� ���	#FFF0F0F0$��1,1,1,1q�6$    �� CornerRadius$ 5,5,5,5��6>   ._�5
   
   � .+�5      �� -   5        $��MyImg��5   0   $
��Left=�6   $��43��6=   $��41,0,0,0q�6I   $	��Top=�6[   $��60��6s   $'��!Resources/Images/UserAddImage.png��6~    J� RenderTransformOrigin$ 0.897,0.765&�6�   �� 5      $#��Πρόσθεσε πελάτη��6   $
��Left=�6.   $	��Top=�6I   $��	100,9,0,0q�6a   $��Montserrat Medium)�6t   $��20(�6�   ���	#00000000���	#FF2D2D2D6�   �� 5      $��
Όνομα��6   $
��Left=�6$   $��
186,65,0,0q�6?   $	��Top=�6S   $��
Montserrat)�6k   �� 5      -   5         ��Name$ lblError��5      $��error��6&   $��Center=�66   $��Center=�6Z   $��173,274,158,0q�6w   $	��Top=�6�   ���	#FFFF5130$	��378��6�   $��
Montserrat)�6�   $��2��6�   $y�Hidden=�6�   �� 5      $��Επώνυμο��6   $
��Left=�6&   $��186,168,0,0q�6A   $	��Top=�6V   $��
Montserrat)�6n   �� 5      -   5        	 ��Name$	 rctFirstName��5      ���	#FF1D9BF3$
��Left=�6?   $��22��6Z   $��
175,65,0,0q�6f   ���	#FF1D9BF3$	��Top=�6�   $��6��6�   �� 5      -   5        $	 rctLastName��5      ���	#FF1D9BF3$
��Left=�6>   $��22��6Y   $��175,168,0,0q�6e   ���	#FF1D9BF3$	��Top=�6�   $��6��6�   �� 5      -   5        
 ��Name$
 btnExit��5      $��ακύρωση?��6&   $��Center=�69   $��	0,370,0,0q�6V   $	��Top=�6i   $��98��6�   ���	#FF1D9BF3���	#00000000
������ $��
Montserrat)�6�   $��1��6  �� 5      -   5        $
 
btnConfirm��5      $��Επιβεβαίωση��6)   $��Center=�6?   $��Center=�6c   $��	0,304,0,0q�6�   $	��Top=�6�   $	��192��6�   ���	#FF1D9BF3���	#00000000
�������$��51��6�   $��
Montserrat)�6  $��14(�6  $��2��6D     ButtonNinBig#���   6X  �� 5      ���	#FF2D2D2D$
��Left=�6)   $��1��6D   $��	22,55,0,0q�6O   ���	#FF2D2D2D$	��Top=�6u   $	��607��6�   $ 0.5,0.5&�6�   $��2��6�   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6)   �� 5      �� 5      T� 5      5      5      �� 5      ���	#FF2D2D2D$
��Left=�6)   $��1��6D   $��
26,396,0,0q�6O   ���	#FF2D2D2D$	��Top=�6v   $	��608��6�   $ 0.5,0.5&�6�   $��2��6�   z�5      V� 5       .~�5!      �� $ -1Q�6)   �� 5"      �� 5#      T� 5$      5%      5'      �� 5(      -   5         ��Name$ txtLastName��5(      $8��2Γράψε το επώνυμο του πελάτη��6+   $��Center=�6N   $��155,199,155,168q�6p   
����������	#FF7E7E7E �� TextAlignment$ Center=�6�    �� SelectionBrush �	#FF1D9BF3���	#FF2D2D2D$��
Montserrat)�6�   $��16(�6  $��2��6�    
TextBoxNin#���  6�  �� 5)      -   5        $ txtFirstName��5)      $4��.Γράψε το όνομα του πελάτη��6,   $��Center=�6M   $��155,95,155,272q�6o   
����������	#FF7E7E7E$ Center=�6�    �	#FF1D9BF3���	#FF2D2D2D$��
Montserrat)�6�   $��16(�6  $��2��6�  #���  6�  5*      5+      5,      