   M S B A M L   `   `   `  ����G  CGeographyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GeographyAppGeographyApp  5          GeographyApp.FlagModePage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:GeographyApp     5        N� 
Background
  ��ح� N� Title$ FlagModePage��5	      .��5      � .+�5   
   � $��230,0,230,70q�6    � RowDefinitions 5      �� 5      $��3* �6    6.   �� 5      $��1* �6    6.   .+�5      �� $��0��6    �� CornerRadius$ 6��6"   $��0, 50, 0, 0q�63   
���   �
�������$��2q�6o   ._�5      �� -   5         ��Name$ FlagDisplay��5      $��Uniform=�6-   $%��/Photos/Flags/Africa/Gambia.png��6@   6k   5      � 5      $��1��6    � ColumnDefinitions 5      �� 5      $��5* �6'   64   �� 5      $��1* �6'   64   .+�5      �� $��0��6   $��5, 30, 10, 30q�6)   
���   �
�������$��2q�6g   ._�5      �� -   5         ��Name$ FlagGuessBox��5      $
{�True��64   $��Center=�6E   $��30��6`   $��19(�6o   $��Enter Country Name...��6}   
�������6�   5      �� 5       $��1��6   $��0, 25, 5, 25q�6)   
���   �$ 8��6S   
�������$��2q�6w   ._�5!      �� $��Guess��6   $��0q�6-   
������ $��2q�6Z   5#      5$      5%      5&      5'      5(      