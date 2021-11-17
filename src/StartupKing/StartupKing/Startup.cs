using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]
namespace StartupKing
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
					fonts.AddFont("fa-solid-900.ttf", "FontAwesome");
				});
		}
	}
}