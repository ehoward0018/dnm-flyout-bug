namespace dnm_flyout_bug;

public partial class App : Application
{
	public FlyoutItem GetOne => One;
	public FlyoutItem GetTwo => Two;
	public FlyoutItem GetThree => Three;


	public App()
	{
		InitializeComponent();
	}
}
