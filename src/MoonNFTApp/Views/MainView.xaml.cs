using MoonNFTApp.ViewModels;

namespace MoonNFTApp.Views;

public partial class MainView : ContentPage
{
    IDispatcherTimer _timer;
    int _artIndex01;
    int _artIndex02;
    int _artIndex03;

    public MainView(MainViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        _timer = Application.Current.Dispatcher.CreateTimer();
        _timer.Interval = TimeSpan.FromMilliseconds(1000);
        _timer.Tick += OnDispatcherTimer;
        _timer.IsRepeating = true;
        _timer.Start();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        _timer.Tick -= OnDispatcherTimer;
        _timer.Stop();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        HeaderShape02.WidthRequest = width + 20;
    }

    async void OnDispatcherTimer(object sender, EventArgs e)
    {
        var rnd = new Random();

        _artIndex01 += rnd.Next(10, 50);
        _artIndex02 += rnd.Next(10, 50);
        _artIndex03 += rnd.Next(10, 50);

        await UpdateScrollPositions(_artIndex01, _artIndex02, _artIndex03);
    }

    async Task UpdateScrollPositions(double scrollPosition1, double scrollPosition2, double scrollPosition3)
    {
        await ArtCollectionView01.ScrollToAsync(0, scrollPosition1, true);
        await ArtCollectionView02.ScrollToAsync(0, scrollPosition2, true);
        await ArtCollectionView03.ScrollToAsync(0, scrollPosition3, true);
    }
}