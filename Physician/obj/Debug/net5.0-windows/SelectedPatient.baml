   M S B A M L   `   `   `  ����D  @Physician, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Physician	Physician  5   	       Physician.SelectedPatient   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Physician     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Beteg adatai��5	   	   $	��800��6   $	��800��6+    � WindowStartupLocation$ CenterOwner=�5
   	    � WindowStyle$
 None=�5   	   ���	#FFA80000$��2q�5   	   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 0q�6      CaptionHeight$ 0Q�61   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#   ���	#FFA80000
�������.��5      �  � ColumnDefinitions 5      �� 5      $��0.03* �6'   67   �� 5      6)   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   $��0��69   $��25��6I   $��25��6U   $��	-1,-1,0,0q�6`   $��Center=�6s   6�   �� 5       -   5        	 ��Name$	 PatientNameTextBlock��5       $��1��6:   $��16(�6J   $��DemiBold"�6X   Név adatai6z   5!      5"      � 5$   
   $��1��6   $��15q�6    5%      �� 5&      $
��0.8* �6    60   �� 5'      $
��0.8* �6    60   �� 5(      $
��0.8* �6    60   �� 5)      $
��0.8* �6    60   �� 5*      $
��0.8* �6    60   �� 5+      $
��0.8* �6    60   �� 5,      $��1.75* �6    61   �� 5-      $��1.75* �6    61    50      �� 51      $
��0.3* �6#   62   �� 52      $��1* �6#   60   .+�55      �� $��0��6   $��0��6!   $��Vezetéknév:��61   $��20(�6G   $��Bottom=�6U   $
��Left=�6p   $��SemiBold"�6�   6�   �� 56      $��1��6   $��0��6!   $��Keresztnév:��61   $��20(�6G   $��Bottom=�6U   $
��Left=�6p   $��SemiBold"�6�   6�   �� 57      $��2��6   $��0��6!   $��Születési dátum:��61   $��20(�6L   $��Bottom=�6Z   $
��Left=�6u   $��SemiBold"�6�   6�   �� 58      $��3��6   $��0��6!   $��Lakcím:��61   $��20(�6C   $��Bottom=�6Q   $
��Left=�6l   $��SemiBold"�6�   6�   �� 59      $��4��6   $��0��6!   $��
TAJ-szám:��61   $��20(�6E   $��Bottom=�6S   $
��Left=�6n   $��SemiBold"�6�   6�   �� 5:      $��5��6   $��0��6!   $��	Allergia:��61   $��20(�6E   $��Bottom=�6S   $
��Left=�6n   $��SemiBold"�6�   6�   �� 5;      $��6��6   $��0��6!   $��Panasz:��61   $��20(�6C   $��Center=�6Q   $
��Left=�6l   $��SemiBold"�6�   6�   �� 5<      $��7��6   $��0��6!   $��Diagnózis:��61   $��20(�6F   $��Center=�6T   $
��Left=�6o   $��SemiBold"�6�   6�   �� 5>      -   5        
 ��Name$
 SecondNameTextBox��5>   3   $��0��6   $��1��6#    %  !MaterialDesignFloatingHintTextBox#��[  6O   $
��Auto��5?      $��20(�6   )  #MaterialDesignThemes.Wpf.HintAssist   
HelperText$ Kovács��6-   $��0,12,0,0q�6[   �� 5@      -   5        $
 FirstNameTextBox��5@   3   $��1��6   $��1��6#   #��[  6N   $
��Auto��5A      $��20(�6   $ József��6-   $��0,12,0,0q�6[   �� 5B      -   5        $
 HomeAddressTextBox��5B   3   $��3��6   $��1��6#   #��[  6P   $
��Auto��5C      $��20(�6   $ Debrecen, Kossuth utca 1.��6-   $��0,12,0,0q�6n   �� 5D      -   5        $
 
HISTextBox��5D   3   $��4��6   $��1��6#   #��[  6H   $
��Auto��5E      $��20(�6   $ 000 000 000��6-   $��0,12,0,0q�6`   �� 5F      -   5        $
 AllergyTextBox��5F   3   $��5��6   $��1��6#   #��[  6L   $
��Auto��5G      $��20(�6   $ amoxicillin��6-   $��0,12,0,0q�6`   �� 5H      -   5        $
 ComplaintTextBox��5H      $��6��60   $��1��6=    ! MaterialDesignOutlinedTextBox#��[ 6M   $��Center=�6�   $
��Auto��6�   $	��110��5I       �� AcceptsReturn$
 True��6    �� TextWrapping$
 Wrap=�63   " �� VerticalScrollBarVisibility$
 Auto=�6G   $��20(�6j    J� IsHitTestVisible$ False��6x   �� 5J      -   5        $
 DiagnosisTextBox��5J      $��7��60   $��1��6=   #��[ 6M   $��Center=�6�   $
��Auto��6�   $	��110��5K      $
 True��6   $
 Wrap=�63   $
 Auto=�6G      Hint$ 
Diagnózis��6j   $��20(�6�   (  "System.Windows.Controls.DatePicker  5L      -	   5        $��DateOfBirth��5M   �    ( $MaterialDesignFloatingHintDatePicker#��[ 6   $��0,0,5,0q�6A   $��20(�6R   $ 1970.01.01.��6`   $��2��6�   $��1��6�   5N      �� 5P   
   $��2��6   $��Bottom=�6"   $��Right=�6=    �� Orientation$ 
Horizontal=�6Y   .+�5Q      �� -
   5         ��Name$ 
ErrorLabel��5Q      $#��Az adatok kitöltése hibás!��6(   $��20(�6M   $��SemiBold"�6[   ���	#FFA80000$
��Left=�5R      $��Center=�6+   $��	0 0 210 0q�6F   $y�	Collapsed=�6Y   �� 5S      -   5         ��Name$ MedicationListView��5S      $��Kezelés��61   $��15q�6C   $��80��6O   6w   �� 5T      -   5        $ DeletePatient��5T      $��Törlés��6,   $��15q�6=   $��80��6I   6r   �� 5U      -   5        $ SavePatientData��5U      $��Mentés��6.   $��15q�6?   $��80��6K   6v   �� 5V      -   5        $ ClosePatientDataWindow��5V      $��	Kilépés��65   $��15q�6G   $��80��6S   6�   5W      5X      5Y      