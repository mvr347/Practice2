   M S B A M L   `   `   `  ����D  @Practice2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Practice2.PagesPractice2.Pages  5          Practice2.Pages.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OHandyControl, Version=3.5.2.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      )localclr-namespace:Practice2.Pages  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� Title$  Login��5	      .��5      � .+�5   
   �� ._�5      /  )HandyControl.Controls.UniformSpacingPanel     Orientation$ Vertical=�6%      Spacing$ 10Q�6<   .+�5      #  HandyControl.Controls.TextBox  $��10,71,390,321q�5      
������ 
������ $��30(�5      $
��Bold"�5       �� 
IsReadOnly .    
auth_login#���   5       �� TextAlignment$ Center=�5        5      $��75,-290,455,711q�5      
������ 
������ $��12(�5       . #���   5      $
 Left=�5         5!      $��75,-683,455,1104q�5"      
������ 
������ $��12(�5%       .   auth_password#���  5'      $
 Left=�5(        5)      -   5          Name$ logUsername��5*      $��75,-1175,455,1597q�5+       �� 	MaxLength$ 15��5,      '  !HandyControl.Controls.PasswordBox  5-      -   5          Name$ logPassword��5.      $��75,-1569,455,1991q�5/         	MaxLength$ 15��50      	   ShowEyeButton	 . 51      �� 52      -   5        
 ��Name$
 btnEnter��53      $��115,-1921,495,2343q�54      $��Stretch=�55      $��Stretch=�56        	btn_Enter#���  58      �� 59      $��75,-2456,455,2457q�6    �� TextAlignment$ Center=�67   �� 5:        auth_noaccount#��  6    �� 5;      -   5        .�5;   8   .�5<      ��   auth_createaccount#��  6   5=      5>      �� 5?      $��390,-2767,-1,2297q�5@       J� RenderTransformOrigin$ 0.5,0.5&�5A      $$��/image_2024-04-10_19-58-59.png��5B      $��UniformToFill=�5C       J� OpacityMask 5D      �� 5E       �� ImageSource$$ /image_2024-04-10_19-58-59.png��6%    j� Stretch$
 Fill=�6R   5G      5H      5I      5J      5K      