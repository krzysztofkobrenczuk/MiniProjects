   M S B A M L   `   `   `  ����B  >WpfView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfView.ProductsWpfView.Products  5      7 clr-namespace:WpfView.ConvertersWpfView.Converters  5      S OProductInventory.Classes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulleHclr-namespace:ProductInventory.Classes;assembly=ProductInventory.ClassesProductInventory.Classes 5      )    #WpfView.Products.AddEditProductView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WpfView.Products     5      1conv clr-namespace:WpfView.Converters     5      \ClassesHclr-namespace:ProductInventory.Classes;assembly=ProductInventory.Classes     5        � 	Resources  5      >   8WpfView.Converters.NegatableBooleanToVisibilityConverter   VisConverter  NegVisConverter   Negate �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%  &	        &	      '�� 1       5   
   65     5   
    . 5   5   �� 5   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� #	 Z $2
 ,(Validation.Errors).CurrentItem.ErrorContent�5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   .+�5$   
   � -   5         �Name$ grid1��5$      $
��Left=�5%      $��	10,10,0,0q�5'      $	��Top=�5(       � DataContext 5&      �� *	Product+ � ColumnDefinitions 5*      �� 5+      $
��Auto �6#   �� 5,      $
��Auto �6#    5.      �� 5/      $
��Auto �6    �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      $
��Auto �6    .+�54      �� $��Name:��6   $��0��55      $
��Left=�56      $��3q�57      $��0��58      $��Center=�59      �� 5:      -   5         ��Name$ nameTextBox��5:      $��1��5;      $
��Left=�5<      $��23��5=      $��3q�5>      $��0��5?      $��Center=�5A      $	��120��5B      ��5@      �� *Name+" �� ValidatesOnNotifyDataErrors . 5B      �� 5C      $��Description:��6   $��0��5D      $
��Left=�5E      $��3q�5F      $��1��5G      $��Center=�5H      �� 5I      -   5        $ descriptionTextBox��5I      $��1��5J      $
��Left=�5K      $��23��5L      $��3q�5M      $��1��5N      $��Center=�5P      $	��120��5Q      ��5O      �� *Description+ . 5Q      �� 5R      $��Price:��6   $��0��5S      $
��Left=�5T      $��3q�5U      $��2��5V      $��Center=�5W      �� 5X      -   5        $ priceTextBox��5X      $��1��5Y      $
��Left=�5Z      $��23��5[      $��3q�5\      $��2��5]      $��Center=�5_      $	��120��5`      ��5^      �� *Price+ . 5`      �� 5a      $��	Category:��6   $��0��5b      $
��Left=�5c      $��3q�5d      $��3��5e      $��Center=�5f      �� 5g      -   5        $ categoryTextBox��5g      $��1��5h      $
��Left=�5i      $��23��5j      $��3q�5k      $��3��5l      $��Center=�5n      $	��120��5o      ��5m      �� *
CategoryId+ . 5o      5p      � 5r   
   $��1��6   .+�5s      �� $
��Save��6   $
��Left=�5v      $��25,5,0,0q�5w      $	��Top=�5x      $��75��5y      ��5t      �� *SaveCommand+y�5u      �� *
EditMode+ �� 	Converter# [  5y      �� 5z      $	��Add��6   $
��Left=�5}      $��25,5,0,0q�5~      $	��Top=�5      $��75��5�      ��5{      �� *SaveCommand+y�5|      �� *
EditMode+# [ 5�      �� 5�      $��Cancel��6   $
��Left=�5�      $��	150,5,0,0q�5�      $	��Top=�5�      $��75��5�      ��5�      �� *CancelCommand+5�      5�      5�      5�      