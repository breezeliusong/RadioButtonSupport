using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RadioButtonSupport
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            TopButton.Background = new SolidColorBrush(Colors.Blue);
        }


        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton bt = sender as RadioButton;
            if (bt.Name== "TopButton")
            {
                myFrame.Navigate(typeof(BlankPage1));
                bt.Background = new SolidColorBrush(Colors.Blue);
                MiddleButton.Background= new SolidColorBrush(Colors.White);
            }else if(bt.Name== "MiddleButton")
            {
                myFrame.Navigate(typeof(BlankPage2));
                bt.Background = new SolidColorBrush(Colors.Blue);
                TopButton.Background = new SolidColorBrush(Colors.White);
            }
        }
    }
}
