   M S B A M L   `   `   `  ����D  @Practice2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Practice2.PagesPractice2.Pages  5          Practice2.Editapartment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OHandyControl, Version=3.5.2.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      )localclr-namespace:Practice2.Pages  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  ApartmentsPage��5	      $	��547��5
       � 
ResizeMode$ NoResize=�5      .��5      � ��5   
   �� 5       �� ImageSource$$ /image_2024-04-10_19-58-59.png��6   .+�5   
   �� $��10,10,10,10q�5      
������  �� CornerRadius$ 15��5      ._�5      &   HandyControl.Controls.TabControl  $��10,10,10,10q�5      ��5      Z� ��5      Z� .@�5      #  HandyControl.Controls.TabItem     apartment_text17#���   6    �� 
IsSelected . .��5      �� .+�5      $  HandyControl.Controls.ComboBox  -   5          Name$ ComboBoxApartmentsChoise��5      $	��199��5      $��30��5      $��
10,10,0,10q�5       $
��Left=�5!        apartment_text19'  !HandyControl.Controls.InfoElement   Placeholder# �  5"      5#      #  HandyControl.Controls.TextBox  5$      -   5          Name$ TextBoxOwner��5%      $	��199��5&      $��57��5'      $��	10,0,0,10q�5(      $
��Left=�5)        apartment_text21# �  5*        apartment_text20(  "HandyControl.Controls.TitleElement   Title# �  5+      {�.  5-        5.      $	��199��5/      $��	10,0,0,10q�50      $
��Left=�51      
������ 
������ 	 �� 
IsReadOnly	 .   apartment_text5#���  55      )  #HandyControl.Controls.NumericUpDown  56      -   5        
  Name$
 NumericUpDownFloor��57      $	��199��58      $��30��59      $��10,-10,0,10q�5:      $
��Left=�5;      {�.     Maximum$ 16Q�5=         Minimum$ 1Q�5>        5?      $	��199��5@      $��	10,0,0,10q�5A      $
��Left=�5B      
������ 
������ 	 .   apartment_text22#���  5F        5G      -   5        $
 NumericUpDownArea��5H      $	��199��5I      $��30��5J      $��10,-10,0,10q�5K      $
��Left=�5L      {�.  $ 60Q�5N      $ 13Q�5O        5P      $	��199��5Q      $��	10,0,0,10q�5R      $
��Left=�5S      
������ 
������ 	 .   apartment_text11#���  5W        5X      -   5        $
 NumericUpDownBill��5Y      $	��199��5Z      $��30��5[      $��10,-10,0,10q�5\      $
��Left=�5]      {�.  $ 15000Q�5_      $
 2000Q�5`      �� 5a      -   5         ��Name$ 
ButtonSave��5b      $	��199��5c      $��30��5d      $��15q�5e        apartment_text23#���  5g      {�.    ButtonSuccess#���  5i      5j      5k        5l       	 apartment_text18#��� 	 6   .��5m      �� .+�5n        -   5        $$ ComboBoxApartmentsChoiseDelete��5o      $	��199��5p      $��30��5q      $��50q�5r      $��Center=�5s      $��Center=�5t      # �  5u      5v      �� 5w      -   5        $ ButtonDelete��5x      $	��199��5y      #��� 	 5{      {�.   
 ButtonDanger#��� 
 5}      5~      5      5�      5�      5�      5�      