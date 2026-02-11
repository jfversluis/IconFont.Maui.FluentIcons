using IconFont.Maui.FluentIcons.Sample.ViewModels;

namespace IconFont.Maui.FluentIcons.Sample;

public partial class LightIconsPage : ContentPage
{
	public LightIconsPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel("FluentIconsLight");
	}
}
