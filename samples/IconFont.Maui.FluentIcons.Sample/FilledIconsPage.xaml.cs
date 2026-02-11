using IconFont.Maui.FluentIcons.Sample.ViewModels;

namespace IconFont.Maui.FluentIcons.Sample;

public partial class FilledIconsPage : ContentPage
{
	public FilledIconsPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel("FluentIconsFilled");
	}
}
