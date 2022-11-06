namespace BackIconColor;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnNavigateClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BugPage));
    }
}