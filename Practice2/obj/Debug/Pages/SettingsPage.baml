   M S B A M L   `   `   `  ����D  @Practice2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Practice2.PagesPractice2.Pages  5      "    Practice2.Pages.SettingsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OHandyControl, Version=3.5.2.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      )localclr-namespace:Practice2.Pages  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� Title$  SettingsPage��5	      .��5      � .+�5   
   �� $��10,10,10,10q�5         BorderBrush#���   5       �� CornerRadius$ 15��5      ._�5      &   HandyControl.Controls.TabControl  $��10,10,10,10q�5      ��5      Z� ��5      Z� .@�5      #  HandyControl.Controls.TabItem    settings_text1#���  6    �� 
IsSelected . .��5      ,  &HandyControl.Controls.SimpleStackPanel  .+�5      #  HandyControl.Controls.TextBox  $	��199��5      $��30��5      $��	0,0,559,0q�5      $
��Left=�5      
������ 
������  �� 
IsReadOnly .   settings_text3#���  5#       �� SelectionBrush 5!      Z�  �� SelectionTextBrush 5"      Z� 5#      �� 5$      -   5         ��Name$ ComboBoxLanguageChange��5%      $	��199��5&      $��30��5'      $��	0,0,559,0q�5(      $
��Left=�5)        5*      $	��199��5+      $��	0,0,559,0q�5,      $
��Left=�5-      
������ 
������  .   settings_text4#���  53       51      Z�  52      Z� 53      d� 54      -   5         d�Name$ ToggleButtonTheme��55      $��42��56      $��18,0,0,0q�57      $
��Left=�58        ToggleButtonSwitch#���  5:      5;      5<      5=        5>        settings_text2#���  6   .��5?        .+�5`      �� -   5         ��Name$ ButtonDelete��5a      $	��199��5b      $
��0,10q�5c      $
��Left=�5d        settings_text8#���  5f        ButtonDanger#���  5g      �� 5h      -   5        $ ButtonWipeAllUsers��5i      $	��199��5j      $
��0,10q�5k      $
��Left=�5l      $	��Top=�5m        settings_text9#���  5o      #���  5p      $y�	Collapsed=�5q      5r      5s      5t      5u      5v      5w      