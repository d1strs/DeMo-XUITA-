   M S B A M L   `   `   `  ????K  GRentalPointCPKiO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RentalPointCPKiO.windowsRentalPointCPKiO.windows  5   	   E'clr-namespace:RentalPointCPKiO.ModelEDMRentalPointCPKiO.ModelEDM  5   	   (    "RentalPointCPKiO.windows.AdminPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:RentalPointCPKiO.windows     5   	   9model'clr-namespace:RentalPointCPKiO.ModelEDM     5   	     ? Title$  	AdminPage??5
   	   $	??450??6   $	??800??6(    ? WindowStartupLocation$ CenterScreen=?5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $	??500 ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??2??6"    ?? Orientation$ 
Horizontal=?66   
???????.+?5      ?? -   5        $??	IconStaff??5      $??70??6>   ??6%   ?? *Image+6>   ?? 5      $??|??6   $??Center=?6!   $??30(?6<   $
??Bold"?6J   $??0 0 0 5q?6\   ?? 5      -   5        $??fioStaff??5      $??Center=?6(   $??18(?6]   $??10 0 0 0q?6k   ??6C   ?? *
FullName+6k   ?? 5      $??|??6   $??Center=?6!   $??30(?6<   $
??Bold"?6J   $??10 0 0 5q?6\   ?? 5      -   5        $??	PostStaff??5      $??18(?6E   $??Center=?6S   $??10 0 0 0q?6n   ??6)   ?? *
Roles.Role+6n   5      ?? 5   
   -   5        $??buttonLogOut??5      
??? ? ?$
??Bold"?68   $??12(?6J   $??0q?6X   $??1??6l   $??0??6|   $??Log Out??6?   $??35??6?   $??55??6?   $??Right=?6?   $??0 0 15 0q?6?    ? 	Resources 5        ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 5!      " ??6   .?5"      ??  ?@??CornerRadius$ 15??65   5#      5$      5%      &   System.Windows.Controls.DataGrid  5'   
   $??1??6   $??0??6    5)      5*      