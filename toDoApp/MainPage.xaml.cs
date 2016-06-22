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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace toDoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage() {

            this.InitializeComponent();
            DataContext = MyViewModel.I();
            getViewModel().loadLocalSettings();
            NetworkProvider provider = new NetworkProvider();
            if (getViewModel().AllTasks == false) {
            provider.getOwnerTasks(getViewModel());
            }
        }
/*
        private void listViewButton_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ListViewPage));
        }

        private void gridViewButton_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(GridViewPage));
        }
*/
        // ------------

        private MyViewModel getViewModel() {
            return DataContext as MyViewModel;
        }


        private void OwnerOnTaskClick(object sender, RoutedEventArgs e) {

            NetworkProvider provider = new NetworkProvider();
            startProgressBar();
            provider.getOwnerTasks(getViewModel());
            stopProgressBar();
            this.Frame.Navigate(typeof(MainPage));

        }

        private void OnAllTaskClick(object sender, RoutedEventArgs e) {

            getViewModel().AllTasks = true;
            NetworkProvider provider = new NetworkProvider();
            startProgressBar();
            provider.getTasks(getViewModel());
            stopProgressBar();
            this.Frame.Navigate(typeof(MainPage));
        }

        private void AddClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(AddTaskPage));
        }


        private void LogoutClick(object sender, RoutedEventArgs e) {
            getViewModel().removeLocalSettings();
            DataContext = null;
            this.Frame.Navigate(typeof(LogInPage));
        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (List1.SelectedItem == null){
                return ;
            } else {
                getViewModel().CurrentObject = (Task)List1.SelectedItem;
                Frame.Navigate(typeof(TaskDetails));
            }
        }

        private void startProgressBar() {
            contentGrid.Visibility = Visibility.Collapsed;
            progressGrid.Visibility = Visibility.Visible;
        }

        private void stopProgressBar() {
            contentGrid.Visibility = Visibility.Visible;
            progressGrid.Visibility = Visibility.Collapsed;
        }

    }
}
