   M S B A M L   `   `   `  ���� D  @Practice2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Practice2.PagesPractice2.Pages      Practice2.Editapartment   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     S OHandyControl, Version=3.5.2.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  )localclr-namespace:Practice2.Pages  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    � Title$  ApartmentsPage��$	��547�� � 
ResizeMode$ NoResize=�.��� ����  �� ImageSource$$ /image_2024-04-10_19-58-59.png��.+��� $��10,10,10,10q�
������  �� CornerRadius$ 15��._�&   HandyControl.Controls.TabControl  $��10,10,10,10q���Z� ��Z� .@�#  HandyControl.Controls.TabItem     apartment_text17#���    �� 
IsSelected . .���� .+�$  HandyControl.Controls.ComboBox  -     Name$ ComboBoxApartmentsChoise��$	��199��$��30��$��
10,10,0,10q�$
��Left=�  apartment_text19'  !HandyControl.Controls.InfoElement   Placeholder# �  #  HandyControl.Controls.TextBox  -     Name$ TextBoxOwner��$	��199��$��57��$��	10,0,0,10q�$
��Left=�  apartment_text21# �    apartment_text20(  "HandyControl.Controls.TitleElement   Title# �  {�.    $	��199��$��	10,0,0,10q�$
��Left=�
������ 
������ 	 �� 
IsReadOnly	 .   apartment_text5#���  )  #HandyControl.Controls.NumericUpDown  -   
  Name$
 NumericUpDownFloor��$	��199��$��30��$��10,-10,0,10q�$
��Left=�{�.     Maximum$ 16Q�   Minimum$ 1Q�  $	��199��$��	10,0,0,10q�$
��Left=�
������ 
������ 	 .   apartment_text22#���    -   $
 NumericUpDownArea��$	��199��$��30��$��10,-10,0,10q�$
��Left=�{�.  $ 60Q�$ 13Q�  $	��199��$��	10,0,0,10q�$
��Left=�
������ 
������ 	 .   apartment_text11#���    -   $
 NumericUpDownBill��$	��199��$��30��$��10,-10,0,10q�$
��Left=�{�.  $ 15000Q�$
 2000Q��� -    ��Name$ 
ButtonSave��$	��199��$��30��$��15q�  apartment_text23#���  {�.    ButtonSuccess#���     	 apartment_text18#��� 	 .���� .+�  -   $$ ComboBoxApartmentsChoiseDelete��$	��199��$��30��$��50q�$��Center=�$��Center=�# �  �� -   $ ButtonDelete��$	��199��#��� 	 {�.   
 ButtonDanger#��� 
 