   M S B A M L   `   `   `  ����  Accounts&     Accounts.Setup.ucControlAccounts   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        
������   � 	Resources  5         DataGridColumnHeaderStyle �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value �� 
TargetType �� EndPoint �� 
StartPoint � Color � Offset	 �� Padding��%�  &	        �� 5	   
   "  62   .�5
      ��  � �� �	#FF0000006+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$
 Left=�6;   �� 5       � ��$ Center=�69   �� 5       � �� .  6*   �� 5       �@ SeparatorBrush
 �����6/   �� 5       � ��$ 4q�6(   �� 5       � ��$ 0q�6'   �� 5       � ��$
 Auto��6&   �� 5       � �� 5      �� 5      "  6&   .R�5      �� ��5      �� 5   "   $	 0,1&�66   $	 0,0&�6E   .��5   &   � $ 	#FF3A60AD��63   $ 0.528Q�6E   � 5   &   $ 	#FF6A85D8��63   $
 0.01Q�6E   � 5   &   $ 	#FF3464C4��63   $ 1Q�6E   � 5   &   $ 	#FF202E7E��63   $ 1Q�6E   5   #   .+�5      �� $��0,0,1,0q�6%   ��5    "   �� 5!   &   $ 0.5,1&�6:   $ 0.5,0&�6K   .��5"   *   � $ White��67   $ 0.528Q�6E   � 5#   *   $ 	#FF3A60AD��67   $
 0.01Q�6I   � 5$   *   $ 	#FF202E7E��67   $ 1Q�6I   � 5%   *   $ White��67   $ 1Q�6E   5&   '   ._�5(   "   �� 
�������$	 5,3,5,5q�6P   $��Center=�6b   $��Center=�6   ��6,   �� 6   5)      5*      5+      5-      5.      5/      .��50      �� 
�����F�
 �� CornerRadius$
 5,5,5,5��6$   ._�51   
   �  � RowDefinitions 52      �� 53      $��35 �6    �� 54      $
��425* �6    �� 55      $��25 �6    �� 56      $��20 �6    .+�58      &   System.Windows.Controls.DataGrid  -   5        $��dgControlAccount��58   p   $��1��6      AutoGenerateColumns .  
�������   AlternatingRowBackground �	#FFC7D8EF   HorizontalGridLinesBrush
 ��  �   VerticalGridLinesBrush
 ��  �$   HorizontalScrollBarVisibility$
 Auto=�5:      "   VerticalScrollBarVisibility$
 Auto=�68      ColumnHeaderHeight$ 25Q�6[   $	��350��6s      CanUserAddRows .    CanUserDeleteRows .     CanUserResizeRows .     SelectionMode$ Single=�5;   ]      SelectionUnit$ FullRow=�6t    � DataContext 58   @   �� ��6X   ��    Columns 5<      4  .System.Windows.Controls.DataGridCheckBoxColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$	 ...��6h      
IsReadOnly .     Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   ��  �� Path$ 
IsSelected� �� TargetNullValue$ false��6�   0  *System.Windows.Controls.DataGridTextColumn  5>      $
 Name��6H    .  $	 250 6i    6)   �� $
 Name�6i   4  .System.Windows.Controls.DataGridComboBoxColumn  5?      -   5        cboGroup��$ Group Account��5?   ?    .      SelectedValuePath$  GroupId��6�   !   DisplayMemberPath$
! Name��6�   $	 150 6�   "   ItemsSource" 6i   �� #   SelectedValueBinding# 6�   �� $ �� Mode$$ TwoWay=�$ GroupId�6�     5@      $ Remarks��6K    .  $	 305 6o    6)   �� $ Remarks�6o   5B      ]� 5C      $��2��6   
�������$��Stretch=�68   $��Stretch=�6V   $��1,0,1,0q�6r   .+�5D      ]� $��Center=�6   $	��385��67   .+�5E      �� -   5        $��btnSelectAll��5E      $��
Select All��61   $��75��6F   6k   �� 5F      -   5        $��btnClearAll��5F      $��	Clear All��60   $��75��6D   6h   �� 5H      -   5        $��btnSave��5H      $
��Save��6,   $��75��6;   $��5,0,0,0q�6F   6o   �� 5I      -   5        $��	btnDelete��5I      $��Delete��6.   $��75��6?   6L   �� 5J      -   5        $��btnClose��5J      $��Close��6-   $��75��6=   $��5,0,0,0q�6H   6r   5K      5L      �� 5M      -	   5        $��lblName��5M   ^   $��Control Account��6   $��Stretch=�6/   $��0,6,0,0q�6M   $��Stretch=�6m   $	��748��6�   
�������$��Times New Roman)�6�   $
��Bold"�6�   $��20(�6�   $��Normal$�6�   % �� TextAlignment$% Center=�6�   5N      5O      5P      