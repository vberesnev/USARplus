   M S B A M L   `   `   `  ����K  GUSAR_TestProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:USAR_TestProjectUSAR_TestProject  5   	   =#clr-namespace:USAR_TestProject.ViewUSAR_TestProject.View  5   	   !    USAR_TestProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:USAR_TestProject     5   	   4view#clr-namespace:USAR_TestProject.View     5   	     � Title$  	ЮСАР+��5	   	   $	��300��6   $	��400��6$    � 
ResizeMode$ NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F    � 	Resources 5
      -   'USAR_TestProject.View.DateTimeConverter   dateConverter��%   &	          5   
   6!   5      .��5      �� $��10q�6   .+�5   
   �� $
��10 5q�6J   $��18(�6X    �� TextAlignment$
 Left=�6f   ��6   �� *CurrentMessage.UserName+ �� Mode$ TwoWay=�6f   �� 5   
   $
��10 5q�6t   $��18(�6�   $
 Left=�6�   ��6   �� *CurrentMessage.SaveDate+ �� 	Converter# [  $ TwoWay=�6�   �� 5   
   -   5         ��Name$ TextBox��5      $��18(�6U    �� TextAlignment$ Justify=�6c   	 �� TextWrapping$	 WrapWithOverflow=�6{   $	��100��6�   $��10q�6�   ��6#   �� *CurrentMessage.Text+$ TwoWay=�6�   �� 5   
   $��Сохранить��6   $��Center=�6%   $
��15 5q�6B   $��10q�6Q   ��6]   �� *SaveCommand+{�5      �� 
 �� ElementName$
 TextBox�� �� Path$ Text.Length�$ OneWay=�5      5      