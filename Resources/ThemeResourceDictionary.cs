using System;
using System.Windows;

namespace MultipleThemeLanguageApp.Resources;

public class ThemeResourceDictionary : ResourceDictionary
{
    public ThemeResourceDictionary()
    {
        Source = new Uri("../Themes/Light.xaml", UriKind.Relative);
    }

    public void Update(string theme)
    {
        var themeUri = new Uri($"../Themes/{theme}.xaml", UriKind.Relative);
        Source = themeUri;
    }
}
