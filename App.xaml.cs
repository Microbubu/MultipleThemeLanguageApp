using MultipleThemeLanguageApp.Resources;
using System.Linq;
using System.Windows;

namespace MultipleThemeLanguageApp;

/// <summary>
/// App.xaml 的交互逻辑
/// </summary>
public partial class App : Application
{
    public void ChangeTheme(string themeName)
    {
        var theme = Resources.MergedDictionaries.FirstOrDefault(r => r is ThemeResourceDictionary);
        if (theme is null) return;
        (theme as ThemeResourceDictionary).Update(themeName);
    }

    public void ChangeLanguage(string language)
    {
        var translation = Resources.MergedDictionaries.FirstOrDefault(r => r is TranslationResourceDictionary);
        if (translation is null) return;
        (translation as TranslationResourceDictionary).Update(language);
    }
}
