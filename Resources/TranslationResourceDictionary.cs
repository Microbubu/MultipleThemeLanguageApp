using System;
using System.Windows;

namespace MultipleThemeLanguageApp.Resources;

public class TranslationResourceDictionary : ResourceDictionary
{
    public TranslationResourceDictionary()
    {
        Source = new Uri("/Translations/en-us.xaml", UriKind.Relative);
    }

    public void Update(string language)
    {
        var languageUri = new Uri($@"\Translations\{language}.xaml", UriKind.Relative);
        Source = languageUri;
    }
}
