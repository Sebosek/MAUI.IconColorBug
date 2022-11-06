namespace BackIconColor;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(BugPage), typeof(BugPage));
    }
}