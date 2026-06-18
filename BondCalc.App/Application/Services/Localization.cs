using System.Globalization;
using System.Resources;

namespace BondCalc.App.Application.Services;

public static class Localization
{
    private static readonly ResourceManager _resources = new(
        "BondCalc.App.Resources.Strings",
        typeof(Localization).Assembly);

    public static ResourceManager Resources => _resources;

    public static string GetString(string key)
    {
        return _resources.GetString(key) ?? key;
    }

    public static void SetCulture(string cultureName)
    {
        var culture = new CultureInfo(cultureName);
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;
    }
}
