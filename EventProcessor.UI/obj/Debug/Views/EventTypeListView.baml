   M S B A M L   `   `   `  ����S  OEventProcessor.UI, Version=0.1.6348.13995, Culture=neutral, PublicKeyToken=nullK*clr-namespace:EventProcessor.UI.ViewModelsEventProcessor.UI.ViewModels  5   	   /    )EventProcessor.UI.Views.EventTypeListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :VMs*clr-namespace:EventProcessor.UI.ViewModels     5   	   $	��648��5   	   $	��610��6     J� InputBindings  5
      �� 5   
   
 �� Key$ P��6    �� 	Modifiers$ Controlf�5       �� Command 5      �� *ProcessCommand+ � 	Resources 5         EventTypeTemplate��%�   &	        �� 5   
   .R�5      �� $��3q�6   
����  �._�5      �� .+�5      �� ��6    �� *Id+�� 5      ��6    �� *Name+5      5      5      5       � DataContext 5      5  /EventProcessor.UI.ViewModels.EventTypeViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       �� 5!      $	��430 �6   .+�5#   
   �� $��Stretch=�6    �� Orientation$ 
Horizontal=�63   $��0��6M   .+�5$      �� $��Delete��6   $��75��5&      ��5%      �� *DeleteCommand+5&      �� 5'      $��Update��6   $��75��5)      ��5(      �� *UpdateCommand+5)      �� 5*      $	��Add��6   $��75��5,      ��5+      �� *
AddCommand+5,      5/      �� 50   
   $��Right=�6   .+�51      �� $��Process��6   $��75��53      $��0��6"   ��52      �� *ProcessCommand+53   "   54      &   System.Windows.Controls.DataGrid  55   
   -   5          Name$ eventTypeDataGrid��55      	   AutoGenerateColumns	 .  
   SelectionMode$
 Single=�59      $	��200��5:      $��1��5;      $	��Top=�6    ��57      �� *
EventTypes+ �� SelectedItem 58      �� *SelectedEventType+   Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��5>   %      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 5?   %      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5=   %   �� *Id+5?   1     5@      $
 Name��5A   %   $	 300 5B   %    5@   %   �� *Name+5B   %   5D      �� 5F   
   $��2��5G      $	��top=�6   $��0,0,0,0q�67   ��5F      �� *ProcessedEventRules+��5H      �� 5I      .R�5J      �� $ 
Horizontal=�6!   .+�5K      �� ��6$   �� 5L      5M      5O      5P      5Q      