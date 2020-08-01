# Paginator.Avalonia
![nuget](https://www.nuget.org/packages/Paginator.Avalonia)

# Example

https://github.com/CreateLab/Paginator.Avalonia/blob/master/paginator.gif

# How to use
Add `StyleInclude`
```xml
  <StyleInclude Source="avares://Paginator.Avalonia/View/PaginatorControl.xaml" />
```

Add Control
```xml
  <controls:PaginatorControl Name="PaginatorControl" Grid.Row="1" PageCount="7" PageNumb="{Binding CurrentPage,Mode=TwoWay}" />
```
