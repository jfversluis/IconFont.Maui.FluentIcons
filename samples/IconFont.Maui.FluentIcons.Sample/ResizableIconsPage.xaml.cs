using IconFont.Maui.FluentIcons.Sample.ViewModels;

namespace IconFont.Maui.FluentIcons.Sample;

public partial class ResizableIconsPage : ContentPage
{
	public ResizableIconsPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel("FluentIconsResizable");
	}
}
