﻿#pragma checksum "..\..\..\..\Views\WeatherView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A0CA60ADD7CCD65CD44FB37737B677BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Caliburn.Micro;
using SampleViewModelData;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using View.Views;
using ViewModel.WpfHelpers;


namespace View.Views {
    
    
    /// <summary>
    /// WeatherView
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class WeatherView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox CurrentDescription;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CurrentTemp;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image WeatherImage;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TempUnit;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel WeatherDetailLables;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TodaysHighLabel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TodaysLowLabel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FeelsLikeLabel;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label HumidityLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RainTodayLabel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel WeatherDetailVables;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TodaysHighValue;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TodaysLowValue;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FeelsLikeValue;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label HumidityValue;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RainTodayValue;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\WeatherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProxyImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/View;component/views/weatherview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\WeatherView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CurrentDescription = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 2:
            this.CurrentTemp = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.WeatherImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.TempUnit = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.WeatherDetailLables = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.TodaysHighLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.TodaysLowLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.FeelsLikeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.HumidityLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.RainTodayLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.WeatherDetailVables = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 12:
            this.TodaysHighValue = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.TodaysLowValue = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.FeelsLikeValue = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.HumidityValue = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.RainTodayValue = ((System.Windows.Controls.Label)(target));
            return;
            case 17:
            this.ProxyImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

