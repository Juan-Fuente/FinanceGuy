   M S B A M L   `   `   `  ����F  BProjectCSv2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ProjectCS	ProjectCS  5   	       ProjectCS.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ProjectCS     5   	   -   5          � Title$  FinanceGuyGrid��5      $��651.09��6   $��1115.123��6,    � WindowStartupLocation$ CenterScreen=�6T   .��5
      � -   5         �Name$ FinanceGuyGrid��5
      ���	#FFCCCAD1.+�5   
   �� -   5         ��Name$ foodComboBox��5      $
��Left=�6+   $��
43,150,0,0q�6H   $	��Top=�6^   $	��120��6x   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ itemsDataGrid��5      $
��Left=�6,   $	��378��6I   $��
486,24,0,0q�6X   $	��Top=�6n   $	��589��6�    J� RenderTransformOrigin$ 0.527,-0.105&�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property	 �� Value��%�   '        �� 5      "  6   .�5      ��  � ��
	 �  ��65   �� 5       � ��$	 SemiBold"�65   �� 5       � ��$	 0,0,1,2q�6:   �� 5       � ��
	 �   �66   5      5      
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+6R     5      $ 	 Category��6%   $ * 6Y    6:   �� *
Category+6Y     5      $ 	 Quantity��6%   $ * 6Y    6:   �� *
Quantity+6Y     5      $  Price��6%   $ * 6S    67   �� *Price+6S   5      �� 5%   
   -   5        $ billsComboBox��5%      $
��Left=�6,   $��255,150,0,0q�6I   $	��Top=�6`   $	��120��6z   6�   �� 5&   
   -   5        $ subsComboBox��5&      $
��Left=�6+   $��
43,352,0,0q�6H   $	��Top=�6^   $	��120��6x   6�   �� 5'   
   -   5        $ outingsComboBox��5'      $
��Left=�6.   $��255,352,0,0q�6K   $	��Top=�6b   $	��120��6|   $ 0.525,-4.552&�6�   �� 5(   
   -   5         ��Name$ spider��5(      $�� ��6    $
��Left=�6+   $��163,224,0,0q�6F   $	��Top=�6[   $	��100��6s   �� 5)   
   -	   5         ��Name$ clearButton��5)      $��Clear��6(   $
��Left=�6:   $��220,540,0,0q�6W   $	��Top=�6n   $	��155��6�   $��46��6�   $
��Bold"�6�   $��16(�6�   6�   �� 5*   
   $��Total:��6   $
��Left=�6#   $��495,477,0,0q�6@   $	��Top=�6W   $��16(�6q   �� 5+   
   -
   5         ��Name$ totalTextBlock��5+      $
��Left=�6.   $��547,482,0,0q�6K   $
��Wrap=�6b   $��$0.00��6x   $	��Top=�6�   $��16(�6�   $	��117��6�   
�������6�   �� 5,   
   $
��Tax:��6   $
��Left=�6!   $��495,431,0,0q�6>   $	��Top=�6U   $��16(�6o   �� 5-   
   -   5        $ taxBlock��5-      $
��Left=�6(   $��547,438,0,0q�6E   $
��Wrap=�6\   $��$0.00��6r   $	��Top=�6�   $��16(�6�   $	��117��6�   
�������6�   �� 5/   
   $��FinanceGuy!��6   $
��Left=�6(   $��
109,24,0,0q�6E   $	��Top=�6[   $
��Bold"�6u   $��36(�6�   $��Palatino Linotype)�6�   $��62��6�   $	��353��6�   ���	#FF0D55646�   �� 50   
   $
��Food��6   $
��Left=�6!   $��
54,116,0,0q�6>   $	��Top=�6T   $
��Bold"�6n   $��24(�6�   $��
Tekton Pro)�6�   $��34��6�   �� 51   
   $��Bills��6   $
��Left=�6"   $��267,116,0,0q�6?   $	��Top=�6V   $
��Bold"�6p   $��24(�6�   $��
Tekton Pro)�6�   $��34��6�   �� 52   
   $��Outings��6   $
��Left=�6$   $��267,318,0,0q�6A   $	��Top=�6X   $
��Bold"�6r   $��24(�6�   $��
Tekton Pro)�6�   $��34��6�   �� 53   
   $��Subscriptions��6   $
��Left=�6*   $��
34,318,0,0q�6G   $	��Top=�6]   $
��Bold"�6w   $��24(�6�   $��
Tekton Pro)�6�   $��34��6�   �� 54   
   -   5        $ CalendarEvents��54      $��Calendar Events��6(   $��741,420,0,0q�6B   $	��Top=�6W   $��36(�6o   $
��Bold"�6}   $ -0.111,4.251&�6�   $
��Left=�6�   �� 55   
   -   5        $ refresh��55      $��Clear��6$   $
��Left=�66   $��803,533,0,0q�6S   $	��Top=�6j   $	��155��6�   $��46��6�   $
��Bold"�6�   $��16(�6�   6�   �� 56   
   -   5        $ finishButton��56      $��Finish��6'   $
��Left=�68   $��
34,540,0,0q�6S   $	��Top=�6g   $	��155��6   $��46��6�   $
��Bold"�6�   $��16(�6�   6�   58      59      