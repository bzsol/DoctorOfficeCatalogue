   M S B A M L   `   `   `  ����D  @Physician, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Physician	Physician  5   	       Physician.PhysicianHelper   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Physician     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterOwner=�5	   	    � WindowStyle$
 None=�5
   	    � Title$ Leírás��5   	   $	��750��6   $
��1000��6%   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 0q�6      CaptionHeight$ 0Q�61   .��5      �  � RowDefinitions 5   
   �� 5      $��0.04* �6   6-   �� 5      $
��0.9* �6   6,   �� 5      $
��0.1* �6   6,   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#   $
��1000��60   $��25��6=   ���	#FFA80000$	��Top=�6`   $
��Left=�6x   
�������$��16(�5   6   .��5      � $
��1000��6    � ColumnDefinitions 5      �� 5      $��0.025* �6'   68   �� 5      6)   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ InfoOutline=�6*   $��0��6=   $��25��6M   $��25��6Y   $��0,0,0,0q�6d   $��Center=�6u   �� 5      $��1��6   $��16(�6,   $��DemiBold"�6:   $��1q�6P   Leírás - Orvosi panel6r   5       5!      �� 5#   
   $��1��6   $
��Auto=�6$   .��5$      �  5%      �� 5&      $
��0.1* �6$   64   �� 5'      $
��0.2* �6$   64   �� 5(      $
��0.1* �6$   64   �� 5)      $
��0.2* �6$   64   �� 5*      $
��0.1* �6$   64   �� 5+      $
��0.2* �6$   64   �� 5,      $
��0.1* �6$   64   �� 5-      $
��0.2* �6$   64   �� 5.      $
��0.1* �6$   64   �� 5/      $
��0.2* �6$   64   �� 50      $
��0.1* �6$   64   �� 51      $
��0.2* �6$   64   �� 52      $
��0.1* �6$   64   �� 53      $
��0.2* �6$   64   �� 54      $
��0.1* �6$   64   �� 55      $
��0.2* �6$   64   .+�58      �� $��0��6   $��Általános��6%   $��20(�69   $��SemiBold"�6G   $��Bottom=�6]   $��15 0 0 0q�6x   6�   �� 59      $��1��6    !  MaterialDesignOutlinedTextBox#��[  6'   $��20(�6^   $
��15 5q�6l   $	��950��6z   	 �� TextWrapping$
	 Wrap=�5:      "
 �� VerticalScrollBarVisibility$

 Auto=�6.   $	��100��6Q   $��5q�6^    J� IsHitTestVisible$ False��6j   .��6�   ��Ezen a felületen lehet megtekinteni a nyilvántartásba vett betegek listáját, valamint azoknak adatait a megfelelő oszlopban feltüntetve. Egy adott betegre rákattintva megjelenik a páciens összes adata egy külön szerkeszthető felületen. Itt kitölthető a diagnózis is, illetve törölhető a páciens a nyilvántartásból.5>      �� 5@      $��2��6   $
��Név��6%   $��20(�63   $��SemiBold"�6A   $��Bottom=�6W   $��15 0 0 0q�6r   6�   �� 5A      $��3��6   #��[  6'   $��20(�6^   $
��15 5q�6l   $	��950��6z   $
	 Wrap=�5B      $

 Auto=�6.   $	��100��6Q   $��5q�6^   $ False��6j   .��6�   ��A rendszer csakis valósnak tekinthető vezeték- és keresztnevet fogad el. Mindkét mező alatt feltüntetésre került egy példa, amely formának meg kell felelni. Ennek függvényében tehát a "Kovács József" elfogadható, míg a "kovács józsef" nem. Elírás esetén a név szerkeszthető.5E      �� 5G      $��4��6   $��Születési dátum��6%   $��20(�6?   $��SemiBold"�6M   $��Center=�6c   $��15,0,0,0q�6~   $��2��6�   6�   �� 5H      $��5��6   #��[  6'   $��20(�6^   $��	16,5,17,5q�6l   $	��950��6   $
	 Wrap=�5I      $

 Auto=�6.   $	��100��6Q   $��5q�6^   $ False��6j   $��2��6�   .��6�   ��A születési dátum mezőben tölthető ki a páciens születési dátuma "ÉÉÉÉ. HH. NN." formátumban. A rendszer ebből kiszámolja a páciens életkorát, melyet felhasznál a gyógyszer felírásnál. A dátum begépelhető és ki is választható a naptárból, illetve elírás esetén később szerkeszthető.5L      �� 5N      $��6��6   $��Lakcím��6%   $��20(�66   $��SemiBold"�6D   $��Bottom=�6Z   $��15 0 0 0q�6u   6�   �� 5O      $��7��6   #��[  6'   $��20(�6^   $
��15 5q�6l   $	��950��6z   $
	 Wrap=�5P      $

 Auto=�6.   $	��100��6Q   $��5q�6^   $ False��6j   .��6�   wuA lakcím mezőben megadható a páciens bejelentett tartózkodási helye. Elírás esetén a lakcím szerkeszthető.5R      �� 5T      $��8��6   $	��TAJ��6%   $��20(�63   $��SemiBold"�6A   $��Bottom=�6W   $��15 0 0 0q�6r   6�   �� 5U      $��9��6   #��[  6'   $��20(�6^   $
��15 5q�6l   $	��950��6z   $
	 Wrap=�5V      $

 Auto=�6.   $	��100��6Q   $��5q�6^   $ False��6j   .��6�   ��A rendszer csakis valósnak tekinthető TAJ számot fogad el. A mező alatt feltüntetésre került egy példa, amely formának meg kell felelni. Ennek függvényében tehát a "000 000 000" elfogadható, míg a "000000000" nem. Elírás esetén a TAJ szám szerkeszthető.5Y      �� 5[      $��10��6   $��Allergia��6&   $��20(�69   $��SemiBold"�6G   $��Bottom=�6]   $��15 0 0 0q�6x   6�   �� 5\      $��11��6   #��[  6(   $��20(�6_   $
��15 5q�6m   $	��950��6{   $
	 Wrap=�5]      $

 Auto=�6.   $	��100��6Q   $��5q�6^   $ False��6j   .��6�   ��Az allergia mezőben megadhatóak a beteg ismert gyógyszerallergiái, melyet a rendszer később felhasznál a gyógyszer felírásnál. Fontos, hogy a hatóanyag magyarul és csupa kisbetűvel írodjon. Felsorolás esetén pedig ", " válassza el az egyes hatóanyagokat. Ennek megfelelően helyes: "amoxicillin, lidokain".5a      �� 5c      $��12��6   $��
Diagnózis��6&   $��20(�6:   $��SemiBold"�6H   $��Bottom=�6^   $��15 0 0 0q�6y   6�   �� 5d      $��13��6   #��[  6(   $��20(�6_   $
��15 5q�6m   $	��950��6{   $
	 Wrap=�5e      $

 Auto=�6.   $	��100��6Q   $��5q�6^   $ False��6j   .��6�   ��A diagnózis mezőben feltüntethető a beteg kezelésének eredménye. Itt kerül bejegyzésre az orvos által felállított kórmegállapítás. Későbbi eredmények esetén pedig bővíthető, illetve szerkeszthető.5h      �� 5j      $��14��6   $��Mentés, törlés��6&   $��20(�6?   $��SemiBold"�6M   $��Bottom=�6c   $��15 0 0 0q�6~   6�   �� 5k      $��15��6   #��[  6(   $��20(�6_   $
��15 5q�6m   $	��950��6{   $
	 Wrap=�5l      $

 Auto=�6.   $	��100��6Q   $��5q�6^   $ False��6j   .��6�   ��Változtatások esetén a "Mentés" gomb lenyomása szükséges, amely azonnal frissíti az összes megváltoztatott adatot. A "Törlés" gomb lenyomás minden adatot töröl, amely az adott beteghez tartozik, ez végleges és nem visszaállítható!5o      5p      5q      �� 5r   
   $��2��6   .+�5s      �� -   5        $��3��5s      $	��150��6"   $��20q�6.   $��	Bezárás��6:   6h   5t      5u      5v      