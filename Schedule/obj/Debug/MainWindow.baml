   M S B A M L   `   `   `  ����C  ?Schedule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ScheduleSchedule  5   	       Schedule.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Schedule     5   	     � Title$  Авторизация��5   	   $	��300��6   $	��200��6-   $	��450��6<   $	��400��6I    � WindowStartupLocation$ CenterScreen=�6U    � 
ResizeMode$ NoResize=�6z   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��71* �6   �� 5      $
��264* �6   �� 5      $	��71* �6   .+�5   
   �� $��1��6   $��1��6   $	��Top=�6-   .��6E   Логин:6M   �� 5   
   $��2��6   $��1��6   $	��Top=�6-   .��6E   Пароль:6N   �� 5   
   -   5         ��Name$ 	loginText��5      $��1��6%   $��14(�62   $��1��6@   $��Center=�6P   $��	0,30,0,29q�6k   ���	#FFC3C3C36~   G� 5   
   -   5         G�Name$ passwordText��5      $��14(�6,   $��2��6:   $��1��6G   $��Center=�6W   $
��0,30q�6r   ���	#FFB9B9B96�   �� 5   
   -   5        $ passwordText2��5      $��14(�6)   $��2��67   $��1��6D   $��Center=�6T   $y�Hidden=�6o   ���	#FF86C500$��	0,30,0,29q�6�   6�   �� 5   
   -   5         ��Name$ passV��5      $��2��6   $��2��6/   $
��Left=�6<   $��eye.png��6�   $��10, 30, 0, 30q�6�   6�   �� 5   
   -   5         ��Name$ loginB��5      $��1��6!   $��3��61   $��
Войти��6>   $
��0,26q�6c   6s   5      5      