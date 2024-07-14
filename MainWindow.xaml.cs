using Microsoft.UI.Xaml;

namespace ImagesMissingSample;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
    }


    private void NavigationView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
    {
        switch ((string)args.SelectedItemContainer.Content)
        {
            case "Page With List":
                Presenter.Navigate(typeof(PageWIthList));
                break;
            case "Page With Nothing":
                Presenter.Navigate(typeof(PageWithNothing));
                break;
        }
    }
}