using Microsoft.AspNetCore.Components;

namespace AzureTest.Client
{
    public class BasePage : ComponentBase
    {
        [Inject] public NavigationManager NavManager { get; set; }
    }
}
