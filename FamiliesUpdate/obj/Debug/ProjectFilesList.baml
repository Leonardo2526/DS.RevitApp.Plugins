   M S B A M L   `   `   `  ����  DS.FamiliesUpdate1    +DS.RevitApp.FamiliesUpdate.ProjectFilesList   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � Title$  
Files list��5       � WindowStartupLocation$ CenterScreen=�6!   $	��400��6F   $	��800��6S   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      �� 5      $��30 �6   �� 5      $��70 �6   .+�5   
   �� $��0��6   $+��%Files have been found in this folder:��6   �� 5   
   -   5         ��Name$ 	FilesList��5   8   $��1��6   $	��Top=�6   
������� �� SelectionMode$ Multiple=�5      5      �� 5   
   $��2��6   $��Select files for work.��6   
���  ��6>   �� 5   
   $��3��6    �� Orientation$ 
Horizontal=�6#   $��0,0,0,0q�6<   $��Bottom=�6M   $��70��6h   .+�5      �� -   5         ��Name$ ApplySelection��5      $��Apply selected��6.   $��
10,10,0,10q�6d   $��10q�6x   $��40��6�   
����ح�6�   �� 5      -   5        $ ApplyAllSelection��5      $��
Select all��60   $��
10,10,0,10q�6e   $��10q�6y   $��40��6�   
����ح�6�   5      5      5      