   M S B A M L   `   `   `  ����I  EZdravoHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ZdravoHospital.PagesZdravoHospital.Pages  5      !    ZdravoHospital.Pages.addRep   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ZdravoHospital.Pages     5        N� Title$  addRep��5	      .��5      � .+�5   
   �� ���	#FF9EB23B$��20(�6'   $
��Date��65   $
��Left=�6D   $	��Top=�6_   $��44��6w   $��64��6�    J� RenderTransformOrigin$ 0.446,1.891&�6�   $��	10,10,0,0q�6�   �� 5   
   ���	#FF9EB23B$��20(�6'   $��Description��65   $
��Left=�6K   $��	10,76,0,0q�6f   $	��Top=�6y   $��36��6�   $	��116��6�   �� 5   
   -   5         ��Name$
 Desc��5      ���#C7D36F���	#FFFCF9C6$	��144��6L   $��74��6Y    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $
��Left=�6�   $��
146,57,0,0q�6�   �� 5   
   -   5        $��Delete report��5      $
��Left=�6)   ���	#FFA01818$��
10,262,0,0q�6[   $	��Top=�6o   ���#FCF9C6$	��101��6�   $��50��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 20��65   5      5      5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$	 nzm��5      $
��Left=�6#   $	��Top=�6>   $��36��6V   $	��144��6b   $ 0.199,0.651&�6n   ���#C7D36F	   FirstDayOfWeek$	 	Wednesday=�6�   
   Text$

 SELE��6�   $��
146,10,0,0q�6�   ���	#FF9EB23B6�   �� 5   
   -   5         ��Name$ 	ButtonYes��5   *   $��Confirm report��6   $��189,262,10,0q�6=   $	��Top=�6S   $	��101��6k   ���	#FF9EB23B$��50��6�   ���#FCF9C6$ 0.508,-0.439&�6�    5      ��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 20��65   5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��	persTable��5      $��146,129,10,97q�6T   ���#C7D36F���#FCF9C6$	��144��6�   $��74��6�      RowBackground �	#FFC7D36F   AutoGenerateColumns .     
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6-  ��6$   ��  �� Path$ Xpers� �� Mode$ TwoWay=� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%a   '        7 �� 5       8   "  6Q   .�5!      ��  � �� �#9EB23B63   5"      5#         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+5'      �� 5(   
   ���	#FF9EB23B$��20(�6(   $��Perscriptions��66   $
��Left=�6N   $��
10,131,0,0q�6i   $	��Top=�6}   $��50��6�   $	��122��6�   �� 5)   
   -   5        $��Add new medication��5)      $
��Left=�6.   ���	#FF9EB23B$��50��6`   ���#FCF9C6$��
12,168,0,0q�6�   $	��Top=�6�   $	��112��6�    5*      ��%_   '��       �� 5+      " ��6   .�5,      ��  �@��CornerRadius$ 20��65   5-      5.      5/      �� 50   
   ���#8CC0DE$��12(�6&   $\��VPress the "Add new medication" button to select 
new medication to add to the report.��64   $��Center=�6�   $��	0,218,0,0q�6�   $	��Top=�6�   $��50��6�   $	��278��6�   52      53      