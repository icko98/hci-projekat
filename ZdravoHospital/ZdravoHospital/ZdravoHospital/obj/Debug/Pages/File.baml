   M S B A M L   `   `   `  ����I  EZdravoHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ZdravoHospital.PagesZdravoHospital.Pages  5          ZdravoHospital.Pages.File   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ZdravoHospital.Pages     5      $	��350��5        N� Title$
  File��5	      .��5      � .+�5   
   �� ���	#FF9EB23B$��20(�6'   $
��JMBG��65   $
��Left=�6D   $��10,0,0,0q�6_   $	��Top=�6q   $��50��6�   $��79��6�    J� RenderTransformOrigin$ -0.057,0.57&�6�   �� 5   
   ���	#FF9EB23B$��20(�6'   $��Name
��65   $
��Left=�6I   $��	11,37,0,0q�6d   $	��Top=�6w   $��44��6�   $	��120��6�   $ 0.446,1.891&�6�   �� 5   
   ���	#FF9EB23B$��20(�6'   $��Surname
��65   $
��Left=�6L   $��	10,81,0,0q�6g   $	��Top=�6z   $��50��6�   $	��127��6�   �� 5   
   ���	#FF9EB23B$��20(�6'   $
��DOB
��65   $
��Left=�6H   $��
11,119,0,0q�6c   $	��Top=�6w   $��47��6�   $	��112��6�   �� 5   
   -   5         ��Name$	 tb1��5      $
��Left=�6    �� 
IsReadOnly . ���#C7D36F���	#FFFCF9C6$	��144��6z   $��37��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��0��6�   $��	131,0,0,0q�6�   �� 5   
   -   5        $	 tb2��5      $
��Left=�6    . ���#C7D36F���	#FFFCF9C6$	��144��6z   $��37��6�   $
 Wrap=�6�   $	��Top=�6�   $��
131,41,0,0q�6�   �� 5   
   -   5        $	 tb3��5      $
��Left=�6    . ���#C7D36F���	#FFFCF9C6$	��144��6z   $��37��6�   $
 Wrap=�6�   $	��Top=�6�   $��
131,82,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ repTable��5      ���#C7D36F���#FCF9C6   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $
��Left=�6�   $	��102��6�   $��
11,165,0,0q�6�   $	��Top=�6�   $	��264��6     AutoGenerateColumns .     
IsReadOnly . 	   CanUserResizeColumns	 .  
   CanUserResizeRows
 .     GridLinesVisibility$
 None=�6�     RowBackground �	#FFC7D36F��6%   �� *Xreps+ �� Mode$ TwoWay=� �� SelectedItem 6P   �� *SelectedReport+$ TwoWay=� � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%a   '        7 �� 5      8   "  6Q   .�5      ��  � �� �#9EB23B63   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%      Width$	 150 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Dt+6J     5      $ Description��6%   $	 100 6S      CanUserResize .   6:   �� *Desc+6_   5       �� 5!   
   -   5        $��Change report��5!      $
��Left=�6)   ���#FCF9C6���#EF9F9F$��
11,272,0,0q�6n   $	��Top=�6�   $��99��6�   $��30��6�   $ 0.482,0.555&�6�    5"      ��%_   '��       �� 5#      " ��6   .�5$      ��  �@��CornerRadius$ 20��65   5%      5&      5'      �� 5(   
   -   5        $��
Add report��5(      $
��Left=�6&   ���#FCF9C6���	#FF9EB23B$��175,272,0,0q�6m   $	��Top=�6�   $	��100��6�   $��30��6�    5)      ��%_   '��       �� 5*      " ��6   .�5+      ��  �@��CornerRadius$ 20��65   5,      5-      5.      �� 5/   
   -   5        $	 tb4��5/      $
��Left=�6   ���#C7D36F . ���	#FFFCF9C6$	��144��6z   $��37��6�   $
 Wrap=�6�   $	��Top=�6�   $��131,124,0,0q�6�   51      52      