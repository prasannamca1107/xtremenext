using Microsoft.Maui.Platform;

namespace xtremenext
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            MauiWebView.Navigating += WebViewNavigating;
            MauiWebView.Navigated += WebViewNavigated;
        }
        // Event handler for when the WebView starts navigating to a new page
        private void WebViewNavigating(object sender, WebNavigatingEventArgs e)
        {
            // Show the loading indicator
            LoadingIndicator.IsVisible = true;
            LoadingIndicator.IsRunning = true;
        }

        // Event handler for when the WebView finishes navigating to a page
        private void WebViewNavigated(object sender, WebNavigatedEventArgs e)
        {
            // Hide the loading indicator
            LoadingIndicator.IsVisible = false;
            LoadingIndicator.IsRunning = false;
        }


    }
}
