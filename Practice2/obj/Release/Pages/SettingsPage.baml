   M S B A M L   `   `   `  ���� D  @Practice2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Practice2.PagesPractice2.Pages  "    Practice2.Pages.SettingsPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     S OHandyControl, Version=3.5.2.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  )localclr-namespace:Practice2.Pages  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    N� Title$  SettingsPage��.��� .+��� $��10,10,10,10q�   BorderBrush#���    �� CornerRadius$ 15��._�&   HandyControl.Controls.TabControl  $��10,10,10,10q���Z� ��Z� .@�#  HandyControl.Controls.TabItem    settings_text1#���   �� 
IsSelected . .��,  &HandyControl.Controls.SimpleStackPanel  .+�#  HandyControl.Controls.TextBox  $	��199��$��30��$��	0,0,559,0q�$
��Left=�
������ 
������  �� 
IsReadOnly .   settings_text3#���   �� SelectionBrush Z�  �� SelectionTextBrush Z� �� -    ��Name$ ComboBoxLanguageChange��$	��199��$��30��$��	0,0,559,0q�$
��Left=�  $	��199��$��	0,0,559,0q�$
��Left=�
������ 
������  .   settings_text4#���   Z�  Z� d� -    d�Name$ ToggleButtonTheme��$��42��$��18,0,0,0q�$
��Left=�  ToggleButtonSwitch#���      settings_text2#���  .��  .+��� -    ��Name$ ButtonDelete��$	��199��$
��0,10q�$
��Left=�  settings_text8#���    ButtonDanger#���  �� -   $ ButtonWipeAllUsers��$	��199��$
��0,10q�$
��Left=�$	��Top=�  settings_text9#���  #���  $y�	Collapsed=�