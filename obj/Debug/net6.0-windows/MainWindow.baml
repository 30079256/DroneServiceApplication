   M S B A M L   `   `   `  ����G  CIcarusDrones, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:IcarusDronesIcarusDrones  5   	       IcarusDrones.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:IcarusDrones     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Drone Service Application��5	   	   $	��531��6+   $	��938��68   .��5
      � $	��490��6   $	��Top=�6   $��0,0,10,0q�60   .+�5   
   %  Xceed.Wpf.Toolkit.IntegerUpDown  -   5          Name$ IntegerUpDownServiceTag��5      �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   FormatString$ N0��6>   $��84,10,708,455q�6P   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   Value 1006g      	Increment 106s      Maximum 9006�   �� 5   
   -   5         ��Name$ TextBoxClientName��5      $
��Left=�6-   $��	84,44,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��22��6�   �� 5   
   -   5        $ TextBoxDroneModel��5      $
��Left=�6-   $��	84,78,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��22��6�   �� 5   
   -   5         ��Name$ LabelClientName��5      $��Client Name��6)   $
��Left=�6?   $��4,44,0,0q�6Z   $	��Top=�6l   �� 5   
   -   5        $ LabelDroneModel��5      $��Drone Model��6)   $
��Left=�6?   $��2,78,0,0q�6Z   $	��Top=�6l   �� 5   
   -   5        	 ��Name$	 GroupBoxServicePriority��5      $��Service Priority��64   $��77,109,708,293q�6N   .��5      �� -   5        
 ��Name$
 StackPanelServicePriority��5      $��58��6<   $��0,0,-2,0q�6H   .+�5      	� -   5         	�Name$ RadioButtonRegular��5      $��Regular��6:   $
��Left=�6L   $��	20,10,0,0q�6g   $��15��6z   $��67��6�    d� 	IsChecked$
 TrueY�6�   	� 5      -	   5        $ RadioButtonExpress��5      $��Express��6:   $
��Left=�6L   $��	20,10,0,0q�6g   $��20��6z   5      5      �� 5   
   -
   5        $ TextBoxServiceCost��5      $
��Left=�6.   $��
84,204,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   $��22��6�   6�   �� 5   
   -   5        $ LabelServiceCost��5      $��Service Cost��6*   $
��Left=�6A   $��	8,202,0,0q�6\   $	��Top=�6o    J� RenderTransformOrigin$ 0.130,0.619&�6�   �� 5   
   -   5        $ TextBoxServiceProblem��5      $
��Left=�61   $��
73,248,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��131��6�   $	��172��6�   �� 5   
   -   5        $ LabelServiceProblem��5      $��12,245,0,188q�6-   $
��Left=�6C   $��61��6^    � UseLayoutRounding$ False��6i   .��5      �� $��Service Problem��6   $
��Wrap=�6/   5      �� 5   
   -   5        $ LabelServiceTag��5      $��Service Tag��6)   $
��Left=�6?   $��12,9,0,0q�6Z   $	��Top=�6l   �� 5   
   -   5         ��Name$ ListViewRegularService��5      $��224,22,325,322q�63    �� View 5      �� 5       .P�5!      �� $	��Tag��6%    �� DisplayMemberBinding 62   �� *RegularServiceTag+�� 5"      $��Client Name��6%    6:   �� *RegularClientName+�� 5#      $��Drone Model��6%    6:   �� *RegularDroneModel+�� 5$      $
��Cost��6%    63   �� *RegularServiceCost+�� 5%      $��Service Problem��6%    6>   �� *RegularServiceProblem+5&      5(      �� 5)   
   -   5        $ ListViewExpressService��5)      $��224,262,325,77q�63    5*      �� 5+      .P�5,      �� $	��Tag��6%    62   �� *ExpressServiceTag+�� 5-      $��Client Name��6%    6:   �� *ExpressClientName+�� 5.      $��Drone Model��6%    6:   �� *ExpressDroneModel+�� 5/      $
��Cost��6%    63   �� *ExpressServiceCost+�� 50      $��Service Problem��6%    6>   �� *ExpressServiceProblem+51      53      �� 54   
   -   5         ��Name$ ButtonAddNewItem��54      $��Start Item Service��6+   $
��Left=�6H   $��
24,436,0,0q�6c   $	��Top=�6w   $��25��6�   $	��180��6�   6�   �� 55   
   -   5        $ LabelExpressService��55      $��Express Service Queue��6-   $
��Left=�6M   $��225,234,0,0q�6h   $	��Top=�6}   �� 56   
   -   5        $ LabelRegularService��56      $��Regular Service Queue��6-   $
��Left=�6M   $��
224,-4,0,0q�6h   $	��Top=�6|   �� 57   
   -   5        $  ButtonFinishExpressService��57      $��Finish Item Service��65   $
��Left=�6|   $��224,436,0,0q�6�   $	��Top=�6�   $��25��6�   $	��363��6�   6�   �� 58   
   -   5        $  ButtonFinishRegularService��58      $��Finish Item Service��65   $
��Left=�6|   $��224,185,0,0q�6�   $	��Top=�6�   $��25��6�   $	��363��6�   6�   �� 59   
   -   5         ��Name$ ListBoxFinishedItems��59      $��621,27,42,50q�60   6F   �� 5:   
   -   5        $ LabelFinishedItems��5:      $��Finished Service Items��6,   $
��Left=�6M   $��	621,0,0,0q�6h   $	��Top=�6{   �� 5;   
   $��Bottom=�6   .@�5<      �� .��5=      �� -   5         ��Name$ StatusLabelFeedback��5=      $�� ��69   5>      5?      5B      5C      