   M S B A M L   `   `   `  ????N  JWPF Training Week 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPF_Training_Week_1WPF_Training_Week_1  5   	   $    WPF_Training_Week_1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPF_Training_Week_1     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??109* ?6   ?? 5      $
??108* ?6    ? ColumnDefinitions 5   
   ?? 5      $
??124* ?6   ?? 5      $	??29* ?6   ?? 5      $
??247* ?6   .+?5   
   ?? $??COM PORT SETTINGS??6   $??
12,10,0,22q?6.   $
??Left=?6B   $	??282??6]   $??2??6i   .??5      ?? $	??176??6   .+?5      ? $??40??6   $??Center=?6(   .+?5      ?? $??	COM PORT:??6   $??Center=?60   $??Center=?6M   $??24??6h   $??85??6t   $??0,7,0,0q?6   ?? 5      -   5         ??Name$ comboBox_unoComPort??5      $??20??6<   $	??112??6H   $??0,12,0,0q?6T   5      ? 5      $??36??6   $??Center=?6(   .+?5      ?? $??BAUD RATE: ??6   $??Center=?62   $??Center=?6O   $??24??6j   $??85??6v   ?? 5      -   5        $ comboBox_unoBaudRate??5      $??20??6=   $	??112??6I   $??0,3,0,0q?6U   .@?5      ?? $
??9600??6'   ?? 5      $??38400??6'   ?? 5      $??57600??6'   ?? 5      $??115200??6'   5       5!      ]? 5"      $??41??6   $	??180??6(   ??.  $
??Left=?6J   $??45,0,0,0q?6e   .+?5#      ?? -   5         ??Name$ button_unoOpen??5#      $
??OPEN??65   $??80??6D   6O   ?? 5$      -   5        $ button_unoClose??5$      $??CLOSE??66   $
??79.8??6F   $??20,0,0,0q?6q   5%      ?? 5&      $??47??6   .+?5'      ? -   5         ?Name$ progressBar_uno??5'   "   $??24??6;   $	??270??6G   $??0,12,0,0q?6S   5(      5*      5+      ?? 5,   
   $??LED CONTROL??6   $??
12,10,0,10q?6(   $
??Left=?6<   $	??282??6W   $??1??6c   $??2??6p   .??5-      ]? ??.  $??39??6.   .+?5.      ?? -   5        $ button_ledTurnOn??5.      $??TURN ON??63   $	??109??6E   $??15,0,0,0q?6p   ?? 5/      -   5        $ button_ledTurnOff??5/      $??TURN OFF??64   $	??109??6G   $??20,0,0,0q?6s   50      51      ?? 52   
   $??2??6   $??Center=?6#   $	??186??6@   $??SERVO CONTROL??6M   $??0,10,0,0q?6d   $	??Top=?6v   $	??474??6?   .??53      ]? ??.  $??
112,15,0,0q?6.   $??84??6B   $	??Top=?6N   $
??Left=?6f   .+?54      ?? -   5         ??Name$ slider_degree??54       ? Minimum$ 0Q?60    ? Maximum$	 180Q?6<   $	??250??6J   $??25??6V   $??Center=?6b   $??Center=?6   $	??Top=?6?   $??0,30,0,0q?6?   6?   55      56      ?? 57   
   $??2??6   $	??0°??6    $
??Left=?6-   $??	84,66,0,0q?6H   $	??Top=?6[   ?? 58   
   $??2??6   $??180°??6    $
??Left=?6/   $??
400,66,0,0q?6J   $	??Top=?6^   ?? 59   
   -	   5        	 ??Name$	 textBox_degree??59      $??2??6*   $
??Left=?6:   $??112,145,0,0q?6U   
 ?? TextWrapping$

 Wrap=?6j   $??Type a Value Here??6~   $	??Top=?6?   $	??199??6?   $??27??6?   ?? 5:   
   -
   5        $ button_send??5:      $??2??6&   $
??SEND??66   $
??Left=?6E   $??331,145,0,0q?6`   $	??Top=?6u   $??55??6?   $??27??6?   6?   ?? 5;   
   -   5         ??Name$ textBlock_degree??5;      $??2??6.   $??Center=?6>   $??0,34,0,0q?6[   $
??Wrap=?6m   $??	DEGREE = ??6?   $	??Top=?6?    J? RenderTransformOrigin$ 0.563,0.416&?6?   5=      5>      