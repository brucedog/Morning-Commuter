using System.Windows;
using System.Windows.Controls;

namespace ViewModel.WpfHelpers
{
    public static class WebBrowserUtility
    {
        public static readonly DependencyProperty BodyProperty =
                DependencyProperty.RegisterAttached("Body", typeof(string), typeof(WebBrowserUtility), new PropertyMetadata(OnBodyChanged));

        public static string GetBody(DependencyObject dependencyObject)
        {
            return (string)dependencyObject.GetValue(BodyProperty);
        }

        public static void SetBody(DependencyObject dependencyObject, string body)
        {
            dependencyObject.SetValue(BodyProperty, body);
        }

        private static void OnBodyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var webBrowser = (WebBrowser)d;
            webBrowser.NavigateToString((string)e.NewValue);
        }
    }    
}