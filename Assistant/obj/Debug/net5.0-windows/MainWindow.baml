   M S B A M L   `   `   `  ����D  @Assistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Assistant	Assistant  5   	       Assistant.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Assistant     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � Title$  Asszisztens Panel��5   	   $	��750��6#   $
��1000��60      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStartupLocation$ CenterScreen=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$
 Dark=�6#   $��15q�5      ���	#FFA80000+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      $��0��5      .��5      ]� .+�5      ��  $  MaterialDesignHeadline6TextBlock#��[ 6   $��Orvosi Asszisztens Panel��5      
�������5       '  !MaterialDesignThemes.Wpf.PackIcon  5!         Kind$ 
MedicalBag=�6*   $��23��5"   "   $��27��5#   "   
�������5$   "   '  !MaterialDesignThemes.Wpf.PopupBox  5%      
�������$��Right=�5&   "      PopupContent. 5'      ��   MaterialDesignListBox#��[ 6   .@�5(      �� .��5)      ]� .+�5*   "   �� -   5        	 ��Name$	 
HelpButton��5*   )   .��5+   &   �� 
 �� Orientation$
 
Horizontal=�61   .+�5,   *     $ Information=�6B   $��25��5-   *   $��25��5.   *   �� 5/   *   $��Leírás��60   50   '   51   #   52      53      �� 54      .��55      ]� .+�56   "   �� -   5        $	 
ExitButton��56   )   .��58   &   �� $
 
Horizontal=�61   .+�59   *     $ ExitRun=�6B   $��25��5:   *   $��25��5;   *   �� 5<   *   $��	Kilépés��60   5=   '   5>   #   5?      5@      5A      5B      5C      5D      #  MaterialDesignThemes.Wpf.Card  5E   
   $��16q�6   $��1��6+   $��Center=�68   $��Center=�6U   $	��608��6p   $	��956��6}   .��5F      �  5G      �� 5H      $
��1.5* �6$   64   �� 5I      $
��1.5* �6$   64   �� 5J      $
��1.5* �6$   64   �� 5K      $
��1.5* �6$   64   �� 5L      $
��1.5* �6$   64   �� 5M      $��3* �6$   62   �� 5N      $
��1.5* �6$   64   .+�5P      �� $��0��6   $
 
Horizontal=�6*   .+�5Q      � .+�5R      �� -   5         ��Name$ SecondNameTextBox��5R   "    % !MaterialDesignFloatingHintTextBox#��[ 6>   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Vezetéknév��6y      
HelperText$ Kovács��5S   $   $	��930��6R   $��	10,3,0,19q�6^   $��20(�6q   ��6   �� *	Content+6q   5T      5U      �� 5V      $��1��6   $
 
Horizontal=�6*   .+�5W      � .+�5X      �� -   5        $ FirstNameTextBox��5X   "   #��[ 6=   $ Keresztnév��6x   $ József��5Y   $   $	��930��6R   $��	10,3,0,19q�6^   $��20(�6q   ��6   �� *	Content+6q   5Z      5[      �� 5\      $��2��6   $
 
Horizontal=�6*   $��Center=�6C   $��Center=�6`   .+�5]      (  "System.Windows.Controls.DatePicker  -   5        $��DateOfBirth��5`   �   $	��913��5^      $ Születési dátum��5_       ( $MaterialDesignFloatingHintDatePicker#��[ 5`      $��10,0,0,0q�6A   $��20(�6S   $ 1970.01.01.��6a   6�   5a      �� 5b      $��3��6   $
 
Horizontal=�6*   $��Center=�6C   .+�5c      � .+�5d      �� -   5        $ HomeAddressTextBox��5d   "   #��[ 6?   $ Lakcím��6z   $ Debrecen, Kossuth utca 1.��5e   $   $	��930��6e   $��	10,3,0,19q�6q   $��20(�6�   ��6   �� *	Content+6�   5f      5g      �� 5h      $��4��6   $
 
Horizontal=�6*   .+�5i      � .+�5j      �� -   5        $ 
HISTextBox��5j   "   #��[ 67   $	 TAJ��6r   $ 000 000 000��5k   $   $	��930��6W   $��	10,3,0,19q�6c   $��20(�6v   ��6   �� *	Content+6v   5l      5m      �� 5n      $��5��6   $
 
Horizontal=�6*   .+�5o      �  � ColumnDefinitions 5p      �� 5q      61   .+�5s      �� -	   5        $ ComplaintTextBox��5s   "    ! MaterialDesignOutlinedTextBox#��[ 5t      $	��Top=�5u      $	��920��5v      $	��120��5w       �� AcceptsReturn$
 True��5x       �� TextWrapping$
 Wrap=�5y      " �� VerticalScrollBarVisibility$
 Auto=�5z      $ Panasz��5{      $��20(�5|      $��0,10,0,0q�5}      5~      5      �� 5�      $��6��6   $
 
Horizontal=�6*   $��Center=�6C   $��	0,5,0,-21q�6`   .+�5�      �� -
   5        $��3��5�      $	��150��6*   $��20q�66   $��	Felvétel��6B   6p   �� 5�      -   5        $��3��5�      $	��150��6*   $��20q�66   $��Törlés��6B   6i   5�      5�      5�      '	  !MaterialDesignThemes.Wpf.Snackbar	  5�   
   -   5         	 Name$ 
SnackbarOK��5�       	  IsActive$ False��5�      *
  $MaterialDesignThemes.Wpf.ThemeAssist 
  Theme$
 Dark=�6    	  Message. 5�      .  (MaterialDesignThemes.Wpf.SnackbarMessage  -   5        $#��Az adatok felvétele sikeres!��5�         ActionContent$ OK��5�      6   5�      	  5�   
   -   5        $ 
SnackbarPB��5�      $ False��5�      $
 Dark=�6   . 5�        -   5        $)��#Az adatok megadása nem megfelelő!��5�      $ OK��5�      6   5�      5�      5�      