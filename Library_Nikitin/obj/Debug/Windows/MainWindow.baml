   M S B A M L   `   `   `  ����J  FLibrary_Nikitin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_NikitinLibrary_Nikitin  5   	        Library_Nikitin.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library_Nikitin     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ 
MainWindow��5
   	   $	��450��6   $	��800��6)   ��5      �� 5   
    �� ImageSource$6 0/Library_Nikitin;component/Images/Backgraund.jpg��6   .��5      � ��5   
   �� 5      $6 0/Library_Nikitin;component/Images/Backgraund.jpg��6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Главное окно��6   $	��Top=�5       $��1��5!      $��1��5"      $��Center=�5#      $��40(�5$      ���	#FFFEFFFA$��Impact)�5%      ���	#FF000120 J� Opacity$	 0.9Q�5'       J� Effect 5(      3  -System.Windows.Media.Effects.DropShadowEffect  5)         Color$ 	#FFE1C299��6#   	   	Direction$		 320Q�65   
   ShadowDepth$
 10Q�6E      Opacity$	 0.6Q�6V      RenderingBias$ Quality=�6d   5+      �� 5.   
   -   5         ��Name$ btnListReader��5.      $%��Список читателей��5/      $	��200��50      $��1��51      $��40��52      $��18(�53      $��Impact)�54      $
��10 0q�55      ���	#FFFEFFFA���	#FF000120$	 0.8Q�59      �� 5;   
   -   5        $ btnListBook��5;      $��Список книг��5<      $	��200��5=      $��40��5>      $��1��5?      $��1��5@      $��18(�5A      $��Impact)�5B      $
��10 0q�5C      ���	#FFFEFFFA���	#FF000120$	 0.8Q�5G      �� 5J   
   -   5        $	 btn��5J      $��Выдать книгу��5K      $	��200��5L      $��2��5M      $��1��5N      $��40��5O      $��18(�5P      $��Impact)�5Q      $
��10 0q�5R      ���	#FFFEFFFA���	#FF000120$	 0.8Q�5U      5X      5Y      