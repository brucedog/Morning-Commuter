using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;

namespace View.Views
{
    /// <summary>
    /// Interaction logic for TravelDirections.xaml
    /// </summary>
    public partial class TravelDirectionsView : Window
    {
        public TravelDirectionsView()
        {
            InitializeComponent();
        }

        private const int WmNclbuttondown = 0xA1;
        private const int MtCaption = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        
        private new void MouseDownEvent(object sender, MouseButtonEventArgs e)
        {
            ReleaseCapture();
            SendMessage(new WindowInteropHelper(this).Handle, WmNclbuttondown, MtCaption, 0);
        }
    }
}
