namespace UnoWithMVVM.Core.Services
{
    public interface INavigationService
    {
        void Navigate(ApplicationView sourcePage);
        void GoBack();
    }
}
