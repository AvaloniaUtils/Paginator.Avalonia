using System.Reactive;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using ReactiveUI;

namespace Paginator.Avalonia.View
{
    public class PaginatorControl : ContentControl
    {
        public PaginatorControl()
        {
            NextClickCommand = ReactiveCommand.Create(NextClick);
            PrevClickCommand = ReactiveCommand.Create(PrevClick);
            EndClickCommand = ReactiveCommand.Create(EndClick);
            BeginClickCommand = ReactiveCommand.Create(BeginClick);
        }

        public static readonly AvaloniaProperty<int> PageCountProperty =
            AvaloniaProperty.Register<PaginatorControl, int>(nameof(PageCount),defaultBindingMode:BindingMode.TwoWay);

        public int PageCount
        {
            get => GetValue(PageCountProperty);
            set
            {
                SetValue(PageCountProperty, value);
                SetPageInfo();
            }
        }

        public static readonly AvaloniaProperty<int> PageNumbProperty =
            AvaloniaProperty.Register<PaginatorControl, int>(nameof(PageNumb),defaultBindingMode:BindingMode.TwoWay);

        public int PageNumb
        {
            get => GetValue(PageNumbProperty);
            set
            {
                SetValue(PageNumbProperty, value);
                SetPageInfo();
            }
        }

        public static readonly AvaloniaProperty<string> PageInfoProperty =
            AvaloniaProperty.Register<PaginatorControl, string>(nameof(PageInfo));

        private string PageInfo
        {
            get => GetValue(PageInfoProperty);
            set => SetValue(PageInfoProperty, value);
        }

        private void SetPageInfo()
        {
            PageInfo = $"{PageNumb}..{PageCount}";
        }

        private void PageNumbChanged(int i)
        {
            if (PageNumb != i) PageNumb = 1;
        }
        public static readonly AvaloniaProperty<ReactiveCommand<Unit, Unit>> NextClickCommandProperty =
            AvaloniaProperty.Register<PaginatorControl, ReactiveCommand<Unit, Unit>>(nameof(NextClickCommand));

        public ReactiveCommand<Unit, Unit> NextClickCommand
        {
            get => GetValue(NextClickCommandProperty);
            set => SetValue(NextClickCommandProperty, value);
        }
        private void NextClick()
        {
            PageNumb = PageNumb < PageCount ? PageNumb + 1 : PageCount;
        }

        public static readonly AvaloniaProperty<ReactiveCommand<Unit, Unit>> PrevClickCommandProperty =
            AvaloniaProperty.Register<PaginatorControl, ReactiveCommand<Unit, Unit>>(nameof(PrevClickCommand));

        public ReactiveCommand<Unit, Unit> PrevClickCommand
        {
            get => GetValue(PrevClickCommandProperty);
            set => SetValue(PrevClickCommandProperty, value);
        }

        private void PrevClick()
        {
            PageNumb = PageNumb > 0 ? PageNumb - 1 : 0;
        }

        public static readonly AvaloniaProperty<ReactiveCommand<Unit, Unit>> EndClickCommandProperty =
            AvaloniaProperty.Register<PaginatorControl, ReactiveCommand<Unit, Unit>>(nameof(EndClickCommand));

        public ReactiveCommand<Unit, Unit> EndClickCommand
        {
            get => GetValue(EndClickCommandProperty);
            set => SetValue(EndClickCommandProperty, value);
        }

        private void EndClick()
        {
            PageNumb = PageCount;
        }

        public static readonly AvaloniaProperty<ReactiveCommand<Unit, Unit>> BeginClickCommandProperty =
            AvaloniaProperty.Register<PaginatorControl, ReactiveCommand<Unit, Unit>>(nameof(BeginClickCommand));

        public ReactiveCommand<Unit, Unit> BeginClickCommand
        {
            get => GetValue(BeginClickCommandProperty);
            set => SetValue(BeginClickCommandProperty, value);
        }

        private void BeginClick()
        {
            PageNumb = 0;
        }
    }
}