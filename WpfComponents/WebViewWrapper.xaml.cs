using Microsoft.Extensions.DependencyInjection;

namespace WpfComponents;

/// <summary>
/// Interaction logic for WebViewWrapper.xaml
/// </summary>
public partial class WebViewWrapper
{
    public WebViewWrapper()
    {
        InitializeComponent();
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddWpfBlazorWebView();
        Resources.Add("services", serviceCollection.BuildServiceProvider());
    }
}