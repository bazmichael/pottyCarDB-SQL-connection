   M S B A M L   `   `   `  ����@  <Lab10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab10Lab10  5   	       Lab10.AddCarWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab10     5   	     � Title$  AddCarWindow��5   	   $	��448��6   $	��613��6+    � 
ResizeMode$ NoResize=�5	   	   .��5
      � $��	0,23,-6,0q�6    � ColumnDefinitions 5   
   �� 5      $
��259* �6   �� 5      $	��43* �6   �� 5      $
��492* �6   .+�5   
   �� -   5        $��Dodaj samochod
��5      $
��Left=�64   $��38.115,313,0,0q�6O   $	��Top=�6g   $	��164��6    J� RenderTransformOrigin$ -1.03,1.252&�6�   $��61��6�   $��2��6�   $��1��6�   �� 5   
   $��Wprowadz markę:  ��6   $
��Left=�6,   $	��Top=�6G   $��
33,105,0,0q�6_   $	��202��6s   $��3��6   �� 5   
   $��Wybierz date produkcji:��6   $
��Left=�62   $	��Top=�6M   $��
33,136,0,0q�6e   $	��202��6y   $��3��6�   �� 5   
   $��Wprowadz liczbę drzwi:  ��6   $
��Left=�63   $	��Top=�6N   $��
33,172,0,0q�6f   $	��202��6z   $��3��6�   �� 5   
   $%��Wprowadz numer rejestracyjny:  ��6   $
��Left=�6:   $	��Top=�6U   $��
33,205,0,0q�6m   $	��202��6�   $��3��6�   �� 5   
   -   5         ��Name$ tbLiczbaDrzwi��5      $
��Left=�6)   $��23��6D   $��	0,172,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��247��6�   $��2��6�   �� 5   
   -   5        $ tbNrRej��5      $
��Left=�6#   $��23��6>   $��	0,205,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��247��6�   $��2��6�   �� 5   
   -   5        $ 
tbPrzebieg��5      $
��Left=�6&   $��23��6A   $��	0,236,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��247��6�   $��2��6�   �� 5   
   $��Wprowadz przebieg:��6   $
��Left=�6-   $	��Top=�6H   $��
33,236,0,0q�6`   $	��202��6t   $��3��6�   �� 5   
   -   5        $ tbModel��5      $
��Left=�6#   $��23��6>   $��	0,105,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��247��6�   $��2��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePicker��5      $��2��6)   $
��Left=�69   $��	2,137,0,0q�6T   $	��Top=�6g   $	��245��6   5      5      