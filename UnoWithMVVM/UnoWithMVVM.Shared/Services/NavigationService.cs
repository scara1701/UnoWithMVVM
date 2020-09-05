using System;
using UnoWithMVVM.Core;
using UnoWithMVVM.Core.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnoWithMVVM.Shared.Services
{
    public class NavigationService : INavigationService
    {
        public void GoBack()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
        }

        public void Navigate(ApplicationView sourcePage)
        {
            NavigateEventArgs args = new NavigateEventArgs();
            args.Page = sourcePage;
            OnNavigate(args);
        }

        //Event handler created in App.xaml.cs, used for navigating with serviceprovider
        public event EventHandler<NavigateEventArgs> NavigateEvent;

        protected virtual void OnNavigate(NavigateEventArgs e)
        {
            EventHandler<NavigateEventArgs> handler = NavigateEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public class NavigateEventArgs : EventArgs
        {
            public ApplicationView Page { get; set; }
        }
    }
}
