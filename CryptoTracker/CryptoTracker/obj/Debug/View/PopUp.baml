   M S B A M L   `   `   `  ????H  DCryptoTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CryptoTracker.ViewCryptoTracker.View  5   	   A%clr-namespace:CryptoTracker.ViewModelCryptoTracker.ViewModel  5   	        CryptoTracker.View.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CryptoTracker.View     5   	   4vm%clr-namespace:CryptoTracker.ViewModel     5   	     ? Title$  Cryptocurrency Info??5	   	   $	??180??6%   $	??350??62    ? 
ResizeMode$ NoResize=?6>    ? DataContext 5
      1  +CryptoTracker.ViewModel.MainWindowViewModel  5   
   6#   .??5      ? .+?5   
   ?? $??Name:??6   $
??Left=?6    $??	50,10,0,0q?6;   $	??Top=?6N   ?? 5   
   $?? ??6   $
??Left=?6   $??
100,10,0,0q?66   $	??Top=?6J   $	??120??6b   $??2??6n   ?? 5   
   $??Symbol:??6   $
??Left=?6"   $??	43,40,0,0q?6=   $	??Top=?6P   ?? 5   
   $?? ??6   $
??Left=?6   $??
100,40,0,0q?66   $	??Top=?6J   $	??120??6b   $??2??6n   ?? 5   
   $??Price:??6   $
??Left=?6!   $??	57,70,0,0q?6<   $	??Top=?6O   ?? 5   
   $?? ??6   $
??Left=?6   $??
100,70,0,0q?66   $	??Top=?6J   $	??120??6b   $??2??6n   ?? 5   
   $??24h-change:??6   $
??Left=?6&   $??
20,100,0,0q?6A   $	??Top=?6U   ?? 5   
   $?? ??6   $
??Left=?6   $??100,100,0,0q?66   $	??Top=?6K   $	??120??6c   $??2??6o   ?? 5   
   -   5        $
??Back??5      $
??Left=?6    $??250,100,0,0q?6;   $	??Top=?6P   6h   ?? 5   
   -   5        $??Get BTC??5      $
??Left=?6#   $??
250,60,0,0q?6>   $	??Top=?6R   6j   5      5      