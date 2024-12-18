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
        }

    }
}