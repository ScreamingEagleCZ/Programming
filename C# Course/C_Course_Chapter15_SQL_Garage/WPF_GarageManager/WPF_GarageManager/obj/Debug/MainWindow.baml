   M S B A M L   `   `   `  ����L  HWPF_GarageManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPF_GarageManagerWPF_GarageManager  5   	   "    WPF_GarageManager.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WPF_GarageManager     5   	     � Title$  Garage Manager��5   	   $	��500��6    $	��600��6-   .��5	      � .+�5
   
   �� $��Garage List��6   $
��Left=�6&   $��	10,10,0,0q�6A   $	��Top=�6T   �� 5   
   -   5        $��listGarages��5      $
��Left=�6%   $��10,41,0,191q�6@   $	��158��6V   6b   �� 5   
   $��Associated Cars List��6   $
��Left=�6/   $��
204,10,0,0q�6J   $	��Top=�6^   �� 5   
   -   5         ��Name$ listAssociatedCars��5      $
��Left=�6.   $��204,41,0,191q�6I   $	��158��6`   �� 5   
   -   5        $ listCars��5      $
��Left=�6$   $��400,41,0,117q�6?   $	��158��6V    J� RenderTransformOrigin$ 0.5,0.5&�6b   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ 0.324Q�6$   �� 5      T� 5       T� X$ 0.994Q�6)   5      5      �� 5   
   -   5        $��Delete Garage��5      $
��Left=�6)   $��
10,341,0,0q�6D   $	��Top=�6X   $��32��6p   $	��158��6|   6�   �� 5   
   -   5        $��
Remove Car��5      $
��Left=�6&   $��204,341,0,0q�6A   $	��Top=�6V   $��32��6n   $	��158��6z   6�   �� 5   
   -   5        $��Add Car to List��5      $
��Left=�6+   $��400,378,0,0q�6F   $	��Top=�6[   $��32��6s   $	��158��6   6�   �� 5   
   -   5        $��
Add Garage��5      $
��Left=�6&   $��
10,378,0,0q�6A   $	��Top=�6U   $��32��6m   $	��158��6y   6�   �� 5   
   -   5        $��Add to Garage��5      $
��Left=�6)   $��204,378,0,0q�6D   $	��Top=�6Y   $��32��6q   $	��158��6}   6�   �� 5   
   -	   5        $��Delete Car from List��5      $
��Left=�60   $��400,415,0,0q�6K   $	��Top=�6`   $��32��6x   $	��158��6�   6�   �� 5   
   $��Possible Cars��6   $
��Left=�6(   $��
408,10,0,0q�6C   $	��Top=�6W   �� 5   
   -
   5        $��Update Garage��5      $
��Left=�6)   $��
10,415,0,0q�6D   $	��Top=�6X   $��32��6p   $	��158��6|   6�   �� 5    
   -   5        $��Update Cars��5       $
��Left=�6'   $��204,415,0,0q�6B   $	��Top=�6W   $��32��6o   $	��158��6{   6�   �� 5!   
   -   5        $��	myTextBox��5!      $
��Left=�6#   $��
10,298,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��xxX��6f   $	��Top=�6q   $	��352��6�   $��38��6�   $��28(�6�   5#      5$      