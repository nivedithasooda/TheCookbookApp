   M S B A M L   `   `   `  ����O  KWpfApp_SmartCookbook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WpfApp_SmartCookbook.ClassesWpfApp_SmartCookbook.Classes  5   	   %    WpfApp_SmartCookbook.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:WpfApp_SmartCookbook.Classes     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   E    � Title$ The Cookbook App��5   	   $	��670��6"   $	��630��6/   .��5	      �  � 	Resources 5
   
   .   (WpfApp_SmartCookbook.Classes.Bool2String   star6   0WpfApp_SmartCookbook.Classes.PathToBaseDirectory  	imagePath5   /WpfApp_SmartCookbook.Classes.Bool2StringTooltip  tooltipHeart��%W   &	        &	      &	 &       5      6/     5      6<     5      6>   5      .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $ Vertical=�6   
����ح�$��Center=�6K   .+�5      �� $
��Left=�6    $
��Wrap=�6;   $��The Cookbook App��6O   $��Center=�6g   $
��Bold"�6�   $��20(�6�   $��
20,20,0,10q�6�   5      �� 5      .+�5      �� -   5        $��Add new recipe��5      $��Right=�6K   $	��Top=�6g   $��90��6   $��	0,10,10,0q�6�    � ToolTip$ Click to add new recipe��6�   �� 5      $
��Left=�6   $
��Wrap=�67   $5��/Search by combination of ingredients(maximum 3)��6K   $	��Top=�6�   $��12(�6�   $��	28,10,0,0q�6�   5      �� 5      $ Vertical=�6!   .+�5      �� 
������� �� CornerRadius$ 6��64    �� Padding$ 6q�5      $��	10,2,10,5q�6   $
��0.25q�60   ._�5       �� $��0,12,0,0q�6)   $ Vertical=�6;   .+�5!   "   �� $ 
Horizontal=�6-   .+�5"   &   �� $
��Wrap=�60   $��Enter the ingredient��6D   $
��Left=�6`   $	��140��6{   $	��Top=�6�   $��12,0,0,0q�6�   �� 5#   &   $��0,0,0,0q�61   $ Vertical=�6B   .+�5$   *   �� -   5         ��Name$ Tbx_ingredient��5$   2    �� TextWrapping$
 Wrap=�6J   $�� ��6^   $
��Left=�6f   $	��Top=�6�   $; 5Enter the ingredients one at a time to browse recipes��6�   $	��160��6�   6/  �� 5%   *   -   5        	 ��Name$	 Tbk_messageInvalid��5%   4   $
��Wrap=�6P   $&�� Please enter a valid ingredient!��6d   $
��Left=�6�   $	��Top=�6�   $	��200��6�   $y�	Collapsed=�6�   �� 5&   *   -   5        
 ��Name$
 Lbx_ingredient��5&   2   $	��160��6J   $y�	Collapsed=�6W   6n   5'   '   5(   #   �� 5)   "   $ 
Horizontal=�6-   $��12,0,0,0q�6F   .+�5*   &   �� -   5        $	 Tbk_findRecipesWith��5*   b   $
��Wrap=�60   $��Finding recipes with :��6D   $	��140��6   $y�	Collapsed=�6�   �� 5+   &   -   5         ��Name$ Sp_filterIngredients��5+   1   $ 
Horizontal=�6O   5.   '   5/   #   50      51      �� 52      $ Vertical=�6%   $��28,0,0,0q�6<   .+�53      �� $��
140,5,30,0q�6)   $ Vertical=�6=   .+�54   "   �� -   5         ��Name$ Cbx_getFavorites��54   +   $��Get favorites��6E   $	��100��6~   $
��Left=�6�   �� 55   "   -	   5        $ Cbx_getMyRecipes��55   +   $��Get my recipes��6E   $	��100��6   $��0,5,0,0q�6�   $
��Left=�6�   56      �� 57      $��0,10,0,0q�6)   $ 
Horizontal=�6;   .+�58   "   �� $
��Wrap=�6,   $��Search by recipe name��6@   $	��140��6]   �� 59   "   -
   5        $ Tbx_filterName��59   *   $
 Wrap=�6B   $�� ��6V   $��0,0,30,0q�6^   $
��Left=�6p   $	��Top=�6�   $ Enter the recipe name��6�   $	��160��6�   6�   5:      5;      5<      �� 5=      $ 6��6   
�������$	��0.5q�5?      $ 8q�5@      $��10,15,10,20q�6   $��Center=�62   ._�5A      �� $ Vertical=�6%    � OverridesDefaultStyle . .+�5B      �� -   5        $	 Tbk_recipeListTitle��5B   (   $
��Wrap=�6E   $��List of recipes :��6Y   $��5,0,0,5q�6r   $	��185��6�   $
��Left=�6�   �� 5C      -   5        $	 Tbk_RecipeListEmpty��5C   (   $7��1No recipes found. Please filter by other options.��6E   $y�	Collapsed=�6~   $��Center=�6�   $��Center=�6�   $��30,0,0,0q�6�   �� 5F      -   5        $
 Lbx_Items_Recipes��5F   &   $y�	Collapsed=�6�   $��0q�6�   $
��Auto=�6�   $	��320��6�   $��Disabled=�6�   ��6w   ��  �� Path$ recipe���5G   "   �� 5H   &   .R�5I   &   � $��20,10,10,10q�60    � Orientation$ 
Horizontal=�6E   $	��510��6^   5J   #   ��5L   "   �� 5M   &   .R�5O   *   �� $ Vertical=�65   $��10q�6L   $	��140��6X   .+�5P   .   �� $	 Tbk_recipeId��68   $
��Wrap=�6N   $y�	Collapsed=�6{   ��6b   �� $ id�6{   �� 5Q   .   $	��100��6w   $	��130��6�   $
��Left=�6�   $ Click to view recipe��6�   ��64   �� $ image� �� 	Converter# [ 6�   �� 5R   .   $ 
Horizontal=�69   .+�5S   2   �� $
��Wrap=�6<   $��12(�6k   $
��Bold"�6y   $	��100��6�   $
��Left=�6�   ��6P   �� $
 name�6�   �� 5T   2   $	 Tbk_isFavorite��6<   -   5        $
��Wrap=�5T   T   
���  ��$��Right=�6&  ��6h   �� $ 
isFavorite�# [   6�   �� $ 
isFavorite�# [ 5U   3   5V   /   �� 5W   .   $ 
Horizontal=�69   $' !Time required to prepare the dish��6R   .+�5X   2   �� $
��Wrap=�6<   $��Time : ��6P   $��10(�6_   �� 5Y   2   $
��Wrap=�6<   $�� ��6P   $��11(�6X   �� 6g   �6k   �� $ timeRequiredHours� �� 5Z   .   $�hours��62    � ToolTip$ hours��6?    �� 5[   .   �62   �� $ timeRequiredMinutes� �� 5\   *   $
�mins��6.   $ minutes��6:   5]   3   5^   /   5_   +   5a   '   5c      5e      5f      5g      5h      5j      5k      