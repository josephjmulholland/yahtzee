   M S B A M L   `   `   `  ����B  >Yahtzee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:YahtzeeYahtzee  5   	       Yahtzee.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Yahtzee     5   	   -   5          � Title$  
MainWindow��5   	   $��733.943��6   $��514.404��6-   .��5	      � .+�5
   
   �� -   5         ��Name$
 img1��5
      $
��Left=�6   $��91��69   $	��Top=�6E   $��91��6]   $��	10,10,0,0q�6h   �� 5   
   -   5        $
 img2��5      $
��Left=�6   $��91��69   $��
109,10,0,0q�6E   $	��Top=�6Y   $��91��6q   �� 5   
   -   5        $
 img3��5      $
��Left=�6   $��91��69   $��
208,10,0,0q�6E   $	��Top=�6Y   $��91��6q   �� 5   
   -   5        $
 img4��5      $
��Left=�6   $��91��69   $��
307,10,0,0q�6E   $	��Top=�6Y   $��91��6q   �� 5   
   -   5        $
 img5��5      $
��Left=�6   $��91��69   $��
405,10,0,0q�6E   $	��Top=�6Y   $��91��6q   �� 5   
   -   5         ��Name$ txtOnes1��5      $
��Left=�6&   $��23��6A   $��
28,120,0,0q�6M   $
��Wrap=�6a   $��Ones:��6u   $	��Top=�6�   $	��200��6�    J� OpacityMask �	#FF4420206�   �� 5   
   -   5        $ txtOnes2��5      $
��Left=�6&   $��23��6A   $��271,120,0,0q�6M   $
��Wrap=�6b   $��Ones:��6v   $	��Top=�6�   $	��200��6�   �� 5   
   -	   5        $ txtTwos1��5      $
��Left=�6&   $��23��6A   $��
28,143,0,0q�6M   $
��Wrap=�6a   $��Twos:��6u   $	��Top=�6�   $	��200��6�   �� 5   
   -
   5        $ txtTwos2��5      $
��Left=�6&   $��23��6A   $��271,143,0,0q�6M   $
��Wrap=�6b   $��Twos:��6v   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 
txtThrees1��5      $
��Left=�6(   $��23��6C   $��
28,166,0,0q�6O   $
��Wrap=�6c   $��Threes:��6w   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 
txtThrees2��5      $
��Left=�6(   $��23��6C   $��271,166,0,0q�6O   $
��Wrap=�6d   $��Threes:��6x   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtFours1��5      $
��Left=�6'   $��23��6B   $��
28,189,0,0q�6N   $
��Wrap=�6b   $��Fours:��6v   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtFours2��5      $
��Left=�6'   $��23��6B   $��271,189,0,0q�6N   $
��Wrap=�6c   $��Fours:��6w   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtFives1��5      $
��Left=�6'   $��23��6B   $��
28,212,0,0q�6N   $
��Wrap=�6b   $��Fives:��6v   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtFives2��5      $
��Left=�6'   $��23��6B   $��271,212,0,0q�6N   $
��Wrap=�6c   $��Fives:��6w   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtSixes1��5      $
��Left=�6'   $��23��6B   $��
28,235,0,0q�6N   $
��Wrap=�6b   $��Sixes:��6v   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtSixes2��5      $
��Left=�6'   $��23��6B   $��271,235,0,0q�6N   $
��Wrap=�6c   $��Sixes:��6w   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtTotal1��5      $
��Left=�6'   $��23��6B   $��
28,268,0,0q�6N   $
��Wrap=�6b   $��TOTAL:��6v   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtTotal2��5      $
��Left=�6'   $��23��6B   $��271,268,0,0q�6N   $
��Wrap=�6c   $��TOTAL:��6w   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtBonus1��5      $
��Left=�6'   $��23��6B   $��
28,291,0,0q�6N   $
��Wrap=�6b   $��Bonus (>=63):��6v   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ 	txtBonus2��5      $
��Left=�6'   $��23��6B   $��271,291,0,0q�6N   $
��Wrap=�6c   $��Bonus (>=63):��6w   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $ txtTotalUpper1��5      $
��Left=�6,   $��23��6G   $��
28,314,0,0q�6S   $
��Wrap=�6g   $��UPPER TOTAL:��6{   $	��Top=�6�   $	��200��6�   �� 5    
   -   5        $ txtTotalUpper2��5       $
��Left=�6,   $��23��6G   $��271,314,0,0q�6S   $
��Wrap=�6h   $��UPPER TOTAL:��6|   $	��Top=�6�   $	��200��6�   �� 5!   
   -   5        $ txt3OfAKind1��5!      $
��Left=�6*   $��23��6E   $��
28,347,0,0q�6Q   $
��Wrap=�6e   $��3 of a Kind:��6y   $	��Top=�6�   $	��200��6�   �� 5"   
   -   5        $ txt3OfAKind2��5"      $
��Left=�6*   $��23��6E   $��271,347,0,0q�6Q   $
��Wrap=�6f   $��3 of a Kind:��6z   $	��Top=�6�   $	��200��6�   �� 5#   
   -   5        $ txt4OfAKind1��5#      $
��Left=�6*   $��23��6E   $��
28,370,0,0q�6Q   $
��Wrap=�6e   $��4 of a Kind:��6y   $	��Top=�6�   $	��200��6�   �� 5$   
   -   5        $ txt4OfAKind2��5$      $
��Left=�6*   $��23��6E   $��271,370,0,0q�6Q   $
��Wrap=�6f   $��4 of a Kind:��6z   $	��Top=�6�   $	��200��6�   �� 5%   
   -   5        $ txtFullHouse1��5%      $
��Left=�6+   $��23��6F   $��
28,393,0,0q�6R   $
��Wrap=�6f   $��Full House:��6z   $	��Top=�6�   $	��201��6�   �� 5&   
   -   5        $ txtFullHouse2��5&      $
��Left=�6+   $��23��6F   $��271,393,0,0q�6R   $
��Wrap=�6g   $��Full House:��6{   $	��Top=�6�   $	��200��6�   �� 5'   
   -   5        $ txtSmallStr1��5'      $
��Left=�6*   $��23��6E   $��
28,416,0,0q�6Q   $
��Wrap=�6e   $��Small Straight:��6y   $	��Top=�6�   $	��200��6�   �� 5(   
   -    5        $ txtLargeStr1��5(      $
��Left=�6*   $��23��6E   $��
28,439,0,0q�6Q   $
��Wrap=�6e   $��Large Straight:��6y   $	��Top=�6�   $	��200��6�   �� 5)   
   -!   5        $ txtSmallStr2��5)      $
��Left=�6*   $��23��6E   $��271,416,0,0q�6Q   $
��Wrap=�6f   $��Small Straight:��6z   $	��Top=�6�   $	��200��6�   �� 5*   
   -"   5        $ txtLargeStr2��5*      $
��Left=�6*   $��23��6E   $��271,439,0,0q�6Q   $
��Wrap=�6f   $��Large Straight:��6z   $	��Top=�6�   $	��200��6�   �� 5+   
   -#   5        $ txtYahtzee1��5+      $
��Left=�6)   $��23��6D   $��
28,462,0,0q�6P   $
��Wrap=�6d   $��	YAHTZEE!:��6x   $	��Top=�6�   $	��200��6�   �� 5,   
   -$   5        $ txtYahtzee2��5,      $
��Left=�6)   $��23��6D   $��271,462,0,0q�6P   $
��Wrap=�6e   $��	YAHTZEE!:��6y   $	��Top=�6�   $	��200��6�   �� 5-   
   -%   5         ��Name$ chkBonus1Y1��5-      $��CheckBox��6(   $
��Left=�6;   $��
10,485,0,0q�6V   $	��Top=�6j   $��15��6�    J� RenderTransformOrigin$ 
1.046,-3.6&�6�   �� 5.   
   -&   5        $ chkBonus2Y1��5.      $��CheckBox��6(   $
��Left=�6;   $��
30,485,0,0q�6V   $	��Top=�6j   $��15��6�   $ 
1.046,-3.6&�6�   �� 5/   
   -'   5        $ chkBonus3Y1��5/      $��CheckBox��6(   $
��Left=�6;   $��
50,485,0,0q�6V   $	��Top=�6j   $��15��6�   $ 
1.046,-3.6&�6�   �� 50   
   -(   5        $ chkBonus1Y2��50      $��CheckBox��6(   $
��Left=�6;   $��253,485,0,0q�6V   $	��Top=�6k   $��15��6�   $ 
1.046,-3.6&�6�   �� 51   
   -)   5        $ chkBonus2Y2��51      $��CheckBox��6(   $
��Left=�6;   $��273,485,0,0q�6V   $	��Top=�6k   $��15��6�   $ 
1.046,-3.6&�6�   �� 52   
   -*   5        $ chkBonus3Y2��52      $��CheckBox��6(   $
��Left=�6;   $��293,485,0,0q�6V   $	��Top=�6k   $��15��6�   $ 
1.046,-3.6&�6�   �� 53   
   -+   5        $ 
txtChance1��53      $
��Left=�6(   $��23��6C   $��
28,500,0,0q�6O   $
��Wrap=�6c   $��Chance:��6w   $	��Top=�6�   $	��200��6�   �� 54   
   -,   5        $ 
txtChance2��54      $
��Left=�6(   $��23��6C   $��271,500,0,0q�6O   $
��Wrap=�6d   $	��Top=�6x   $	��200��6�   �� 6�   $�Chance:��6�   6�   �� 55   
   --   5        $ txtLowerTotal1��55      $
��Left=�6,   $��23��6G   $��
27,533,0,0q�6S   $
��Wrap=�6g   $��LOWER TOTAL:��6{   $	��Top=�6�   $	��200��6�   �� 56   
   -.   5        $ txtLowerTotal2��56      $
��Left=�6,   $��23��6G   $��271,533,0,0q�6S   $
��Wrap=�6h   $��LOWER TOTAL:��6|   $	��Top=�6�   $	��200��6�   �� 57   
   -/   5        $ txtUpperTotal1��57      $
��Left=�6,   $��23��6G   $��
27,556,0,0q�6S   $
��Wrap=�6g   $��UPPER TOTAL:��6{   $	��Top=�6�   $	��200��6�   �� 58   
   -0   5        $ txtUpperTotal2��58      $
��Left=�6,   $��23��6G   $��271,556,0,0q�6S   $
��Wrap=�6h   $��UPPER TOTAL:��6|   $	��Top=�6�   $	��200��6�   �� 59   
   -1   5        $ txtCombined1��59      $
��Left=�6*   $��23��6E   $��
27,579,0,0q�6Q   $
��Wrap=�6e   $��	COMBINED:��6y   $	��Top=�6�   $	��200��6�   �� 5:   
   -2   5        $ txtCombined2��5:      $
��Left=�6*   $��23��6E   $��271,579,0,0q�6Q   $
��Wrap=�6f   $��	COMBINED:��6z   $	��Top=�6�   $	��200��6�   �� 5;   
   -3   5         ��Name$ btnRoll��5;      $
��Roll��6"   $
��Left=�61   $��84��6L   $��
10,607,0,0q�6X   $	��Top=�6l   $	��170��6�   �� 5<   
   -4   5        $ btnScore��5<      $��Score��6#   $
��Left=�63   $��84��6N   $��185,607,0,0q�6Z   $	��Top=�6o   $	��170��6�   	� 5=   
   -5   5         	�Name$ rdoOnes1��5=      $��RadioButton��6(   $
��Left=�6>   $��13��6Y   $��
10,121,0,0q�6e   $	��Top=�6y   $��13��6�   	� 5>   
   -6   5        $ rdoTwos1��5>      $��RadioButton��6(   $
��Left=�6>   $��13��6Y   $��
10,144,0,0q�6e   $	��Top=�6y   $��13��6�   	� 5?   
   -7   5        $ 
rdoThrees1��5?      $��RadioButton��6*   $
��Left=�6@   $��13��6[   $��
10,167,0,0q�6g   $	��Top=�6{   $��13��6�   	� 5@   
   -8   5        $ 	rdoFours1��5@      $��RadioButton��6)   $
��Left=�6?   $��13��6Z   $��
10,190,0,0q�6f   $	��Top=�6z   $��13��6�   	� 5A   
   -9   5        $ 	rdoFives1��5A      $��RadioButton��6)   $
��Left=�6?   $��13��6Z   $��
10,213,0,0q�6f   $	��Top=�6z   $��13��6�   	� 5B   
   -:   5        $ 	rdoSixes1��5B      $��RadioButton��6)   $
��Left=�6?   $��13��6Z   $��
10,236,0,0q�6f   $	��Top=�6z   $��13��6�   	� 5C   
   -;   5        $ rdo4OfAKind1��5C      $��RadioButton��6,   $
��Left=�6B   $��13��6]   $��
10,371,0,0q�6i   $	��Top=�6}   $��13��6�   	� 5D   
   -<   5        $ rdo3OfAKind1��5D      $��RadioButton��6,   $
��Left=�6B   $��13��6]   $��
10,348,0,0q�6i   $	��Top=�6}   $��13��6�   	� 5E   
   -=   5        $ rdoFullHouse1��5E      $��RadioButton��6-   $
��Left=�6C   $��13��6^   $��
10,394,0,0q�6j   $	��Top=�6~   $��13��6�   	� 5F   
   ->   5        $ rdoSmallStr1��5F      $��RadioButton��6,   $
��Left=�6B   $��13��6]   $��
10,417,0,0q�6i   $	��Top=�6}   $��13��6�   	� 5G   
   -?   5        $ rdoLargeStr1��5G      $��RadioButton��6,   $
��Left=�6B   $��13��6]   $��
10,440,0,0q�6i   $	��Top=�6}   $��13��6�   	� 5H   
   -@   5        $ rdoYahtzee1��5H      $��RadioButton��6+   $
��Left=�6A   $��13��6\   $��
10,463,0,0q�6h   $	��Top=�6|   $��13��6�   	� 5I   
   -A   5        $ 
rdoChance1��5I      $��RadioButton��6*   $
��Left=�6@   $��13��6[   $��
10,501,0,0q�6g   $	��Top=�6{   $��13��6�   	� 5J   
   -B   5        $ rdoOnes2��5J      $��RadioButton��6(   $
��Left=�6>   $��13��6Y   $��253,121,0,0q�6e   $	��Top=�6z   $��13��6�   	� 5K   
   -C   5        $ rdoTwos2��5K      $��RadioButton��6(   $
��Left=�6>   $��13��6Y   $��253,144,0,0q�6e   $	��Top=�6z   $��13��6�   	� 5L   
   -D   5        $ 
rdoThrees2��5L      $��RadioButton��6*   $
��Left=�6@   $��13��6[   $��253,167,0,0q�6g   $	��Top=�6|   $��13��6�   	� 5M   
   -E   5        $ 	rdoFours2��5M      $��RadioButton��6)   $
��Left=�6?   $��13��6Z   $��253,190,0,0q�6f   $	��Top=�6{   $��13��6�   	� 5N   
   -F   5        $ 	rdoFives2��5N      $��RadioButton��6)   $
��Left=�6?   $��13��6Z   $��253,213,0,0q�6f   $	��Top=�6{   $��13��6�   	� 5O   
   -G   5        $ 	rdoSixes2��5O      $��RadioButton��6)   $
��Left=�6?   $��13��6Z   $��253,236,0,0q�6f   $	��Top=�6{   $��13��6�   	� 5P   
   -H   5        $ rdo4OfAKind2��5P      $��RadioButton��6,   $
��Left=�6B   $��13��6]   $��253,371,0,0q�6i   $	��Top=�6~   $��13��6�   	� 5Q   
   -I   5        $ rdo3OfAKind2��5Q      $��RadioButton��6,   $
��Left=�6B   $��13��6]   $��253,348,0,0q�6i   $	��Top=�6~   $��13��6�   	� 5R   
   -J   5        $ rdoFullHouse2��5R      $��RadioButton��6-   $
��Left=�6C   $��13��6^   $��253,394,0,0q�6j   $	��Top=�6   $��13��6�   	� 5S   
   -K   5        $ rdoSmallStr2��5S      $��RadioButton��6,   $
��Left=�6B   $��13��6]   $��253,417,0,0q�6i   $	��Top=�6~   $��13��6�   	� 5T   
   -L   5        $ rdoLargeStr2��5T      $��RadioButton��6,   $
��Left=�6B   $��13��6]   $��253,440,0,0q�6i   $	��Top=�6~   $��13��6�   	� 5U   
   -M   5        $ rdoYahtzee2��5U      $��RadioButton��6+   $
��Left=�6A   $��13��6\   $��253,463,0,0q�6h   $	��Top=�6}   $��13��6�   	� 5V   
   -N   5        $ 
rdoChance2��5V      $��RadioButton��6*   $
��Left=�6@   $��13��6[   $��253,501,0,0q�6g   $	��Top=�6|   $��13��6�   �� 5W   
   -O   5        $ txtBonusYahtzee1��5W      $
��Left=�6.   $��21��6I   $��
70,484,0,0q�6U   $
��Wrap=�6i   $��Bonus Yahtzee:��6}   $	��Top=�6�   $	��178��6�   �� 5X   
   -P   5        $ txtBonusYahtzee2��5X      $
��Left=�6.   $��21��6I   $��313,484,0,0q�6U   $
��Wrap=�6j   $��Bonus Yahtzee:��6~   $	��Top=�6�   $	��183��6�   �� 5Y   
   -Q   5        $ btnCrossOff��5Y      $��	Cross Off��6&   $
��Left=�6:   $��84��6U   $��360,607,0,0q�6a   $	��Top=�6v   $	��125��6�   {�.   J� Opacity$ 0Q�6�   5[      5\      