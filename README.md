# Paginator.Avalonia
![nuget](https://www.nuget.org/packages/Paginator.Avalonia)

# How to use
Add `StyleInclude`
```xml
  <StyleInclude Source="avares://Paginator.Avalonia/View/PaginatorControl.xaml" />
```

Add Control
```xml
  <controls:PaginatorControl Name="PaginatorControl" Grid.Row="1" PageCount="7" PageNumb="{Binding CurrentPage,Mode=TwoWay}" />
```
