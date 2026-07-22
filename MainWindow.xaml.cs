namespace MyApp;

public partial class MainWindow
{
    public MainWindow()
    {
        this.SetIcon("Assets/icons/app.ico");
        this.ExtendsContentIntoTitleBar = true;
        this.SetTitleBar(AppTitleBar);
        this.CenterOnScreen();
        this.InitializeComponent();
    }
}