   M S B A M L   `   `   `  ����B  >WpfView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfView.ProductsWpfView.Products  5      S OProductInventory.Classes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulleHclr-namespace:ProductInventory.Classes;assembly=ProductInventory.ClassesProductInventory.Classes 5      &     WpfView.Products.ProductListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WpfView.Products     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  6S   VClassesHclr-namespace:ProductInventory.Classes;assembly=ProductInventory.Classes  5      .  (System.Windows.Interactivity.Interaction    Triggers  5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      >  8Microsoft.Expression.Interactivity.Core.CallMethodAction     
MethodName$ LoadProducts��6;      TargetObject 6"   �� 6;   5       � 	Resources 5         productViewSource��%   &	        �� 5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��Add Product��6   $��0��5!      $
��Left=�5"      ��5       �� *AddProductCommand+5"      �� 5#       �� Orientation$ 
Horizontal=�6   $��Right=�5$      $��1��5%      .+�5&      �� $��Search:��6   �� 5'      $	��150��5(      ��5'      �� *SearchInput+	 �� UpdateSourceTrigger$	 PropertyChanged=�5(      �� 5)      $��X��6   ��5*      �� *ClearSearchCommand+5+      5,      &   System.Windows.Controls.DataGrid  5-   
   
   AutoGenerateColumns
 .     CanUserAddRows .  $��1��50      ��5-      �� *
Products+   Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6%   �� *Name+6>     53      $ * 6E    6%   �� *Description+6E     54      $ * 6?    6%   �� *Price+6?     55      $ * 6D    6%   �� *
CategoryId+6D   4
  .System.Windows.Controls.DataGridTemplateColumn
  56      $
 Auto 6)    
  CellTemplate 57      �� 58      .R�59      �� $
��Edit��6%   $��5q�5=   %   ��5:   %   �� * DataContext.EditProductCommand+ �� RelativeSource ��  �� AncestorType"  ��5<   %   �� 5=   %   5>      5@      
  5A      $
 Auto 6)    5B      �� 5C      .R�5D      �� $��Delete��6%   $��5q�5H   %   ��5E   %   �� *" DataContext.DeleteProductCommand+ �� "  ��5G   %   �� 5H   %   5I      5K      5M      5N      5O      