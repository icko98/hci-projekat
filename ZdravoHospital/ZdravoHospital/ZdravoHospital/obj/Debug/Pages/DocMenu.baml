   M S B A M L   `   `   `  ����I  EZdravoHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ZdravoHospital.PagesZdravoHospital.Pages  5      "    ZdravoHospital.Pages.DocMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ZdravoHospital.Pages     5      $	��350��5        N� Title$  DocMenu��5	      $	��300��6   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��appTable��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   ���#C7D36F���#FCF9C6$	��214��6�   $��	6,19,10,0q�6�   $	��Top=�6�      AutoGenerateColumns .     
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .  $��1��6a  $��4��6n     RowBackground �	#FFC7D36F��6#   ��  �� Path$ Xapps�	 �� Mode$	 TwoWay=�
 �� SelectedItem
 6S   �� $ SelectedApp�$	 TwoWay=� � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%a   '        7 �� 5      8   "  6Q   .�5      ��  � �� �#9EB23B63   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	PatientID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	PatientID+  5      $
 Date��6%    63   �� *Dt+  5      $ Duration��6%    67   �� *
Duration+5       �� 5!   
   -   5        $	��Add��5!      $
��Left=�6   $��6,49,0,0q�6:   $	��Top=�6L   $��65��6d   ���#FCF9C6���	#FF9EB23B$��37��6�   $��2��6�    5"      ��%_   '��       �� 5#      " ��6   .�5$      ��  �@��CornerRadius$ 20��65   5%      5&      5'      �� 5(   
   -   5        $
��Edit��5(      $
��Left=�6    $	��Top=�6;   $��65��6S   ���#FCF9C6���#EF9F9F$��37��6�   $��
220,49,0,0q�6�   $��2��6�    5)      ��%_   '��       �� 5*      " ��6   .�5+      ��  �@��CornerRadius$ 20��65   5,      5-      5.      �� 5/   
   -   5        $��Delete��5/      ���	#FFA01818���#FCF9C6$
��Left=�6N   $��	75,49,0,0q�6i   $	��Top=�6|   $��65��6�   $��36��6�   $��2��6�    50      ��%_   '��       �� 51      " ��6   .�52      ��  �@��CornerRadius$ 20��65   53      54      55      �� 56   
   -   5        $
��File��56      $
��Left=�6    $��
150,49,0,0q�6;   ���#FCF9C6���#827397$	��Top=�6y   $��65��6�   $��37��6�    J� RenderTransformOrigin$ 
0.49,0.434&�6�   $��2��6�    57      ��%_   '��       �� 58      " ��6   .�59      ��  �@��CornerRadius$ 20��65   5:      5;      5<      �� 5=   
   $��Button za novu f��6   $
��Left=�6,   $��	94,28,0,0q�6G   $��4��6Z   $	��Top=�6g   $��32��6   $��90��6�    5>      ��%_   '��       �� 5?      " ��6   .�5@      ��  �@��CornerRadius$ 20��65   5A      5B      5C      �� 5D   
   $��       Schedule for today��6   $��Center=�64   $	��Top=�6Q   $	��293��6i   $��36��6u   $��22(�6�   5G      5H      