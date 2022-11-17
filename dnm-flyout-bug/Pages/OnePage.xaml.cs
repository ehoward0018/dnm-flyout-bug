using dnm_flyout_bug.ViewModels;

namespace dnm_flyout_bug.Pages;

public partial class OnePage : ContentPage
{
	public OnePage(OnePageViewModel onePageViewModel)
	{
		InitializeComponent();
		BindingContext = onePageViewModel;
	}
}