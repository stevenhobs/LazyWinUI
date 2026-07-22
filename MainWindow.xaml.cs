namespace MyApp;

public partial class MainWindow
{
    public MainWindow()
    {
        this.InitializeComponent();
        (this.Title, this.Width, this.Height) = ("LazyWinUI", 800, 600);
        (this.MinWidth, this.MinHeight) = (600, 480);
        this.SetIcon("Assets/icons/app.ico");
        this.ExtendsContentIntoTitleBar = true;
        this.SetTitleBar(AppTitleBar);
        this.CenterOnScreen();
    }
}