   M S B A M L   `   `   `  ����C  ?ClientUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ClientUI.ViewsClientUI.Views  5      *    $ClientUI.Views.ReservationsTableView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ClientUI.Views     5      .��5	      � 
������   � RowDefinitions  5
   
   �� 5      $
��100* �6   6,   �� 5      $
��650* �6   6,   �� 5      $
��350* �6   6,   .+�5   
   � 
���   � J� Opacity$	 0.8Q�6"   $��0��60   .+�5      �� $��Hall reservations��6   $	��Top=�61   $��Center=�6I   
�������$��Italic$�6z   $��Aharoni)�6�   $��22(�6�   5      � 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ tabela��5         AutoGenerateColumns .     
IsReadOnly .    RowBackground
 �����   CanUserAddRows .  ���#87CEFA$	 0.8Q�6  $	��500��6'  ��6p   ��  �� Path$ Reservations� �� UpdateSourceTrigger$ PropertyChanged=�	 �� SelectedItem	 6�   �� *SelectedReservation+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ PerformanceHall ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *PerformanceHallID_HALL+$ PropertyChanged=�6�     5      $ PerformanceHall Name��6)   $ * 6�    6G   �� *PerformanceHall.NAME_HALL+$ PropertyChanged=�6�     5      $ Competition ID��6)   $ * 6�    6A   �� *OrganizeCompetitionID_COMP+$ PropertyChanged=�6�     5      $ Competition Name��6)   $ * 6v    6C   �� * Organize.Competition.NAME_COMP+6v     5      $ Publishing House ID��6)   $ * 6w    6F   �� *OrganizePublishingHouseID_PH+6w     5      $ Publishing House Name��6)   $ * 6}    6H   �� *" Organize.PublishingHouse.NAME_PH+6}     5      $ 
Start time��6)   $ * 6\    6=   �� *
START_TIME+6\     5      $ End time��6)   $ * 6X    6;   �� *
END_TIME+6X     5      $ Reservation date��6)   $
 auto 6z    6C   �� *
DATE_RES+ �� StringFormat$ 
dd.MM.yyyy��6z   5$      5%      �� 5&   
    �� Orientation$ 
Horizontal=�6   $��2��6.   ���	#993E3EE8.+�5'      �� $��2��6   .+�5(      �� 
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   PublishingHouse ID:6v   �� 5)      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Competition ID:6r   �� 5*      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Performance Hall ID:6w   �� 5+      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Reservation date:6t   �� 5,      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Start time:6n   �� 5-      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   	End time:6l   5.      �� 5/      $��2��6   .+�50      �� -   5         ��Name$ CompetitorCB��50   -    �� 
IsEditable . $��4q�6C   $	��150��6N   ��6Z   �� *PublishingHouseStrings+ �� Mode$ TwoWay=�$ PropertyChanged=�	 6�   �� *SelectedPublishingHouse+6�   �� 51      -   5        $	 SCB��51   -    . $��4q�6:   ��6E   �� *CompetitionStrings+$ TwoWay=�$ PropertyChanged=�	 6�   �� *SelectedCompetition+6�   �� 52      -   5        $	 DCB��52   -    . $��5q�6:   ��6E   �� *PerformanceHallStrings+$ TwoWay=�$ PropertyChanged=�	 6�   �� *SelectedPerformanceHall+6�   (  "System.Windows.Controls.DatePicker  53      $��5q�6      SelectedDate 6*   �� *ReservationDP+$ TwoWay=� � 	Resources 54      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%[   '        �� 55      "  6    .�56      ��  �@��
IsReadOnly . 6;   57      58      59      �� 5:      $ 
Horizontal=�6   .+�5;      �� -   5        $��StartTimeHoursTB��5;       �� 	MaxLength$ 2��66   $��30��6D   $��7q�6�   $	��200��6�   ��6O   �� *StartTimeHoursTB+$ TwoWay=�6�   �� 5<      
�������$��Italic$�6/   $��Aharoni)�6B   $��30(�6W   .��6e   :6h   �� 5=      -   5        $��StartTimeMinutesTB��5=      $ 2��68   $��30��6F   $��7q�6�   $	��200��6�   ��6Q   �� *StartTimeMinutesTB+$ TwoWay=�6�   5>      �� 5?      $ 
Horizontal=�6   .+�5@      �� -   5         ��Name$ EndTimeHoursTB��5@      $ 2��66   $��30��6E   $��7q�6�   $	��200��6�   ��6P   �� *EndTimeHoursTB+$ TwoWay=�6�   �� 5A      
�������$��Italic$�6/   $��Aharoni)�6B   $��30(�6W   .��6e   :6h   �� 5B      -   5        $ EndTimeMinutesTB��5B      $ 2��68   $��30��6F   $��7q�6�   $	��200��6�   ��6Q   �� *EndTimeMinutesTB+$ TwoWay=�6�   5C      5D      5F      �� 5G   
   -	   5         ��Name$ AddBtn��5G      $��Add new��6!   $
��Left=�63   $��	372,9,0,0q�6N   $��2��6a   $	��Top=�6n   $	��102��6�   ���	#993E3EE8���	#FFFAFB79��6�   �� *
AddCommand+�� 5H   
   -
   5        $ 	ModifyBtn��5H      $��Modify selected��6$   $
��Left=�6>   $��
372,34,0,0q�6Y   $��2��6m   $	��Top=�6z   $	��102��6�   ���	#993E3EE8���	#FFFAFB79��6�   �� *ModifyCommand+�� 5I   
   -   5        $ 	DeleteBtn��5I      $��Delete selected��6$   $
��Left=�6>   $��
372,59,0,0q�6Y   $��2��6m   $	��Top=�6z   $	��102��6�   ���	#993E3EE8���	#FFFAFB79��6�   �� *DeleteCommand+5J      5K      