using System.Collections.ObjectModel;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Input.Inking;

namespace ListViewAddingTest
{
    public sealed partial class MainPage : Page
    {
        ObservableCollection<ViewModel> pageCollection;
        public MainPage()
        {
            this.InitializeComponent();
            pageCollection = new ObservableCollection<ViewModel>();
            CanvasListView.ItemsSource = pageCollection;
            CanvasListView.IsHitTestVisible = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Adding new page...");
            pageCollection.Add(new ViewModel());
            PageCountText.Text = pageCollection.Count + " Pages";
            Debug.WriteLine("CanvasListView count is " + CanvasListView.Items.Count);
        }
    }
}
