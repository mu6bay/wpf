   M S B A M L   `   `   `  ����C  ?WpfApp56, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp56WpfApp56  5   	       WpfApp56.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp56     5   	   -   5          � Title$  Carousel��5   	   $	��800��6   $	��600��6&    � 	Resources 5	         CarouselPath E� 
StartPoint �� Point1 �� Point2 �� Point3  CarouselImageStyle �� 
TargetType �� Property �� Value	 �� Triggers
 P� Property P� Value��%�  &	        &	 �     B� 5
   
   .��5      E� $ 400,100&�6   .��5      �� $ 600,200&�6    $ 600,400&�61   $ 400,500&�6B   �� 5      $ 200,400&�6    $ 200,200&�61   $ 400,100&�6B   5      5      �� 5   
   " (�6+   .�5      ��  �@J�Opacity$	 0.5Q�6(   �� 5       �@J�RenderTransformOrigin$ 0.5,0.5&�66   	 5      P� 5      
 �@��Left$ 0��61   . �5      ��  �@J�Opacity$ 1Q�60   5      5      5      .��5      �� -   5        $��canvas��5      $��	-83,0,0,0q�6   .+�5   
   (�  �� Left$	 100��6   
 �� Top$ 0��6$   $	��100��63   #��[ 6?   .��5      �� $��/bez-nazvaniya-1-30.jpg��6    J� OpacityMask �	#FFE9D7D365   5       (� 5!   
   $	 200��6   $	 100��6$   $	��100��65   #��[ 6A   .��5"      �� $��/PCforoffice.jpg��6   5#      (� 5$   
   $	 300��6   $	 200��6$   $	��100��65   #��[ 6A   .��5%      �� $��/20226.970.jpg��6   5&      (� 5'   
   $	 400��6   $	 300��6$   $	��100��65   #��[ 6A   .��5(      �� $��/ipadmini2tehlg.jpg��6   $
��2165��61   5)      (� 5*   
   $	 500��6   $	 400��6$   $	��100��65   #��[ 6A   .��5+      �� $��/3.png��6   5,      5-      5.      