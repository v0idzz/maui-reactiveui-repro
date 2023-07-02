namespace maui_reactiveui_repro;

public partial class MainPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        for (var i = 0; i < 8; i++)
        {
            Children.Add(new Page
            {
                ViewModel = new PageViewModel(i),
                Title = i.ToString()
            });
        }
    }
}