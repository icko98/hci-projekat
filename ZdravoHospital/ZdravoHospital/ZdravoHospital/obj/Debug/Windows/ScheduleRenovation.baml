   M S B A M L   `   `   `  ����I  EZdravoHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZdravoHospital.WindowsZdravoHospital.Windows  5   	   /    )ZdravoHospital.Windows.ScheduleRenovation   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ZdravoHospital.Windows     5   	     � Title$  ScheduleRenovation��5   	   $	��450��6$   $	��800��61   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��20(�6   $��RoomId��6   $
��Left=�6/   $��	111,0,0,0q�6J   $��Center=�6]   $��50��6x   $��79��6�    J� RenderTransformOrigin$ -0.057,0.57&�6�   �� 5   
   $��20(�6   $��	StartDate��6   $
��Left=�62   $��
111,17,0,0q�6M   $	��Top=�6a   $��44��6y   $	��121��6�   $ 0.446,1.891&�6�   $��1��6�   �� 5   
   $��20(�6   $��EndDate��6   $
��Left=�60   $��
111,16,0,0q�6K   $	��Top=�6_   $��50��6w   $	��117��6�   $��2��6�   �� 5   
   $��20(�6   $��Description��6   $
��Left=�64   $��	111,0,0,0q�6O   $��Center=�6b   $��47��6}   $	��112��6�   $��3��6�   �� 5   
   -   5        $��RoomId��5      $��1��6    $��Center=�60   $��50��6M    �� TextWrapping$
 Wrap=�6Y   $��Center=�6m   $	��245��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��	StartDate��5      $��1��6'   $��Center=�67   $��0,17,0,0q�6T   $��1��6f   $	��Top=�6s   $��63��6�   $	��245��6�   $ 0.199,0.651&�6�      FirstDayOfWeek$ Monday=�6�      Text$
 SELE��6�     5   
   -   5        $��EndDate��5      $��1��6%   $��Center=�65   $��0,17,0,0q�6R   $��2��6d   $	��Top=�6q   $��63��6�   $	��245��6�   $ 0.199,0.651&�6�   $ Monday=�6�   $
 SELE��6�   �� 5   
   -   5        $��Description��5      $��1��6%   $
��Left=�65   $��50��6P   $��10.2,10.2,0,0q�6\   $
 Wrap=�6s   $	��Top=�6�   $	��245��6�   $��3��6�   6�   �� 5    
   -   5        $��No��5       $
��Left=�6   $��143,9.6,0,0q�69   $��5��6N   $	��Top=�6[   $��99��6s   $��50��6~   6�   �� 5!   
   -   5        $��	ButtonYes��5!      $	��Yes��6   $
��Left=�60   $��27.4,9.6,0,0q�6K   $��5��6a   $	��Top=�6n   $	��101��6�   $��2��6�   $��50��6�   6�   5#      5$      