   M S B A M L   `   `   `  ���� D  @Practice2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Practice2	Practice2      Practice2.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     S OHandyControl, Version=3.5.2.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  #localclr-namespace:Practice2  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    � Title$;  5Програма управління для ОСББ��$	��850��$	��485��$	��850��$	��485�� � WindowStartupLocation$ CenterOwner=�.���  � RowDefinitions �� $	��29* ��� $
��198* ��� $��0* �����  �� ImageSource$$ /image_2024-04-10_19-58-59.png��.+�� $��0�� � ColumnDefinitions �� $
��392* ��� $
��174* ��� $
��227* ��� $	��57* ��� $��0* �.+��� -    ��Name$ 
ButtonHome��$��83��$��38��$��10,0,0,0q�$
��Left=�
�������
������    
main_text1#���   $��16(��� -   $ ButtonCalculator��$	��113��$��38��$��	116,0,0,0q�$
��Left=�
�������
������   
main_text2#���  $��16(��� -   $ ButtonApartments��$	��122��$��38��$��	248,0,0,0q�$
��Left=�
�������
������   
main_text3#���  $��16(��� -    ��Name$ UsernameLabel��$��2��$	��153��$��38��$��74,0,0,0q�$
��Left=�$��Right=�
������ $��USERNAME��$��14(��� -   $ ButtonLogout��$��2��$��40��$��74,0,0,0q�$
��Left=�  ErrorGeometry'  !HandyControl.Controls.IconElement   Geometry# �    
main_text4"  HandyControl.Controls.Poptip   Content# �  ��Z� ��Z� �� -   $ ButtonSettings��$��3��$��47��$��34��  ConfigGeometry# �  
������ 
������  � -   	  �Name$	 MainWindowFrame��$��1��$��0,5,0,0q�
������ 
  � NavigationUIVisibility$
 Hidden=� J� RenderTransformOrigin$ 0.5,0.5&�