using CommunityToolkit.Mvvm.Input;

namespace dnm_flyout_bug.ViewModels
{
    public partial class OnePageViewModel
    {
        
        [RelayCommand]
        void SetFlyoutInvisible()
        {
            var item = (Application.Current as App).GetThree;
            item.FlyoutItemIsVisible = false;
        }
    }
}
