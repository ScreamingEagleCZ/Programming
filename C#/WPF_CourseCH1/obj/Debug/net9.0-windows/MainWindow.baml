   M S B A M L   `   `   `  ����H  DWPF_CourseCH1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF_CourseCH1WPF_CourseCH1  5   	       WPF_CourseCH1.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPF_CourseCH1     5   	     � Title$  Wokno��5   	   $	��950��6   $	��950��6$   
�����w�.��5
      � $��0,0,0,0q�6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��300 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��300 �6   �� 5      $	��400 �6   .+�5   
   �� .+�5      �� -   5         ��Name$ TextBlock_Header��5      $��20(�5      $	��Top=�5      $��Center=�5      $��10q�5      Hello �� 6+   .�60   
Sugar...6:   �� 5      Go to �� 5      -   5        $��https://www.google.com?�5   "   .�5   #   Google6+   5      �� 5       $��WrapWithOverflow=�6   ��"Learning a little each day adds up. Research shows that students who make learning a habit are more likely to reach their goals. Set time aside to learn and get reminders using your learning scheduler."5#      �� 5$      -   5         ��Name$ LeButton��5$      $��Bottom=�5%      $
��Yolo��5&      $	��100��5'      $��30��5(      $��20(�5)      $
��Bold"�5*      $��Bottom=�5+      $��10q�5,      5-   .   5.      �� 5/   
   $��1��6   .+�50      �� .��51      ��  �� Orientation$ Vertical=�6   $��Center=�52      $��Center=�53      .+�54      �� $ 
Horizontal=�6!   $��Center=�55   !   $��Center=�56   !   .+�57      �� $����https://static.vecteezy.com/system/resources/thumbnails/005/695/103/small_2x/st-patrick-s-female-leprechaun-esport-mascot-logo-design-free-vector.jpg��6    $	��100��58      $��
10,10,10,0q�59       �� 5:      $��5,0,0,0q�6$   $��Center=�5;       $��Center=�5<       $��24(�5=       $
��Bold"�5>       
��� �|�Get a Beer!!!5@   0   5A      �� 5B      $	��250��5C      $��50��5D      
�������$��Center=�5F      $��
16,16,16,0q�5G      $��2q�5H      
�������$��32(�5J      .��6'   5K      5L      5M      5N      �� 5O   
   $��1��6   .+�5P      �� $��10q�6   $��60��5Q      $��20(�5R       �� AcceptsReturn$
 True��5S       �� TextWrapping$
 Wrap=�5T      
������� �� 	IsEnabled$
 True��5V      	 � Language$
	 enus�5W      �� 5X      -   5        $ 	LeButton2��5X      $��10q�5Y      $��30��5Z      $��18(�5[      .��5_   7   
Click me6A   �� 5`      -   5        $��LeLabel��5`      $��	10,5,10,0q�5a      .��6'   Hello Dolly64   5b      �� 5c   
   $��1��6   $��1��5d      .+�5e      �� $��18(�5f      $
��Bold"�5g      .��6#   What car do you vote for?6>   	� 5h      -   5        
 	�Name$
 
BMW_button��5h       	� 	GroupName$	 Car��5i      $��Center=�5j      .��5m      � .+�5n      �� $s��mhttps://w7.pngwing.com/pngs/285/461/png-transparent-bmw-m-car-bmw-5-series-logo-bmw-emblem-trademark-logo.png��6   $��16��5o      �� 5p      -   5         ��Name$ 	BMW_label��5p      
������ .��5q   5   BMW6:   5r      5s      	� 5t      -   5        $
 Audi_button��5t      $	 Car��5u      $��Center=�5v      .��5y      � .+�5z      �� $j��dhttps://image.similarpng.com/very-thumbnail/2020/09/Audi-logo-icon-on-transparent-background-PNG.png��6   $��16��5{      �� 5|      -	   5        $ 
Audi_label��5|      
������ .��5}   5   Audi6;   5~      5      	� 5�      -
   5        $
 Mercedes_button��5�      $	 Car��5�      $��Center=�5�      .��5�      � .+�5�      �� $7��1https://thumbs.dreamstime.com/b/web-136350849.jpg��6   $��16��5�      �� 5�      -   5        $ Mercedes_label��5�      
������ .��5�   5   
Mercedes6?   5�      5�      	� 5�      -   5        $
 Nissan_button��5�      $	 Car��5�      $��Center=�5�      .��5�      � .+�5�      �� $[��Uhttps://hips.hearstapps.com/hmg-prod/images/nissan-brand-logo-1200x938-1594842787.jpg��6   $��16��5�      �� 5�      -   5        $ Nissan_label��5�      
������ .��5�   5   Nissan6=   5�      5�      �� 5�      -   5        $��	CarChoose��5�      �� 5�      $��18(�6   $
��Bold"�5�      .��6&   How do u feel about it?6?   	� 5�      -   5        $
 Great_button��5�      $ Feeling��5�      .��6%   Great!6-   	� 5�      -   5        $
 	OK_button��5�      $ Feeling��5�      .��5�   -   	Okayish66   	� 5�      -   5        $
 
Gay_button��5�      $ Feeling��5�      .��5�   .   	Gayish...69   5�      �� 5�   
   $��2��6   $��1��6%   .+�5�      �� -   5         ��Name$ Master��5�      $��Center=�5�      .��5�      �� $��18(�6   $
��Bold"�5�      .��6   Finishing Touches6-   5�      �� 5�      -   5        $ Engine��5�      $��Center=�5�      ${�False��5�      $��10,0,0,0q�5�      .��5�      �� -   5        $ 
Engine_lbl��5�      .��6,   	V8 Engine67   5�      �� 5�      -   5        $ Wheels��5�      $��Center=�5�      ${�False��5�      $��10,0,0,0q�5�      .��5�      �� -   5        $ 
Wheels_lbl��5�      .��6,   Cast racing wheels6@   5�      �� 5�      -   5        $
 Body��5�      $��Center=�5�      ${�False��5�      $��10,0,0,0q�5�      .��5�      �� -   5        $ Body_lbl��5�      .��6*   Sport Body Kit6:   5�      �� 5�      -   5        $ Infotainment��5�      $��Center=�5�      ${�False��5�      $��10,0,0,0q�5�      .��5�      �� -   5        $ Infotainment_lbl��5�      .��62   Pro Infotainment6D   5�      �� 5�      -   5        $ Seats��5�      $��Center=�5�      ${�False��5�      $��10,0,0,0q�5�      .��5�      �� -   5        $ 	Seats_lbl��5�      .��6+   Racing Seats69   5�      �� 5�      -   5        $ 
Suspension��5�      $��Center=�5�      ${�False��5�      $��10,0,0,0q�5�      .��5�      �� -   5        $ Suspension_lbl��5�      .��60   Adaptable Suspension6F   5�      5�      �� 5�   
   $��2��6   .+�5�      � .+�5�      �� $��25(�6   $��0,10,0,0q�5�      .��6*   Name:62   �� 5�      $	��180��6   $��25(�5�      $��	37,10,0,0q�5�      6/   5�      � 5�      .+�5�      �� $��25(�6   .��6&   	Password:61   G� 5�      $	��180��6   $��25(�5�       G� PasswordChar$ x��5�       G� 	MaxLength$ 4��5�      6.   5�      5�      �� 5�   
   $��2��6   .+�5�      �� -   5         ��Name$ HomerIMG��5�      $	��130��5�      $��10,0,0,0q�5�      $y�Visible=�5�      $:��4pack://application:,,,/Images/Homer_Simpson_2006.png��5�      5�      �� 5�   
   $��1��6   $��2��6%   $	��Top=�62   $��20q�6J   .+�5�      (�  (� Stretch$
 None=�6   .��5�      &   System.Windows.Controls.Calendar  -    5          Name$ Calendar��5�      $��SemiCondensed&�5�         BlackoutDates 5�      /  )System.Windows.Controls.CalendarDateRange  5�         Start$ 
12.20.2024��6,   
   End$ 
01.10.2025��6?   5�      5�      (  "System.Windows.Controls.DatePicker  5�      -!   5          Name$ 
DatePicker��5�         SelectedDateFormat$
 Long=�5�         BlackoutDates 5       5     $ 01.01.00��6(   $ 
01.02.2025��69   5     �� 5     -"   5        $ CalendarTextBlock��5     �� 5     -#   5        $ SliderTextBlock��5     $��20(�5     6(   �� 5     -$   5         ��Name$ Slider��5      � Maximum$ 20Q�5	      � Minimum$ 10Q�5
      �� TickPlacement$ BottomRight=�5      �� TickFrequency$ 1Q�5      �� IsSnapToTickEnabled$
 True��5      � Value$ 50Q�5     5  :   �� 5     ��6   ��   �� ElementName$  Slider��! �� Path$! Value�" �� UpdateSourceTrigger$" PropertyChanged=�#!XAML binding version of font size6�   5     �� 5  
   $��2��6   $��2��6"   .+�5     9� -%   5        ��5     �� 5     $ 
Horizontal=�6!   .+�5     �� $��20��6    $Q��Khttps://static-00.iconduck.com/assets.00/expand-1-icon-512x512-ko9gk9qj.png��6,   6�   �� 5     Click to expand/collapse6>   5     .��5     �� .+�5     �� .��6   
Click me6'   �� 5     $
��Wrap=�6    $��20(�5      ��Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Curabitur ligula sapien, pulvinar a vestibulum quis, facilisis vel sapien. Mauris suscipit, ligula sit amet pharetra semper, nibh ante cursus purus, vel sagittis velit mauris vel metus. Mauris metus. Donec ipsum massa, ullamcorper in, auctor et, scelerisque sed, est.5$     5%     5&     5'     5(     5)     