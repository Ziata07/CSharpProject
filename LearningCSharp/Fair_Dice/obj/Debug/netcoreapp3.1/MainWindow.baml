   M S B A M L   `   `   `  ����D  @Fair_Dice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Fair_Dice	Fair_Dice  5   	       Fair_Dice.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Fair_Dice     5   	     � Title$  Fair Dice Game��5   	   $	��362��6    $	��643��6-   .��5	      � $��Center=�6   $��Center=�6(    � ColumnDefinitions 5
   
   �� 5      $
��192* �6   �� 5      $
��451* �6   .+�5   
   �� -   5         ��Name$ Player_Name_Label��5      $��	Player(s)��6+   $
��Left=�6?   $��
10,105,0,0q�6Z   $	��Top=�6n   $
��Left=�6�   $	��Top=�6�   $��26��6�   $��54��6�   �� 5   
   -   5         ��Name$ rollDieButton��5      $��Click to Roll��6(   $
��Left=�6@   $��
40,233,0,0q�6[   $	��Top=�6o   $��1��6�   $��20��6�   $��66��6�   �� 5   
   -   5        $ resultsLabel��5      $�� ��6&   $
��Left=�61   $��49��6L   $��
31,156,0,0q�6X   $	��Top=�6l   $��75��6�   $��Center=�6�   $��Center=�6�   ���	#FF2C2B2B$��1,1,1,1q�6�   $��1��6  �� 5   
   -   5         ��Name$ totalPlayersTextBox��5      $
��Left=�6/   $��	58,20,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $��35��6�   $��32��6�   $��1��6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        $ TotalPlayersLabel��5      $#��How many players are playing:��6+   $
��Left=�6S   $��0,14,0,0q�6n   $	��Top=�6�   $��44��6�   $
��Left=�6�   $��Center=�6�   ${�False��6�   $
��Bold"�6�   $��Normal$�6  $	��184��6  �� 5   
   -   5        $ confirmPlayersButton��5      $��Click to Confirm��6/   $
��Left=�6J   $��	31,63,0,0q�6e   $	��Top=�6x   $��1��6�   $��20��6�   $��89��6�   �� 5   
   -   5         ��Name$ 
PlayerList��5      $��64,118,32,0q�6'   $	��Top=�6<    � UseLayoutRounding$
 True��6T   $	��135��6m   	 �� View	 5      �� 5      .P�5      �� 5      5      5      5      