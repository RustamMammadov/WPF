   M S B A M L   `   `   `  ����>  :Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfWpf  5   	       Wpf.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Wpf     5   	   -   5        $��
Calculator��5   V     � Title$  
Calculator��6	   $	��532��6   $	��362��6*   $	��532��66   $	��362��6G   
�������
������ .��5
      �  � RowDefinitions 5   
   �� 5      $��36 �6   6*   �� 5      $	��110 �6   6+   �� 5      $��25 �6   6+   �� 5      6   .+�5   
   ]� $��0��6   .+�5      �� $��30��6   
������ .��5      �� $��Hamburger_icon.png��6   $��0,6,0,0q�64   ${�False��6E   6\   5      �� 5      $��20(�6   $��DemiBold"�6"   $
��Left=�68   $��Bottom=�6S   .��6n   
Standart6x   �� 5      $��Right=�6   $��Bottom=�61   
������ .��5      �� $=��7https://cdn-icons-png.flaticon.com/128/9133/9133211.png��6   $��26��6Z   ${�False��6f   6|   5      5      � 5   
   $��1��6    5      �� 5       $
��1.5* �6    �� 5!      $
��2.5* �6    .+�5#      �� -   5        $��lebel_history��5#   -   
�������$��0��6B   $��Right=�6O   $��Center=�6r   
���   �$��16(�6�   .��6�   06�   �� 5$      -   5        $��lebel_canvas��5$   ,   
�������$��1��6@   $��Right=�6M   $��Center=�6p   $��35(�6�   
���   �.��6�   06�   5%      � 5'   
   $��2��6    � ColumnDefinitions 5(      �� 5)      6%   �� 5*      6%   �� 5+      6%   �� 5,      6%   �� 5-      6%   �� 5.      6%   .+�50      �� $��0��6   
������ .��6?   MC6C   �� 51      $��1��6   
������ .��6?   MR6C   �� 52      $��2��6   
������ .��6?   M+6C   �� 53      $��3��6   
������ .��6?   M-6C   �� 54      $��4��6   
������ .��6?   MS6C   �� 55      $��5��6   
������ .��6?   M^6C   58      � 5:   
   $��3��6    5;      �� 5<      6%   �� 5=      6%   �� 5>      6%   �� 5?      6%    5A      �� 5B      6#   �� 5C      6#   �� 5D      6#   �� 5E      6#   �� 5F      6#   �� 5G      6#   .+�5J      �� -   5        $��btn_faiz��5J      $��%��6&   $��16(�63   $��Arial)�6B   $��1q�6U   $��0��6`   $��0��6m   
������ 6�   �� 5K      -   5        $��btn_CE��5K      $��CE��6$   $��16(�62   $��Arial)�6A   $��1q�6T   $��0��6_   $��1��6l   
������ 6�   �� 5L      -   5        $��btn_C��5L      $��C��6#   $��16(�60   $��Arial)�6?   $��1q�6R   $��0��6]   $��2��6j   
������ 6�   �� 5M      -   5        $��btn_backspace��5M      $��1q�6-   $��0��68   $��3��6E   
������ .��5N      �� $=��7https://cdn-icons-png.flaticon.com/512/5683/5683181.png��6   $��36��6Y   5O      �� 5Q      -   5        $��btn_OneDivX��5Q      $	��1/x��6)   $��16(�68   $��Lucida Calligraphy)�6G   $��1q�6g   $��1��6r   $��0��6   
������ 6�   �� 5R      -	   5        $��x2��5R      $	��x²��6    $��16(�6.   $��Lucida Calligraphy)�6=   $��1q�6]   $��1��6h   $��1��6u   
������ 6�   �� 5S      -
   5        $��btn_SQRT��5S      $	��√��6&   $��20(�63   $��Lucida Calligraphy)�6B   $��1q�6b   $��1��6m   $��2��6z   
������ 6�   �� 5U      -   5        $��
btn_Divide��5U      $��/��6(   $��16(�65   $��Lucida Calligraphy)�6D   $��1q�6d   $��1��6o   $��3��6|   
������ 6�   �� 5V      -   5        $��btn_Mult��5V      $��x��6&   $��16(�63   $��Arial)�6B   $��1q�6U   $��2��6`   $��3��6m   
������ 6�   �� 5W      -   5        $��	btn_Minus��5W      $��-��6'   $��16(�64   $��Lucida Calligraphy)�6C   $��1q�6c   $��3��6n   $��3��6{   
������ 6�   �� 5X      -   5        $��btn_Plus��5X      $��+��6&   $��16(�63   $��Lucida Calligraphy)�6B   $��1q�6b   $��4��6m   $��3��6z   
������ 6�   �� 5Y      -   5        $��	btn_Equal��5Y      $��=��6'   $��16(�64   $��Lucida Calligraphy)�6C   $��1q�6c   $��5��6n   $��3��6{   
������ 6�   �� 5]      -   5        $��btn_minusPlus��5]      $��±��6+   $��20(�68   $��Lucida Calligraphy)�6G   $��1q�6g   $��5��6r   $��0��6   
������ 6�   �� 5^      -   5        $��btn_dot��5^      $��,��6%   $��20(�62   $��Lucida Calligraphy)�6A   $��1q�6a   $��5��6l   $��2��6y   
������ 6�   �� 5a      -   5        $��btn_Zero��5a      $��0��6&   $��20(�63   $��DemiBold"�6B   $��Arial)�6X   $��1q�6k   $��5��6v   $��1��6�   
������ 6�   �� 5b      -   5        $��btn_1��5b      $��1��6#   $��20(�60   $��DemiBold"�6>   $��Arial)�6T   $��1q�6g   $��4��6r   $��0��6   
������ 6�   �� 5c      -   5        $��btn_2��5c      $��2��6#   $��20(�60   $��DemiBold"�6>   $��Arial)�6T   $��1q�6g   $��4��6r   $��1��6   
������ 6�   �� 5d      -   5        $��btn_3��5d      $��3��6#   $��20(�60   $��DemiBold"�6>   $��Arial)�6T   $��1q�6g   $��4��6r   $��2��6   
������ 6�   �� 5e      -   5        $��btn_4��5e      $��4��6#   $��20(�60   $��DemiBold"�6>   $��Arial)�6T   $��1q�6g   $��3��6r   $��0��6   
������ 6�   �� 5f      -   5        $��btn_5��5f      $��5��6#   $��20(�60   $��DemiBold"�6>   $��Arial)�6T   $��1q�6g   $��3��6r   $��1��6   
������ 6�   �� 5g      -   5        $��btn_6��5g      $��6��6#   $��20(�60   $��DemiBold"�6>   $��Arial)�6T   $��1q�6g   $��3��6r   $��2��6   
������ 6�   �� 5h      -   5        $��btn_7��5h      $��7��6#   $��20(�60   $
��Bold"�6>   $��Arial)�6P   $��1q�6c   $��2��6n   $��0��6{   
������ 6�   �� 5i      -   5        $��btn_8��5i      $��8��6#   $��20(�60   $��DemiBold"�6>   $��Arial)�6T   $��1q�6g   $��2��6r   $��1��6   
������ 6�   �� 5j      -   5        $��btn_9��5j      $��9��6#   $��20(�60   $��DemiBold"�6>   $��Arial)�6T   $��1q�6g   $��2��6r   $��2��6   
������ 6�   5m      5r      5s      