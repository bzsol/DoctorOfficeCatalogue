   M S B A M L   `   `   `  ����D  @Physician, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Physician.MedicationPhysician.Medication  5   	   )    #Physician.Medication.MedicationView   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Physician.Medication     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterOwner=�5	   	    � WindowStyle$
 None=�5
   	    � Title$ Gyógyszer kezelő��5   	   $	��300��6"   $	��500��6/   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 0q�6      CaptionHeight$ 0Q�61   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   6,   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $
��0.8* �6   6,   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#   $	��500��60   $��25��6<   ���	#FFA80000$	��Top=�6_   $
��Left=�6w   
�������$��16(�5   6   .��5      � $	��500��6    � ColumnDefinitions 5      �� 5      $��0.055* �6'   68   �� 5      6)   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Pill=�6*   $��0��66   $��25��6F   $��25��6R   $��0,0,0,0q�6]   $��Center=�6n   �� 5      $��1��6   $��16(�6,   $��DemiBold"�6:   $��1q�6P   Gyógyszer kezelése6o   5       5!      � 5#   
   $��1��6    5$      �� 5%      6%   �� 5&      6%   .+�5)      �� -   5        	 ��Name$	 
MedNameBox��5)   3   $��0��6   $��0��6#   $��50��6G   $��16(�6S   $��
10 0 10 10q�6a   $��0 10 0 0q�6u    %  !MaterialDesignFloatingHintTextBox#��[  5*      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Gyógyszer neve��6Q   6�   �� 5+      -   5        $	 ActIngredientBox��5+   3   $��0��6   $��1��6#   $��50��6M   $��16(�6Y   $��
10 0 10 10q�6g   $��0 10 0 0q�6{   #��[  5,      $
 
Hatóanyag��6Q   6~   5-      � 5/   
   $��2��6    50      �� 51      6%   �� 52      6%   �� 53      6%   �� 54      6%   .+�57      �� -   5        $	 	MinAgeBox��57   &   $��0��6   $��50��69   $��16(�6E   $��
10 0 10 10q�6S   $��0 10 0 0q�6g   #��[  58      $
 Alsó korhatár��6Q   6�   �� 59      -   5        $	 	MaxAgeBox��59   &   $��1��6   $��50��69   $��16(�6E   $��
10 0 10 10q�6S   $��0 10 0 0q�6g   #��[  5:      $
 Felső korhatár��6Q   6�   �� 5;      -   5        $	 	DosageBox��5;   &   $��2��6   $��50��69   $��16(�6E   $��
10 0 10 10q�6S   $��0 10 0 0q�6g   #��[  5<      $
 	Adagolás��6Q   6}   �� 5=      -   5        $	 PackagingBox��5=   &   $��3��6   $��50��6<   $��16(�6H   $��
10 0 10 10q�6V   $��0 10 0 0q�6j   #��[  5>      $
 Kiszerelés��6Q   6   5?      �� 5A   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5B      �� -   5        $	��130��5B      $��20q�6!   $��Hozzáadás��6-   6_   �� 5C      -   5        $	��130��5C      $��20q�6!   $��Törlés��6-   6T   �� 5D      -	   5        $	��130��5D      $��20q�6!   $��	Kilépés��6-   6U   5E      5F      5G      