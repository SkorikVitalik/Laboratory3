   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	   5clr-namespace:WpfApp.ViewModelsWpfApp.ViewModels  5   	       WpfApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   .vmclr-namespace:WpfApp.ViewModels     5   	   $��Medium"�5
   	   $��14(�5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5      %  WpfApp.ViewModels.MainViewModel  5   
   .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $��New File��6   m� 5      $
��Exit��6   5      m� 5      $
��Help��6   .@�5      m� $��About��6   5      5      �� 5   
   $��Bottom=�6   .@�5      �� .��5      �� ��6   �� *Status+ �� TargetNullValue$ 	Not Ready��5      �� 5       .��5!      �  � Value$ 30Q�6   $	��100��6)   $��20��65   5"      5#      �� 5$   
   .@�5%      �� $
��Tab1��6   .��5&      �  � ColumnDefinitions 5'      �� 5(      �� 5)       � RowDefinitions 5+      �� 5,      �� 5-      .+�5/      �� $��0��6   $��0��6.   $��10q�6;    �� TextWrapping$
 Wrap=�6G   ��6[   �� *Text+ �� Mode$ OneWayToSource=�.��6�    J� InputBindings 50      �� 51      
	 �� Key$	 Enter��6T   
 �� Command
 6)   �� *CleanWhiteSpaceCommand+6T   .��52   1   53      �� 54      $��1��6    $��0��60   $��10q�6=   $
��Wrap=�6k   ��6I   �� *NoWhiteSpaceText+6k   55      56      �� 57      $
��Tab2��6   58      59      5:      