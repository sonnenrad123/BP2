   M S B A M L   `   `   `  ����C  ?ClientUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ClientUI.ViewsClientUI.Views  5      /    )ClientUI.Views.MusicPerformancesTableView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ClientUI.Views     5      .��5	      � 
������   � RowDefinitions  5
   
   �� 5      $
��100* �6   6,   �� 5      $
��650* �6   6,   �� 5      $
��350* �6   6,   .+�5   
   � 
���   � J� Opacity$	 0.8Q�6"   $��0��60   .+�5      �� $��Music Performances��6   $	��Top=�62   $��Center=�6J   
�������$��Italic$�6{   $��Aharoni)�6�   $��22(�6�   5      � 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ tabela��5         AutoGenerateColumns .     
IsReadOnly .    RowBackground
 �����   CanUserAddRows .  ���#87CEFA$	 0.8Q�6$  $	��500��62  ��6p   ��  �� Path$ MusicPerformances� �� UpdateSourceTrigger$ PropertyChanged=�	 �� SelectedItem	 6�   �� *SelectedMusicPerformance+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.2* 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	ID_PERF+6Q     5      $ Original performer��6)   $ * 6h    6E   �� *ORIG_PERFORMER+6h     5      $ 	Song name��6)   $ * 6Z    6<   �� *	SONG_NAME+6Z     5      $ Song author��6)   $ * 6^    6>   �� *SONG_AUTHOR+6^     5      $
 Date��6)   $ * 6o    67   �� *	DATE_PERF+ �� StringFormat$ 
dd.MM.yyyy��6o     5      $ Competitor JMBG��6)   $ * 6t    6B   �� *CompetitingCompetitorJMBG_SIN+6t     5      $ Competition ID��6)   $ * 6s    6A   �� *CompetitingCompetitionID_COMP+6s     5      $ Genre��6)   $ * 6]    68   �� *Genre.GENRE_NAME+6]   5$      5%      �� 5&   
    �� Orientation$ 
Horizontal=�6   $��2��6.   ���	#993E3EE8.+�5'      �� $��2��6   .+�5(      �� 
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Original performer:6v   �� 5)      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   
Song name:6m   �� 5*      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Song author:6o   �� 5+      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Date:6h   �� 5,      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Competitor:6n   �� 5-      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Competition:6o   �� 5.      
�������$��Italic$�6+   $��Aharoni)�6>   $��18(�6S   .��6a   Genre:6i   50      �� 51      $��2��6   .+�52      �� $	��100��6   $��7q�6S   $	��200��6^   ��6*   �� *
OrigPerfTB+ �� Mode$ TwoWay=�6o   �� 53      $	��100��6   $��7q�6S   $	��200��6^   ��6*   �� *
SongNameTB+$ TwoWay=�6o   �� 54      $	��100��6   $��7q�6U   $	��200��6`   ��6*   �� *SongAuthorTB+$ TwoWay=�6q   (  "System.Windows.Controls.DatePicker  55      $��4q�6      SelectedDate 6*   �� *DateDP+$ TwoWay=� � 	Resources 56      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%[   '        �� 57      "  6    .�58      ��  �@��
IsReadOnly . 6;   59      5:      5;      �� 5<      -   5         ��Name$ CompetitorCB��5<      $��4q�61   ��6<   �� *CompetitorStrings+$ TwoWay=�$ PropertyChanged=�	 6�   �� *SelectedCompetitor+6�   �� 5=      -   5        $ CompetitionCB��5=      $��4q�62   ��6=   �� *CompetitionStrings+$ TwoWay=�$ PropertyChanged=�	 6�   �� *SelectedCompetition+6�   �� 5>      -   5        $ GenrerCB��5>      $��4q�6-   ��68   �� *GenreStrings+$ TwoWay=�$ PropertyChanged=�	 6�   �� *SelectedGenre+6�   5A      5C      �� 5D   
   -   5         ��Name$ AddBtn��5D      $��Add new��6!   $
��Left=�63   $��	372,9,0,0q�6N   $��2��6a   $	��Top=�6n   $��93��6�   ���	#993E3EE8���	#FFFAFB79��6�   �� *
AddCommand+�� 5E   
   -   5        $ 	ModifyBtn��5E      $��Modify selected��6$   $
��Left=�6>   $��
372,34,0,0q�6Y   $��2��6m   $	��Top=�6z   $��93��6�   ���	#993E3EE8���	#FFFAFB79��6�   �� *ModifyCommand+�� 5F   
   -   5        $ 	DeleteBtn��5F      $��Delete selected��6$   $
��Left=�6>   $��
372,59,0,0q�6Y   $��2��6m   $	��Top=�6z   $��93��6�   ���	#993E3EE8���	#FFFAFB79��6�   �� *DeleteCommand+5G      5H      