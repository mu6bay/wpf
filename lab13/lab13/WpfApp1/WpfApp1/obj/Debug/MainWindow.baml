   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         PathAnimation E� 
StartPoint E� IsClosed �� Point��%�   &	        B� 5
   
   .��5      E� $ 100,100&�6    . .��5      �� $ 500,100&�6   �� 5      $ 300,200&�6   5      5      5      .��5      ��  J� OpacityMask
 �������5   
   �� 5       �� ImageSource$H B/1636517755_53-papik-pro-p-minimalisticheskie-milie-risunki-54.png��6   .+�5   
   F� ���	#FF101110$��3��6"   #��[  66   �� 5   
   $��!��6    � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� 	 g� RepeatBehavior$	 Forever��6%   .��5      T� 
 �� TargetProperty$
 (Canvas.Left)�67    g� Duration$ 0:0:3D�5   8    T� PathGeometry# [  5   8    T� Source$ X=�5   8   T� 5      $
 (Canvas.Top)�67   $ 0:0:3D�5    8   # [  5!   8   $ Y=�5"   8   5#      5$      5%      5'      5(      5)      