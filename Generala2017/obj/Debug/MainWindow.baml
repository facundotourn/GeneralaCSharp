   M S B A M L   `   `   `  ����G  CGenerala2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Generala2017Generala2017  5   	       Generala2017.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Generala2017     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��900��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ dado1TextBox��5
      $
��Left=�6(   $��40��6C   $��	10,79,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $��40��6�    �� TextAlignment$ Center=�6�   $��20(�6�    �� 
IsReadOnly . 6�   �� 5   
   -   5        $ dado2TextBox��5      $
��Left=�6(   $��40��6C   $��	55,79,0,0q�6O   $
 Wrap=�6b   $	��Top=�6v   $��40��6�   $ Center=�6�   $��20(�6�    . 6�   �� 5   
   -   5        $ dado3TextBox��5      $
��Left=�6(   $��40��6C   $��
100,79,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $��40��6�   $ Center=�6�   $��20(�6�    . 6�   �� 5   
   -   5        $ dado4TextBox��5      $
��Left=�6(   $��40��6C   $��
145,79,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $��40��6�   $ Center=�6�   $��20(�6�    . 6�   �� 5   
   -   5        $ dado5TextBox��5      $
��Left=�6(   $��40��6C   $��
190,79,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $��40��6�   $ Center=�6�   $��20(�6�    . 6�   �� 5   
   -   5         ��Name$ dado1CheckBox��5      $��CheckBox��6*   $
��Left=�6=   $��18��6X   $��
22,124,0,0q�6d   $	��Top=�6x   $��17��6�   {�.  6�   �� 5   
   -   5        $ dado2CheckBox��5      $��CheckBox��6*   $
��Left=�6=   $��18��6X   $��
66,124,0,0q�6d   $	��Top=�6x   $��17��6�   {�.  6�   �� 5   
   -   5        $ dado3CheckBox��5      $��CheckBox��6*   $
��Left=�6=   $��18��6X   $��112,124,0,0q�6d   $	��Top=�6y   $��17��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   {�.  6�   �� 5   
   -	   5         ��Name$ startButton��5      $��Iniciar turno��6&   $
��Left=�6>   $��28��6Y   $��
790,10,0,0q�6e   $	��Top=�6y   $��92��6�   6�   �� 5   
   -
   5        $ tirarDadosButton��5      $��Tirar dados��6+   $
��Left=�6A   $��28��6\   $��
790,43,0,0q�6h   $	��Top=�6|   $��92��6�   {�.  6�   �� 5   
   -   5        $ dado4CheckBox��5      $�� ��6*   $
��Left=�65   $��18��6P   $��154,124,0,0q�6\   $	��Top=�6q   $��22��6�   {�.  6�   �� 5   
   -   5        $ dado5CheckBox��5      $�� ��6*   $
��Left=�65   $��18��6P   $��199,124,0,0q�6\   $	��Top=�6q   $��22��6�   {�.  6�   �� 5   
   -   5         ��Name$ tirosTextBox��5      $
��Left=�6*   $��73��6E   $��
10,156,0,0q�6Q   $
��Wrap=�6e   $	��Top=�6y   $	��247��6�   �� 5   
   -   5        $ anotarButton��5      $��Anotar��6'   $
��Left=�68   $��28��6S   $��
790,76,0,0q�6_   $	��Top=�6s   $��92��6�   {�.  6�   �� 5   
   -   5        $ 	unoButton��5      $��1��6$   $
��Left=�60   $��30��6K   $��
15,236,0,0q�6W   $	��Top=�6k   $��80��6�   {�.  6�   �� 5   
   -   5        $ 	dosButton��5      $��2��6$   $
��Left=�60   $��30��6K   $��100,236,0,0q�6W   $	��Top=�6l   $��80��6�   {�.  6�   �� 5   
   -   5        $ 
tresButton��5      $��3��6%   $
��Left=�61   $��30��6L   $��185,236,0,0q�6X   $	��Top=�6m   $��80��6�   {�.  6�   �� 5   
   -   5        $ cuatroButton��5      $��4��6'   $
��Left=�63   $��30��6N   $��270,236,0,0q�6Z   $	��Top=�6o   $��80��6�   {�.  6�   �� 5   
   -   5        $ cincoButton��5      $��5��6&   $
��Left=�62   $��30��6M   $��355,236,0,0q�6Y   $	��Top=�6n   $��80��6�   {�.  6�   �� 5   
   -   5        $ 
seisButton��5      $��6��6%   $
��Left=�61   $��30��6L   $��440,236,0,0q�6X   $	��Top=�6m   $��80��6�   {�.  6�   �� 5   
   -   5        $ escaleraButton��5      $��Escalera��6)   $
��Left=�6<   $��30��6W   $��
15,271,0,0q�6c   $	��Top=�6w   $��80��6�   {�.  6�   �� 5   
   -   5        $ 
fullButton��5      $
��Full��6%   $
��Left=�64   $��30��6O   $��100,271,0,0q�6[   $	��Top=�6p   $��80��6�   {�.  6�   �� 5    
   -   5        $ pokerButton��5       $��Póker��6&   $
��Left=�66   $��30��6Q   $��185,271,0,0q�6]   $	��Top=�6r   $��80��6�   {�.  6�   �� 5!   
   -   5        $ generalaButton��5!      $��Generala��6)   $
��Left=�6<   $��30��6W   $��270,271,0,0q�6c   $	��Top=�6x   $��80��6�   {�.  6�   � 5"   
   $
��Left=�6   $	��100��6*   $��629,366,0,0q�67   $	��Top=�6L   $	��100��6d   5$      5%      