   M S B A M L   `   `   `  ����C  ?ClientUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ClientUI.ViewsClientUI.Views  5      %    ClientUI.Views.SingersTableView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ClientUI.Views     5      .��5
   
   �   � RowDefinitions  5      �� 5      $
��100* �6    60   �� 5      $
��650* �6    60   �� 5      $
��350* �6    60   .+�5      � 
���   � J� Opacity$	 0.8Q�6&   $��0��64   .+�5      �� $��All singers��6   $	��Top=�6/   $��Center=�6G   
�������$��Italic$�6x   $��Aharoni)�6�   $��22(�6�   5      � 5      $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ tabela��5         AutoGenerateColumns .     
IsReadOnly .    RowBackground
 �����   CanUserAddRows .  ���#87CEFA$	 0.8Q�6  $	��500��6&  ��6t   ��  �� Path$ Singers� �� UpdateSourceTrigger$ PropertyChanged=�	 �� SelectedItem	 6�   �� *SelectedCompetitor+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 JMBG��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6|   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
JMBG_SIN+$ PropertyChanged=�6|     5      $ 
First Name��6-   $ * 6c    6A   �� *FIRSTNAME_SIN+6c     5      $ 	Last Name��6-   $ * 6a    6@   �� *LASTNAME_SIN+6a     5      $ Date of birth��6-   $ * 6�    6D   �� *BIRTHDATE_SIN+ �� StringFormat$ 
dd.MM.yyyy��6�     5      $ Email��6-   $ * 6Z    6<   �� *	EMAIL_SIN+6Z     5      $ 	Phone No.��6-   $ * 6a    6@   �� *PHONE_NO_SIN+6a     5      $ Address��6-   $ * 6^    6>   �� *ADDRESS_SIN+6^     5       $ Competitor/Jury Member��6-   $
 auto 6f    6M   �� *Type+6f   5#      5$      5)      5+      