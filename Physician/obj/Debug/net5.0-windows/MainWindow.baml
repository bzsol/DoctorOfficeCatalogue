   M S B A M L   `   `   `  ����D  @Physician, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Physician	Physician  5   	       Physician.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Physician     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
   -   5          � Title$  Orvosi panel��5   	   $	��800��6   $
��1200��6+      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$
 Dark=�6#   $��15q�5      ���	#FFA80000+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      $��0��5      .��5      ]� .+�5      ��  $  MaterialDesignHeadline6TextBlock#��[ 6   $��Orvosi panel��5       
�������5!      '  !MaterialDesignThemes.Wpf.PackIcon  5"         Kind$ Doctor=�6*   $��23��5#   "   $��27��5$   "   
�������5%   "   '  !MaterialDesignThemes.Wpf.PopupBox  5&      
�������$��Right=�5'   "      PopupContent. 5(      ��   MaterialDesignListBox#��[ 6   .@�5)      �� .��5*      ]� .+�5+   "   �� -   5        	 ��Name$	 
HelpButton��5+   )   .��5,   &   �� 
 �� Orientation$
 
Horizontal=�61   .+�5-   *     $ Information=�6B   $��25��5.   *   $��25��5/   *   �� 50   *   $��Leírás��60   51   '   52   #   53      54      �� 55      .��56      ]� .+�57   "   �� -   5        $	 MedicationButton��57   )   .��58   &   �� $
 
Horizontal=�61   .+�59   *     $
 Pill=�6B   $��25��5:   *   $��25��5;   *   �� 5<   *   $��Gyógyszerek��60   5=   '   5>   #   5?      5@      �� 5A      .��5B      ]� .+�5C   "   �� -   5        $	 
ExitButton��5C   )   .��5E   &   �� $
 
Horizontal=�61   .+�5F   *     $ ExitRun=�6B   $��25��5G   *   $��25��5H   *   �� 5I   *   $��	Kilépés��60   5J   '   5K   #   5L      5M      5N      5O      5P      5Q        5R   
   $��1��6#   $��60��60   
�������.��5S      �  � ColumnDefinitions 5T      �� 5U      $
��0.2* �6'   66   �� 5V      $��1* �6'   64   �� 5W      $
��0.2* �6'   66   .+�5Z      � $��0��6    5[      �� 5\      6*   �� 5]      6*   .+�5`      �� $��0��6   $��20(�6)   $��SemiBold"�67   $��	Keresés:��6M   $��15 0 0 0q�6`   �� 5a      -   5        $	 PreferenceButton��5a   *   $��1��6   $	��100��6D   $��25��6P   $
��Név��6\   $
��Left=�6j   $��15 0 0 0q�6�   5b      5c      �� 5e      -   5         ��Name$ SearchTextBox��5e   *   $��1��6    % !MaterialDesignFloatingHintTextBox#��[ 6A   $
��Auto��6|   $��
10 5 10 10q�6�   $��20(�6�   $��0 0 10 0q�5f      6-   �� 5h      -   5         ��Name$ CountOfResultsLabel��5h   (   $��2��6   $��20(�6E   ���#A8A8A8$��Center=�6h   $��	0 20 0 10q�6�   $y�Hidden=�6�   6�   5i      5j      #  MaterialDesignThemes.Wpf.Card  5k   
   $��2��5l      $��Stretch=�5m      $	��Top=�69   $
��Auto��6Q   $
��Auto��6_   .��5o      �� -   5        $��PatientList��5o   7   $��Stretch=�6J   $��Stretch=�6f   $
��Auto��6�    �� SelectionMode$ Single=�6�   ��6   �� *	Patient+ � 	Resources 5p       	 Templ��%e   &	       �� 5q      .R�5r      �� $��Center=�6$   $��20(�6R   ��6A   �� 6R   5s      5t       �� View 5u      �� 5v      ! �� ColumnHeaderContainerStyle 5w      �� 5x       �� BasedOn# [B��6$    �� 
TargetType" ��6]   .�5y   "   ��  �� Property �@J�IsHitTestVisible �� Value$ False��6E   5z      .P�5}      �� $
��Név��5~       �� Width$
 Auto��6*    �� DisplayMemberBinding 5}   )   �� *
FullName+5~   *   �� 5      $	��Kor��5�      $
 Auto��6*    5   )   �� *AgeGet+5�   *   �� 5�      $��Lakcím��5�      $
 Auto��6-    5�   )   �� *HomeAddress+5�   -   �� 5�      $��	TAJ szám��5�      $
 Auto��6/    5�   )   �� *HIS+5�   /   �� 5�      $��Látogatás��5�      $
 Auto��60    5�   )   �� *Intake+5�   0   �� 5�      $��Panasz��5�      $
 Auto��6-    5�   )   �� *	Complaint+5�   -   �� 5�      $��Allergia��5�      $
 Auto��6/    5�   )   �� *	Allergy+5�   /   �� 5�      $��Gyógyszerek��5�      $
 Auto��62    5�   )   �� *GetMedications+5�   2   �� 5�      $��
Diagnózis��5�      $
 Auto��60    5�   )   �� *
Diagnose+5�   0   5�      5�      5�      � 5�   
   5�      5�      