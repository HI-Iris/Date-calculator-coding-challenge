   M S B A M L   `   `   `  ����I  EDateDifference, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DateDifferenceDateDifference  5   	       DateDifference.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DateDifference     5   	     � Title$  DateDifference��5   	   $	��350��6    $	��525��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   � -   5        $��
InputField��5      .+�5      �� -   5        $��	InputTabs��5      .@�5      �� $��Input the date��6   .��5      � .+�5      ��  �� Orientation$ Vertical=�6%   .+�5      �� -   5        $��	FirstDate��5   $   $!��Please enter the first date��65   6]   �� 5      -   5        $��FirstDateInput��5   &   $��
DD/MM/YYYY��6<    �� TextWrapping$
 Wrap=�6N   $	��120��6b   $
��Left=�6n   6�   �� 5      -   5        $��
SecondDate��5   $   $"��Please enter the second date��66   6_   �� 5      -   5        $��SecondDateInput��5   &   $��
DD/MM/YYYY��6=   $
 Wrap=�6O   $	��120��6c   $
��Left=�6o   6�   �� 5      -   5        $��CalculateInput��5   %   $
��Left=�6X   $��60��6s   $��24��6   $
��0,10q�6�   .��6�   	Calculate6�   5      5      5      �� 5      $��Upload the file��6   .��5      � .+�5      �� $ Vertical=�6%   .+�5      �� -   5        $��
UploadFile��5   $   $-��'Please select the date file (.txt only)��66   6j   �� 5       $ 
Horizontal=�6)   $
��0,10q�6B   .+�5!   "   �� -	   5        $��ReadFile��5!   )   $
��Left=�6Q   $��60��6l   $��24��6x   .��6�   Select6�   �� 5"   "   -
   5        $��FilePath��5"   *   $
 Wrap=�6:   $
��Left=�6N    �� 
IsReadOnly . $
��10,0q�6{   6�   5#      �� 5$      -   5        $��FirstDateFile��5$   &   $
 Wrap=�6;   $	��120��6O   $
��Left=�6[    . $��
DD/MM/YYYY��6�   6�   �� 5%      -   5        $��SecondDateFile��5%   &   $
 Wrap=�6<   $	��120��6P   $
��Left=�6\    . $
��0,10q�6�   $��
DD/MM/YYYY��6�   6�   �� 5&      -   5        $��CalculateFile��5&   %   $
��Left=�6W   $��60��6r   $��24��6~   {�.  .��6�   	Calculate6�   5(      5)      5*      5+      5,      � 5-   
   -   5        $��OutputField��5-      $��1��6"   .+�5.      �� -   5        $��DateDifference��5.      $:��4Enter the date or upload files to compare difference��6*   $��Center=�6i   $��Center=�6�   6�   5/      51      52      