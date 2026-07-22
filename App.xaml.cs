namespace MyApp;

public partial class App
{
    private MainWindow? _mainWindow;

    public App()

    {
        this.InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        _mainWindow = new MainWindow();
        _mainWindow.Activate();
    }

    public static new App Current => (App)Application.Current;
}