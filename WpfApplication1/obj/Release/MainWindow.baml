   M S B A M L   `   `   `  ���� J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1       WpfApplication1.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:WpfApplication1     \ XHardcodet.Wpf.TaskbarNotification, Version=1.0.5.0, Culture=neutral, PublicKeyToken=null)tb http://www.hardcodet.net/taskbar  $	��350��$	��600��  � Topmost  .   � Title$ Simple Monitor�� � 	Resources  �� 
TargetType �� Property �� Value��%b   '��       �� " ��.���  � ��
 ���� ��  � ��
 ���� ��  � ��$ 5,0,5,0q�.���  � ColumnDefinitions �� $	��130 ��� .+��� -    ��Name$ st��$��Center=�$��0��$��0,0,1,0q�.+��� $��5,5,5,0q�$��50��$��MainIfo������ *
ShowMain+���� *MainSelected+���� *MainSelected+�� -   $��BtCpu��$��50������ *	ShowCpu+���� *CpuSelected+���� *CpuSelected+.��� $
��auto�� � RowDefinitions �� $��* ��� $��* � �� $
��auto ��� $
��auto �.+��� $	��CPU��$��0��$��2��$��Center=��� $��1��$��0��$��Center=�$��0,0,5,0q����� *l+�� $��1��$��1��$��Center=�$��5,0,0,0q����� *h+�� $��50������ *	ShowRam+���� *RamSelected+���� *RamSelected+.��� $
��auto�� �� $��* ��� $��* � �� $
��auto ��� $
��auto �.+��� $	��RAM��$��0��$��2��$��Center=��� $��1��$��0��$��Center=�$��0,0,5,0q����� *rl+�� $��1��$��1��$��Center=�$��5,0,0,0q����� *ra+�� $��5,0,5,5q�$��50������ *	ShowGpu+���� *GpuSelected+���� *GpuSelected+.��� $
��auto�� �� $��* ��� $��* � �� $
��auto ��� $
��auto �.+��� $	��GPU��$��0��$��2��$��Center=��� $��1��$��0��$��Center=�$��0,0,5,0q����� *gl+�� $��1��$��1��$��Center=�$��5,0,0,0q����� *gt+�� 		 �� X1$		 130��	
 �� Y1$
 0��	 �� X2$	 130��	 �� Y2$
 2000��
������� � -     �Name$ 	MainFrame��$��1��  � NavigationUIVisibility$ Hidden=�$��5,0,0,0q�$
��auto������ *CurrentPage+�� -    ��Name$ label��$
��Left=�$��	55,36,0,0q�$	��Top=�3  -Hardcodet.Wpf.TaskbarNotification.TaskbarIcon  -     Name$ SoMeIcon��   MenuActivation$ LeftOrRightClick=�$y�Visible=�   
IconSource$ /Images/Logo.ico�� � ContextMenu �� .@�m� $��Property��
����ح�
��� ���$
��auto��$
��Left=� m� Command �� *ShowPropartyWindow+ m� Icon �� $��/Images/her.png��$��Uniform=� �� StretchDirection$
 Both=�