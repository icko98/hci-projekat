   M S B A M L   `   `   `  ����I  EZdravoHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZdravoHospital.WindowsZdravoHospital.Windows  5   	   &     ZdravoHospital.Windows.CreateApp   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ZdravoHospital.Windows     5   	     � Title$  	CreateApp��5   	   $	��450��6   $	��800��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��20(�6   $��	PatientId��6   $
��Left=�62   $��78,0,0,0q�6M   $��Center=�6_   $��50��6z   $	��132��6�    J� RenderTransformOrigin$ -0.057,0.57&�6�   �� 5   
   $��20(�6   $
��Date��6   $��Center=�6-   $��Center=�6J   $��44��6e   $��64��6q   $ 0.446,1.891&�6|   $��1��6�   �� 5   
   $��20(�6   $��Duration��6   $
��Left=�61   $��86,0,0,0q�6L   $��Center=�6^   $��50��6y   $	��116��6�   $��2��6�   �� 5   
   -   5        $	��PId��5      $��1��6   $��Center=�6-   $��50��6J    �� TextWrapping$
 Wrap=�6V   $��Center=�6j   $	��245��6�   �� 5   
   -   5        $��Duration��5      $��1��6"   $��Center=�62   $��50��6O   $
 Wrap=�6[   $��Center=�6o   $	��245��6�   $��2��6�   �� 5   
   -   5        $��No��5      $
��Left=�6   $��143,9.6,0,0q�69   $��5��6N   $	��Top=�6[   $��99��6s   $��50��6~   6�   �� 5   
   -   5        $��	ButtonYes��5      $	��Yes��6   $
��Left=�60   $��27.4,9.6,0,0q�6K   $��5��6a   $	��Top=�6n   $	��101��6�   $��2��6�   $��50��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $	��nzm��5      $��1��6!   $��Center=�61   $��0,17,0,0q�6N   $��1��6`   $	��Top=�6m   $��63��6�   $	��245��6�   $ 0.199,0.651&�6�      FirstDayOfWeek$ 	Wednesday=�6�      Text$
 SELE��6�   5      5       