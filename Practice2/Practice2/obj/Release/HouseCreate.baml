   M S B A M L   `   `   `  ���� D  @Practice2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Practice2	Practice2      Practice2.HouseCreate   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     S OHandyControl, Version=3.5.2.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  #localclr-namespace:Practice2  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    � Title$  ApartmentsCreate��$	��400��$	��420�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��'  !HandyControl.Controls.SimplePanel  .+��� $��	0,0,210,0q�._��� $��0,0,0,58q�.+�9� $	��150��$
��0,20q�   apartment_text8#���   .���� ._�,  &HandyControl.Controls.SimpleStackPanel  .+�#  HandyControl.Controls.TextBox  
������ 
������  �� 
IsReadOnly .   apartment_text9#���  )  #HandyControl.Controls.NumericUpDown  -     Name$ ApartmentsMinArea��$��4,0,4,0q�   Maximum$ 30Q�   Minimum$ 13Q�  
������ 
������  .   apartment_text10#���    -   $ ApartmentsMaxArea��$��4,0,4,0q�$	 280Q�$ 60Q�9� $	��150��  apartment_text11#���  .���� ._�  .+�  
������ 
������  .   apartment_text12#���    -   $ ApartmentsMinBill��$��4,0,4,0q�$
 5700Q�$
 2350Q�  
������ 
������  .   apartment_text13#���    -   $ ApartmentsMaxBill��$��4,0,4,0q�$ 15000Q�$
 6100Q��� $��
195,0,-2,0q�._��� $��0,0,0,58q�.+�  $	��150��$��30��$��0,20,0,5q�
������ 
������  .   apartment_text14#���    -   $ ApartmentsCount��$	��150��$��30��$	 128Q�$ 4Q�  $	��150��$��30��$��0,20,0,5q�
������ 
������  .   apartment_text15#���    -   $ ApartmentsFloorCount��$	��150��$��30��$ 16Q�$ 2Q��� -   $	��150��$��30��$��0,0,0,15q�$��Center=�$��Bottom=�  apartment_text16#���   	 ButtonSuccess#��� 	 