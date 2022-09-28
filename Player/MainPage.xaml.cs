using Player.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Player
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        PlayerReport report;
        public MainPage()
        {
            this.InitializeComponent();
            this.report = new PlayerReport();
            this.listPlayers.ItemsSource = this.report.Get();
        }
        private void listTrainees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = this.listPlayers.SelectedItem as Players;
            this.Frame.Navigate(typeof(PlayerDetails), new PageNavParam { Id = selected.Id });
        }
    }
}
