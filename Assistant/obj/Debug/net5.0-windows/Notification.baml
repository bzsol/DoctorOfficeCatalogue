   M S B A M L   `   `   `  ����D  @Assistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Assistant	Assistant  5   	       Assistant.Notification   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Assistant     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Megerősítés��5	   	   $	��200��6   $	��750��6*    � WindowStartupLocation$ CenterOwner=�5
   	    � WindowStyle$
 None=�5   	   $��2q�5   	   ���	#FFA80000'  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 0q�6      CaptionHeight$ 0Q�61   .��5      � .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $	��750��6#   $��25��6/   ���	#FFA80000$	��Top=�6R   $
��Left=�6j   
�������$��16(�5   6   .��5      � $	��750��6    � ColumnDefinitions 5      �� 5      $��0.035* �6'   68   �� 5      6)   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AlertOctagonOutline=�6*   $��0��6E   $��25��6U   $��25��6a   $��	-2,-2,0,0q�6l   $��Center=�6   �� 5      $��1��6   $��16(�6,   $��DemiBold"�6:   Megerősítés6]   5      5      �� 5   
   -   5        $	��Nem��5      $��Right=�6   $��Bottom=�6;   $��	0 0 15 10q�6V   $��60��6i   6w   �� 5   
   -   5        $
��Igen��5      $��Right=�6    $��Bottom=�6<   $��
0 0 100 10q�6W   $��60��6k   6y   �� 5   
   $
��Left=�6   $=��7Biztos benne, hogy be szeretné zárni az alkalmazást?��6-    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��720��5       $��60��6   $��2q�6*   ���	#FFA80000$��	15 50 0 0q�6V   $��16(�6i   $��5 5 0 0q�6w   	 �� 
IsReadOnly$
	 True��6�   
 J� IsHitTestVisible$
 False��6�   5!      5"      