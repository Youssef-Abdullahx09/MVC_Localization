using Microsoft.Extensions.Localization;

namespace MVC_Globalization.Resources;

public class LocService
{
    private readonly IStringLocalizer<SharedResource> _localizer;

    public LocService(IStringLocalizer<SharedResource> localizer)
    {
        _localizer = localizer;
    }

    public string GetLocalizedString(string term)
    {
        return _localizer[term].Value;
    }
}
