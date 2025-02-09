using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ImagesMissingSample;

public sealed partial class PageWIthList : Page
{
    public PageWIthList()
    {
        this.InitializeComponent();

        for (int i = 0; i < 100; i++)
        {
            ItemModel model = new($"https://cataas.com/cat/says/{i}", $"Number {i}");
            ItemModels.Add(model);
        }
    }


    public ObservableCollection<ItemModel> ItemModels { get; } = [];
}