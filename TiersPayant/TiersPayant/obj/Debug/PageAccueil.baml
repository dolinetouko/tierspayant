   M S B A M L   `   `   `  ����F  BTiersPayant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TiersPayantTiersPayant  5   	       TiersPayant.PageAccueil   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:TiersPayant  5   	     � Title$   ��5
   	   $	��600��6   $
��1080��6    � 
ResizeMode$ NoResize=�6,    � WindowStartupLocation$ CenterScreen=�6B    � WindowStyle$
 None=�6g   .��5      � 
�������.+�5      � $��60��6   $	��Top=�6   ���	#FF93BBD6.+�5      �� $��Page Accueil��6   $��Center=�6&   $��22(�6C   $��479,0q�6Q   $��50��6`   $��Bottom=�6l   �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�6.   $��Right=�6G   .+�5   
   �� $��Paramètres��6   $��Center=�6&   $��18(�6A   6Q   '  !MaterialDesignThemes.Wpf.PopupBox  5   
   $��10q�6#      PlacementMode$ BottomAndAlignRightEdges=�6/      	StaysOpen .     PopupContent. 5      �� $	��150��6   .+�5      �� $��Account��6   6)   �� 5      $��Settings��6   6*   �� 5      $
��Help��6   6&   �� 5      �� 5      -   5         ��Name$ ButtonPopUpLogout��5      $��Logout��60   6A   5      5      5   	   5      � 5      -   5        	 �Name$	 GridMenu��5      $	��185��6   $
��Left=�6)   ���	#FF4940F5.+�5      �� .+�5   
   � $	��150��6   .+�5!      �� $��Asset/home.png��6   $	��100��6*   69   5(      � 5)   
   .+�5.      �� -   5        
 ��Name$
 listViewMenu��5.   K   $��Disabled=�6   .@�5/      �� $��60��6   
�������.��50      �� $ 
Horizontal=�6   .+�51      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null]]   Kind$ ViewDashboard=�6*   $��10q�6?   $��Center=�6K   6h   �� 52      $
��Home��6   $��Center=�6(   $��20 10q�6C   6U   53      54      �� 55      $��60��6   
�������.��56      �� $ 
Horizontal=�6   .+�57        $ Create=�6*   $��10q�68   $��Center=�6D   6a   �� 58      $��Prestations��6   $��Center=�6/   $��20 10q�6J   6\   59      5:      �� 5;      $��60��6   
�������.��5<      �� $ 
Horizontal=�6   .+�5=        $ 	Billboard=�6*   $��10q�6;   $��Center=�6G   6d   �� 5>      $��Facturation��6   $��Center=�6/   $��20 10q�6J   6\   5?      5@      �� 5B      $��60��6   
�������.��5C      �� $ 
Horizontal=�6   .+�5D        $ Payment=�6*   $��10q�69   $��Center=�6E   6b   �� 5E      $��Etats��6   $��Center=�6)   $��20 10q�6D   6V   5F      5G      5H      5I      5J   	   5L      � 5M      $	��500��6   $��Bottom=�6   $	��800��64   $��Right=�6@   .+�5N      � -   5        $	 GridPrincipal��5N      5P   	   5Q      5R      5S      