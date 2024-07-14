using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace ImagesMissingSample;

public class StringImageBrushConverter : IValueConverter
{
    readonly Brush placeholderBrush = new LinearGradientBrush([
        new GradientStop() { Color = Color.FromArgb(144, 96, 96, 96), Offset = 0 },
        new GradientStop() { Color = Color.FromArgb(10, 96, 96, 96), Offset = 1 },
        ], 45);


    public object Convert(object value, Type targetType, object parameter, string language) =>
        value is string imageUrl ? new ImageBrush() { ImageSource = new BitmapImage(new(imageUrl)) } : placeholderBrush;

    public object ConvertBack(object value, Type targetType, object parameter, string language) =>
        throw new NotImplementedException();
}