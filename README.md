# Paginator.Avalonia
[![nuget](https://img.shields.io/badge/10-nuget-blue)](https://www.nuget.org/packages/Paginator.Avalonia)

# Example

![](https://github.com/CreateLab/Paginator.Avalonia/blob/master/paginator.gif)

# How to use
Add `StyleInclude`
```xml
  <StyleInclude Source="avares://Paginator.Avalonia/View/PaginatorControl.xaml" />
```

Add Control
```xml
  <controls:PaginatorControl Name="PaginatorControl" Grid.Row="1" PageCount="7" PageNumb="{Binding CurrentPage,Mode=TwoWay}" />
```
