   M S B A M L   `   `   `  ����B  >OnStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnStoreOnStore  5   	       OnStore.EditFood   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OnStore     5   	     � Title$  AddFood��5   	   $	��320��6   $	��768��6&   $��24(�62   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $��9* �6   6*   �� 5      $��2* �6   6*   .+�5   
   � $��0��6   $��10q�6    � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��2* �6#   60    5      �� 5      6"   �� 5      6"   �� 5      6"   .+�5      �� $��64��6   $	��200��6    
�������$��8q�6?   $��0��6J   $��0��6Z   .��6g   	Food Name6r   �� 5      $��64��6   $	��200��6    
�������$��8q�6?   $��0��6J   $��1��6Z   .��6g   
Food Price6s   �� 5      $��64��6   $	��200��6    
�������$��8q�6?   $��0��6J   $��2��6Z   .��6g   Food Picture Path6z   �� 5      -   5         ��Name$ name_txt_box��5   R   
�������$��8q�6*   $��1��65   $��0��6E   ��6h   �� *NewFood.Name+ �� Mode$ TwoWay=��� 5      -   5        $ price_txt_box��5   Q   
�������$��8q�6)   $��1��64   $��1��6D   ��6i   �� *NewFood.Price+$ TwoWay=��� 5      -   5        $ picture_txt_box��5   Q   
�������$��8q�6)   $��1��64   $��2��6D   ��6j   �� *NewFood.Picture+$ TwoWay=�5       �� 5!   
   -   5        $	��200��5!      
���  ��
������ $��1��6H   .��6j   	Complated6u   5"      5#      