   M S B A M L   `   `   `  ����C  ?ClientUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ClientUI.ViewsClientUI.Views  5      *    $ClientUI.Views.CompetitionsTableView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ClientUI.Views     5      .��5	      � 
������   � RowDefinitions  5
   
   �� 5      $
��100* �6   6,   �� 5      $
��650* �6   6,   �� 5      $
��350* �6   6,   .+�5   
   � 
���   � J� Opacity$	 0.8Q�6"   $��0��60   .+�5      �� $��Competitions��6   $	��Top=�6,   $��Center=�6D   
�������$��Italic$�6u   $��Aharoni)�6�   $��22(�6�   5      � 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ tabela��5         AutoGenerateColumns .     
IsReadOnly .    RowBackground
 �����   CanUserAddRows .  ���#87CEFA$	 0.8Q�6  $	��500��6'  ��6p   ��  �� Path$ Competitions� �� UpdateSourceTrigger$ PropertyChanged=�	 �� SelectedItem	 6�   �� *SelectedCompetition+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6v   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	ID_COMP+$ PropertyChanged=�6v     5      $
 Name��6)   $ * 6U    67   �� *	NAME_COMP+6U     5      $ 
Start date��6)   $ * 6v    6=   �� *
DATE_START+ �� StringFormat$ 
dd.MM.yyyy��6v     5      $ End date��6)   $ * 6r    6;   �� *
DATE_END+$ 
dd.MM.yyyy��6r     5      $ Max competitors��6)   $ * 6f    6B   �� *MAX_COMPETITORS+6f   5!      5"      �� 5#   
    �� Orientation$ 
Horizontal=�6   $��2��6.   ���	#993E3EE8.+�5$      �� $��2��6   .+�5%      �� 
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Name:6h   �� 5&      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Start date:6n   �� 5'      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   	End date:6l   �� 5(      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Max competitors:6s   5)      �� 5*      $��2��6   .+�5+      �� $	��100��6   $��8q�6N   $	��200��6Y   ��6*   �� *NameTB+ �� Mode$ TwoWay=�6j   (  "System.Windows.Controls.DatePicker  5,      $��4q�6      SelectedDate 6*   �� *StartDateDP+$ TwoWay=� � 	Resources 5-      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%[   '        �� 5.      "  6    .�5/      ��  �@��
IsReadOnly . 6;   50      51      52        53      $��4q�6    6)   �� *	EndDateDP+$ TwoWay=� 54      ��%[   '        �� 55      "  6    .�56      ��  �@��
IsReadOnly . 6;   57      58      59      �� 5:      -   5        $	��100��5:      $��8q�6}   $	��200��6�   ��6*   �� *MaxCompetitorsTB+$ TwoWay=�6�   5;      5=      �� 5>   
   -   5         ��Name$ AddBtn��5>      $��Add new��6!   $
��Left=�63   $��	372,9,0,0q�6N   $��2��6a   $	��Top=�6n   $	��102��6�   ���	#993E3EE8���	#FFFAFB79��6�   �� *
AddCommand+�� 5?   
   -   5        $ 	ModifyBtn��5?      $��Modify selected��6$   $
��Left=�6>   $��
372,34,0,0q�6Y   $��2��6m   $	��Top=�6z   $	��102��6�   ���	#993E3EE8���	#FFFAFB79��6�   �� *ModifyCommand+�� 5@   
   -   5        $ 	DeleteBtn��5@      $��Delete selected��6$   $
��Left=�6>   $��
372,59,0,0q�6Y   $��2��6m   $	��Top=�6z   $	��102��6�   ���	#993E3EE8���	#FFFAFB79��6�   �� *DeleteCommand+5A      5B      