   M S B A M L   `   `   `  ���� J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:WpfApplication1.circularbarWpfApplication1.circularbar  '    !WpfApplication1.circularbar.MyBar   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5local)clr-namespace:WpfApplication1.circularbar  -     >�Name$  _this�� � 	Resources 7   1WpfApplication1.circularbar.ValueToAngleConverter   ValueToAngleConverter��%   &	          .��� .+�A� -    A�Name$ BackgroundD��$��0q�����  �� ElementName$ _this�� �� Path$ BackgroundBrush�%  Microsoft.Expression.Shapes.Arc  -     Name$ 	Indicator��   ArcThickness$
 1000Q�   ArcThicknessUnit$ Pixel=�$��0q� �� Stretch$
 None=�	   
StartAngle$	 0Q�
   EndAngle
 ��  �� 	Converter# [  $ Value�$ _this������ $ _this��$ IndicatorBrush�F� -    F�Name$ Border���
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
 Fill=����� $ _this��$ ProgressBorderBrush� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 2Q�   
BlurRadius$ 2Q��� -    ��Name$ TextInCenterBar��$��Center=�$��Center=�$��20(�$��Showcard Gothic)����� $ _this��$ TextInCenter�