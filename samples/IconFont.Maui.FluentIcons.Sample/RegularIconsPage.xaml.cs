using IconFont.Maui.FluentIcons.Sample.ViewModels;

namespace IconFont.Maui.FluentIcons.Sample;

public partial class RegularIconsPage : ContentPage
{
	public RegularIconsPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel("FluentIcons");
	}
}
