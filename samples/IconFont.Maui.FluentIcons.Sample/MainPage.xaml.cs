using IconFont.Maui.FluentIcons.Sample.ViewModels;

namespace IconFont.Maui.FluentIcons.Sample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel();
	}
}
