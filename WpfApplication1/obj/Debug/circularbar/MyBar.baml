   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:WpfApplication1.circularbarWpfApplication1.circularbar  5      '    !WpfApplication1.circularbar.MyBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5      5local)clr-namespace:WpfApplication1.circularbar  5      -   5          >�Name$  _this��5       � 	Resources 5      7   1WpfApplication1.circularbar.ValueToAngleConverter   ValueToAngleConverter��%   &	          5   
   6&   5      .��5      � .+�5   
   A� -   5         A�Name$ BackgroundD��5      $��0q�6`   ��6'   ��  �� ElementName$ _this�� �� Path$ BackgroundBrush�6`   %  Microsoft.Expression.Shapes.Arc  5   
   -   5          Name$ 	Indicator��5         ArcThickness$
 1000Q�6$      ArcThicknessUnit$ Pixel=�68   $��0q�6�    �� Stretch$
 None=�6�   	   
StartAngle$	 0Q�6  
   EndAngle
 6Q   ��  �� 	Converter# [  $ Value�$ _this����6�   �� $ _this��$ IndicatorBrush�6  F� 5   
   -   5         F�Name$ Border��5      �
�����ȳ��Ӗ����`�d.l@`�d�N�`�d1�
�����ȳ��e�����1�
���NӠ�.l@e�����ȳ����ȳ܂� �.�0܂� ���`@�j� 8�+w��׫��'�`-��J޾�	y�X�;�ݦŗ����%IZz&#��:ǀ�P@�!eH�����y�,��ӵU��PZe�J7/����y �B@@[d|\ٲ����^���S��P��C+t�1���c3� r���� Ȏ��� �N���� H�rj�� ��V��|N	�)�#~˻	�GE_'
�p�.�
Ӿn�ʎ�
$���[�4��ө�RB������r������Ӊ�@V�`ƛ*�d�����Ӄ$_��,e�ʁ(X�50�Z��s�l��<@���9�����`�����v�	 F�6�`@�5�*�u�����+m	�5�n��	v�	,0b
���.W�
���$TO@�� �l���10�Z��+�ʁ(~l��d
k��Ӣ��*�dz�&V�l�y����>���rT
B��i>"p@4�����1=aVp@�[
p��p@ʎ�
�	��.�
�RI"_'
�C~˻	��Y�|N	Ӓ�o�� {H�r {�N� {Ȏ�]nr��U���<t�1������n/�p@��S���� xp@���A}˜�7p@[d|��0/���+��N;��PZ��:��Ӹ����&�x�!e�Gz&#�<�������+�ݦҳ	y�0:��J��
��'ȫ;
w���	�j� ��6	܂� �ȳ܂� ��ȳ � S��}�,���?��_���_�N���_0�m��} � �ȳ � �;�� �  � 0�m � �N� � ����iP@�,���?�ȳ � 	$
 Fill=�6�	  ��6k	  �� $ _this��$ ProgressBorderBrush� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 2Q�6#      
BlurRadius$ 2Q�63   5      �� 5   
   -   5         ��Name$ TextInCenterBar��5      $��Center=�6-   $��Center=�6�   $��20(�6�   $��Showcard Gothic)�6�   ��6J   �� $ _this��$ TextInCenter�6�   5      5      