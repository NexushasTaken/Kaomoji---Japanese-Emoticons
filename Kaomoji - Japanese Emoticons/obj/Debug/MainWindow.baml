   M S B A M L   `   `   `  ����W  SKaomoji - Japanese Emoticons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Kaomoji___Japanese_EmoticonsKaomoji___Japanese_Emoticons  5   	   b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5   	   -    'Kaomoji___Japanese_Emoticons.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Kaomoji___Japanese_Emoticons     5   	   ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5   	   -   5          �Name$  _Window��5   	    � Icon$ /Images/android_mini.ico��5	   	    � WindowStyle$
 None=�5
   	   
�������$	��240��5   	   $	��148��6    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��28 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ _Border��5   <   $��2��6   ._�5      � $��Stretch=�6   .+�5      �� -   5         ��Name$ _Label��5   E   $��Kaomoji��6   $��Comic Sans MS)�6*   6E   �� 5      -   5         ��Name$ _StackPanel��5   R   	 �� Orientation$	 
Horizontal=�6   $��Right=�66   .+�5      �� -   5        
 ��Name$
 MinimizeBtn��5       $
��🗕��5      $��22��5      $��20��6(   
������ $��0q�5      5!      �� 5"      -   5        $
 ExitBtn��5&      $	��✕��5"      $��22��5#      $��20��6(   
������ $��0q�5%      5'      5(      5)      5*      o� 5+   
   -   5         o�Name$ _Menu��5+   C   $��1��6   $��2��6   $��	0,0,0,194q�60   .@�5,      m� -   5         m�Name$ _MenuItemInfo��5,   &   $��_Info��6   $��Comic Sans MS)�6X   $��36��6s   .@�5-      m� -	   5        $ _MenuItemAbout��5-   +   $��_About��6   6C   m� 5.      -
   5        $ _MenuItemHelp��5.   *   $��_Help��6   6A   5/      m� 54      -   5        $ _MenuItemSettings��54   )   $��Settings��6   $��Comic Sans MS)�6c   $��57��6~   55      �� 56   
   $��1��6   $	��133��6"   $��2��6.   $��	8,18,7,28q�6B   .+�57      �� -   5         ��Name$ _CategoriesCB��57      $��Comic Sans MS)�6_   �� 58      -   5        $ _CategoriesTypeCB��58      $��Comic Sans MS)�6g   �� 59      -   5         ��Name$ _EmojiLB��59      $	��120��6(   65   5:      �� 5;   
   -   5        $
 _FavBtn��5;      $��	Favorites��6"   $��	8,184,0,8q�66   $��1��6I   $��Comic Sans MS)�6V   6q   �� 5<   
   -   5        $
 AddToFavBtn��5<      $��+��6&   $��1��62   $��1��6B   $��
0,184,54,8q�6O   $y�Visible=�6c   $��Comic Sans MS)�6x   6�   �� 5=   
   -   5        $
 RemoveToFavBtn��5=      $��-��6)   $��1��65   $��1��6E   $��
0,184,54,8q�6R   $y�Hidden=�6f   $��Comic Sans MS)�6z   6�   �� 5>   
   -   5         ��Name$ _AlwaysOnTop��5>      $��1��6)   $��1��66   $��15��6F   $��
51,189,7,8q�6R   6�   5?      5@      