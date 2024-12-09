using SannasHobbylista.ViewModels;
using System.Windows;

namespace SannasHobbylista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HobbyListViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new HobbyListViewModel();
            DataContext = viewModel;
            //Loaded += HobbyView_Loaded;
        }

        //TODO: ta bort?? :) 
        //private async void HobbyView_Loaded(object? sender, RoutedEventArgs e)
        //{
        //    await viewModel.LoadAsync();
        //}
    }
}