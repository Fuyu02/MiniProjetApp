   M S B A M L   `   `   `  ����Q  MAppliWPF-BDD-Personels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AppliWPF_BDD_PersonelsAppliWPF_BDD_Personels  5   	   '    !AppliWPF_BDD_Personels.GestionBDD   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:AppliWPF_BDD_Personels     5   	     � Title$  
GestionBDD��5   	   $	��500��6   $	��450��6)   $	��500��65   $	��450��6E   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��169* �6   �� 5      $
��156* �6   �� 5      $	��79* �6   �� 5      $	��80* �6   .+�5   
   �� -   5         ��Name$ 	LbladIPv4��5      $!��Adresse IPv4 du serveur BDD��6#   $
��Left=�6I   $��29��6d   $��	37,66,0,0q�6p   $	��Top=�6�   $	��188��6�   �� 5   
   -   5        $ Lblportecoute��5      $#��Port d'écoute du service BDD��6'   $
��Left=�6N   $��31��6i   $��
37,112,0,0q�6u   $	��Top=�6�   $	��188��6�   �� 5   
   -   5        $ Lbllogin��5      $(��"Login du compte d'accès à la BDD��6"   $
��Left=�6M   $��30��6h   $��	37,37,0,0q�6t   $	��Top=�6�   $	��207��6�   $��1��6�   �� 5   
   -   5        $ Lblmdp��5      $��Mot de passe��6    $
��Left=�67   $��33��6R   $��	37,90,0,0q�6^   $	��Top=�6q   $	��140��6�   $��1��6�   �� 5   
   -   5        $ 	LblnomBDD��5      $��Nom de la BDD��6#   $
��Left=�6;   $��28��6V   $��	37,21,0,0q�6b   $	��Top=�6u   $	��140��6�   $��2��6�   G� 5   
   -   5         G�Name$ PwdBmdp��5      $
��Left=�6'   $��33��6B   $��
249,90,0,0q�6N   $	��Top=�6b   $	��163��6z   $��1��6�   �� 5   
   -   5         ��Name$ 
TxtBadIPV4��5      $
��Left=�6&   $��29��6A   $��
264,66,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��148��6�   �� 5   
   -   5        $ TxtBportecoute��5      $
��Left=�6*   $��31��6E   $��264,112,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��148��6�   �� 5   
   -	   5        $ 	TxtBlogin��5      $
��Left=�6%   $��30��6@   $��
249,37,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��163��6�   $��1��6�   �� 5   
   -
   5        $ 
TxtBnomBDD��5      $
��Left=�6&   $��28��6A   $��
225,21,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��187��6�   $��2��6�   �� 5   
   -   5         ��Name$ BtnModifier��5      $��Modifier��6&   $
��Left=�6P   $��23��6k   $��	66,24,0,0q�6w   $	��Top=�6�   $��82��6�   $��3��6�   �� 5   
   -   5        $ 
BtnAnnuler��5      $��Annuler��6%   $
��Left=�6P   $��23��6k   $��
264,24,0,0q�6w   $	��Top=�6�   $��97��6�   $��3��6�   5      5      