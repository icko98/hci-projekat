   M S B A M L   `   `   `  ����I  EZdravoHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ZdravoHospital.PagesZdravoHospital.Pages  5          ZdravoHospital.Pages.Meds   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ZdravoHospital.Pages     5        N� Title$
  Meds��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ TBAmeds��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $	��116��6�   $��
2,26,100,0q�6�   $	��Top=�6�      AutoGenerateColumns .     
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .  ���#C7D36F���#FCF9C6   RowBackground �	#FFC7D36F��6$   �� *TBAmedication+ �� Mode$ TwoWay=�	 �� SelectedItem	 6W   �� *SelectedMed+$ TwoWay=�
 � 	Resources
 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%a   '        7 �� 5      8   "  6Q   .�5      ��  � �� �#9EB23B63   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+5        5   
   -   5        $ CMeds��5      $ * 6�   $	��137��6�   $��2,183,100,0q�6�   $	��Top=�6�    .   .  .   .  ���#C7D36F���#FCF9C6 �	#FFC7D36F��6"   �� *CMedication+$ TwoWay=�	 6S   �� *SelectedMed2+$ TwoWay=�
 5      ��%a   '        7 �� 5      8   "  6Q   .�5      ��  � �� �#9EB23B63   5      5       5        5!      $
 Name��6%    63   �� *Name+5$      �� 5%   
   -   5        $��Accept��5%      $
��Left=�6"   $��
217,59,0,0q�6=   ���	#FF9EB23B$��50��6h   ���#FCF9C6$	��Top=�6�   $��66��6�   
 5&      ��%_   '��       �� 5'      " ��6   .�5(      ��  �@��CornerRadius$ 20��65   5)      5*      5+      �� 5,   
   $/��)Medication waiting on doctor confirmation��6   $��Center=�6E   $	��Top=�6b    J� RenderTransformOrigin$ 0.692,0.561&�6z   $	��236��6�   �� 5-   
   $��Confirmed medication��6   $
��Left=�60   $��
88,147,0,0q�6K   $	��Top=�6_   $ 0.692,0.561&�6w   $	��237��6�   5/      50      