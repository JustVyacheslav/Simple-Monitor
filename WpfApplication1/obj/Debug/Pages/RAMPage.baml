   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApplication1.PagesWpfApplication1.Pages  5      I)clr-namespace:WpfApplication1.circularbarWpfApplication1.circularbar  5      #    WpfApplication1.Pages.RAMPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfApplication1.Pages     5      Acircularbar)clr-namespace:WpfApplication1.circularbar     5      -   5          N�Name$  _this��5       N� Title$ RAMPage��5
      $	��400��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ PhMemory��5      $��Center=�6'   $
��auto��6D   $
��auto��6R   $��	0,10,0,10q�6_   $��2��6r   $��20(�6�   $$��Tw Cen MT Condensed Extra Bold)�6�   �� 5   
   $��0��6    �� Orientation$ Vertical=�6%   $��Center=�6<   $��10,0,5,0q�6W    K� ZIndex$ 5��6i   .+�5      '   !WpfApplication1.circularbar.MyBar  -   5          Name$ CompMemoryLoad��5   =   $��Center=�6       BackgroundBrush
 �   �   ProgressBorderBrush
 ��  �	   IndicatorBrush
	 � ���$	��150��6�   $	��150��6�   �� 5      $��0,10,0,0q�6   $
��Load��6*   $��Center=�66   $��20(�6S   $��Snap ITC)�6a   5      �� 5   
   $��1��6   $ Vertical=�6%   $��Center=�6<   $��5,0,10,0q�6W   .+�5        -   5        $ CompMemoryAv��5   =   $��Center=�6    
 �   �
 ��  �
	 � ���$	��150��6�   $	��150��6�   �� 5      $��0,10,0,0q�6   $��	Available��6*   $��Center=�6;   $��20(�6X   $��Snap ITC)�6f   5      5      5      