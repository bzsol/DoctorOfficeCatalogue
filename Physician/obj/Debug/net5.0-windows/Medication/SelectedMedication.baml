   M S B A M L   `   `   `  ����D  @Physician, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Physician.MedicationPhysician.Medication  5   	   -    'Physician.Medication.SelectedMedication   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Physician.Medication     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterOwner=�5	   	    � WindowStyle$
 None=�5
   	    � Title$ Gyógyszer adatai��5   	   $	��600��6"   $	��800��6/   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 0q�6      CaptionHeight$ 0Q�61   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#   ���	#FFA80000
�������.��5      �  � ColumnDefinitions 5      �� 5      $��0.03* �6'   67   �� 5      6)   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Pill=�6*   $��0��66   $��25��6F   $��25��6R   $��	-1,-1,0,0q�6]   $��Center=�6p   6�   �� 5      -   5        	 ��Name$	 MedicationNameTextBlock��5      $��1��6=   $��16(�6M   $��DemiBold"�6[   Név adatai6}   5      5      � 5!   
   $��1��6   $��15q�6    5"      �� 5#      $
��0.8* �6    60   �� 5$      $
��0.8* �6    60   �� 5%      $
��0.8* �6    60   �� 5&      $
��0.8* �6    60   �� 5'      $
��0.8* �6    60   �� 5(      $
��0.8* �6    60   �� 5)      $��1.75* �6    61    5,      �� 5-      $
��0.3* �6#   62   �� 5.      $��1* �6#   60   .+�51      �� $��0��6   $��0��6!   $��Gyógyszer neve:��61   $��20(�6K   $��Bottom=�6Y   $
��Left=�6t   $��SemiBold"�6�   6�   �� 52      $��1��6   $��0��6!   $��Hatóanyag:��61   $��20(�6F   $��Bottom=�6T   $
��Left=�6o   $��SemiBold"�6�   6�   �� 53      $��2��6   $��0��6!   $��Alsó korhatár:��61   $��20(�6J   $��Bottom=�6X   $
��Left=�6s   $��SemiBold"�6�   6�   �� 54      $��3��6   $��0��6!   $��Felső korhatár:��61   $��20(�6K   $��Bottom=�6Y   $
��Left=�6t   $��SemiBold"�6�   6�   �� 55      $��4��6   $��0��6!   $��
Adagolás:��61   $��20(�6E   $��Bottom=�6S   $
��Left=�6n   $��SemiBold"�6�   6�   �� 56      $��5��6   $��0��6!   $��Kiszerelés:��61   $��20(�6G   $��Bottom=�6U   $
��Left=�6p   $��SemiBold"�6�   6�   �� 57      $��6��6   $��0��6!   $��Rövid leírás:��61   $��20(�6I   $��Center=�6W   $
��Left=�6r   $��SemiBold"�6�   6�   �� 59      -   5        
 ��Name$
 
MedNameBox��59   3   $��0��6   $��1��6#    %  !MaterialDesignFloatingHintTextBox#��[  6H   $
��Auto��5:      $��20(�6   $��0 10 0 0q�6-   �� 5;      -   5        $
 ActIngredientBox��5;   3   $��1��6   $��1��6#   #��[  6N   $
��Auto��5<      $��20(�6   $��0 10 0 0q�6-   �� 5=      -   5        $
 	MinAgeBox��5=   3   $��2��6   $��1��6#   #��[  6G   $
��Auto��5>      $��20(�6   $��0 10 0 0q�6-   �� 5?      -   5        $
 	MaxAgeBox��5?   3   $��3��6   $��1��6#   #��[  6G   $
��Auto��5@      $��20(�6   $��0 10 0 0q�6-   �� 5A      -   5        $
 	DosageBox��5A      $��4��6)   $��1��66   #��[  6F   $
��Auto��5B      $��20(�6#   $��0 10 0 0q�61   �� 5C      -   5        $
 PackagingBox��5C      $��5��6,   $��1��69   #��[  6I   $
��Auto��5D      $��20(�6#   $��0 10 0 0q�61   �� 5E      -   5        $
 DescriptionBox��5E      $��6��6.   $��1��6;    ! MaterialDesignOutlinedTextBox#��[ 6K   $��Center=�6�   $
��Auto��6�   $��80��5F       �� AcceptsReturn$
 True��6    �� TextWrapping$
 Wrap=�62   " �� VerticalScrollBarVisibility$
 Auto=�6F   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Leírás��6i   $��20(�6�   5G      �� 5I   
   $��2��6   $��Bottom=�6"   $��Right=�6=    �� Orientation$ 
Horizontal=�6Y   .+�5J      �� -	   5         ��Name$ DeletePatient��5J      $��Törlés��6,   $��15q�6=   $��80��6I   6u   �� 5K      -
   5        $ SavePatientData��5K      $��Mentés��6.   $��15q�6?   $��80��6K   6y   �� 5L      -   5        $ AddMedication��5L      $��	Felírás��6,   $��15q�6>   $	��100��6J   6t   �� 5M      -   5        $ ClosePatientDataWindow��5M      $��	Kilépés��65   $��15q�6G   $��80��6S   6�   5N      �� 5O   
   -   5         ��Name$ 
ErrorLabel��5O      $��2��6   $#��Az adatok kitöltése hibás!��61   $��20(�6V   $��SemiBold"�6d   ���	#FFA80000$
��Left=�5P      $��Bottom=�6+   $��	15 0 0 15q�6F   $y�Hidden=�6Y   5Q      5R      