using Avalonia.Web.Blazor;

namespace UI.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        WebAppBuilder.Configure<UI.App>()
            .SetupWithSingleViewLifetime();
    }
}