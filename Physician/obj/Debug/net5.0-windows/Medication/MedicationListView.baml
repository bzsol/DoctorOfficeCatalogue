   M S B A M L   `   `   `  ����D  @Physician, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Physician.MedicationPhysician.Medication  5   	   -    'Physician.Medication.MedicationListView   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Physician.Medication     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Gyógyszerek listája��5
   	   $	��800��6%   $
��1200��62   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$
 Dark=�6#   $��15q�6/   ���	#FFA80000+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6S   $��0��6�   .��5      ]� .+�5      ��  $   MaterialDesignHeadline6TextBlock#��[  6   $��Gyógyszerek��6V   
�������6i   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$
 Pill=�6*   $��30��66   $��30��6B   
�������6M   5      5        5   
   $��1��6#   $��60��60   
�������.��5      �  � ColumnDefinitions 5      �� 5      $
��0.2* �6'   66   �� 5      $��1* �6'   64   �� 5      $
��0.2* �6'   66   .+�5      � $��0��6    5       �� 5!      6*   �� 5"      6*   .+�5%      �� $��0��6   $��20(�6)   $��SemiBold"�67   $��	Keresés:��6M   $��15 0 0 0q�6`   �� 5&      -   5         ��Name$ PreferenceButton��5&   *   $��1��6   $	��100��6D   $��25��6P   $
��Név��6\   $
��Left=�6j   $��15 0 0 0q�6�   5'      5(      �� 5*      -   5         ��Name$ SearchTextBox��5*   *   $��1��6    % !MaterialDesignFloatingHintTextBox#��[ 6A   $
��Auto��6|   $��
10 5 10 10q�6�   $��20(�6�   $��0 0 10 0q�5+      6-   �� 5-      -   5        	 ��Name$	 CountOfResultsLabel��5-   (   $��2��6   $��20(�6E   ���#A8A8A8$��Center=�6h   $��	0 20 0 10q�6�   $y�Hidden=�6�   6�   5.      5/      #  MaterialDesignThemes.Wpf.Card  50   
   $��2��6   $��Stretch=�6+   $	��Top=�6I   $
��Auto��6a   $
��Auto��6o   .��51      �� -   5        $��MedicationList��51   :   $	��Top=�6P   $��Stretch=�6h   $
��Auto��6�   
 �� SelectionMode$
 Single=�6�   $��Stretch=�6�   ��6   �� *
Medication+��52      �� 53       �� 
TargetType" ��6   .�54      ��  �� Property � �� �� Value$ Stretch=�6G   �� 55       � ��$ 25��63    �� Triggers 56      P� 57       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �58   "   ��  � �� 59   &   �� 5:   *    �� 
TargetType" ��6:   .R�5;   .   ��  �� Padding$ 0q�65   ���#E0E0E0 J� SnapsToDevicePixels$
 True��6V   ._�5<   2   �� $
 True��6G   5=   /   5>   +   5@   #   5A      P� 5B       �@��
IsSelected$
 True��6<   . �5C   "   ��  � �� 5D   &   �� 5E   *   " ��6:   .R�5F   .   �� $ 0q�65   ���#E0E0E0$
 True��6V   ._�5G   2   �� $
 True��6G   5H   /   5I   +   5K   #   5L      5N       �� View 5P      �� 5Q      ! �� ColumnHeaderContainerStyle 5R      �� 5S       �� BasedOn# [B��6$   " ��6]   .�5T   "   ��  � ��$ Center=�6H   �� 5U   "    �@J�IsHitTestVisible$ False��6E   6U   5V      .P�5X      �� $
��Név��6)    �� Width$
 Auto��66    �� CellTemplate 5Y      �� 5Z   "   .R�5[   &   ��  �� TextAlignment$ Center=�6P   ��60   �� *MedicationName+6P   5\   #   5^      �� 5_      $��
Hatóanyag��6)   $
 Auto��6<    5`      �� 5a   "   .R�5b   &   �� $ Center=�6R   ��60   �� *ActiveIngredient+6R   5c   #   5e      �� 5f      $��Alsó korhatár��6)   $
 Auto��6@    5g      �� 5h   "   .R�5i   &   �� $ Center=�6L   ��60   �� *
MinimumAge+6L   5j   #   5l      �� 5m      $��Felső korhatár��6)   $
 Auto��6A    5n      �� 5o   "   .R�5p   &   �� $ Center=�6L   ��60   �� *
MaximumAge+6L   5q   #   5s      �� 5t      $��	Adagolás��6)   $
 Auto��6;    5u      �� 5v   "   .R�5w   &   �� $ Center=�6H   ��60   �� *Dosage+6H   5x   #   5z      �� 5{      $��Kiszerelés��6)   $
 Auto��6=    5|      �� 5}   "   .R�5~   &   �� $ Center=�6K   ��60   �� *	Packaging+6K   5   #   5�      �� 5�      $��Leírás��6)   $
 Auto��69    5�      �� 5�   "   .R�5�   &   �� $ Center=�6M   ��60   �� *Description+6M   5�   #   5�      5�      5�      5�      � 5�   
   5�      5�      