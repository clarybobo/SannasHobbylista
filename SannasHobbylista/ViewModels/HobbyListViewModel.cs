using SannasHobbylista.Commands;
using SannasHobbylista.Models;
using System.Collections.ObjectModel;

namespace SannasHobbylista.ViewModels
{
    public class HobbyListViewModel : ViewModelBase
    {
        private ObservableCollection<HobbyViewModel> hobbies = new();
        private HobbyViewModel? selectedHobby;

        public HobbyListViewModel()
        {
            hobbies.Add(new HobbyViewModel(new Hobby() { Description = "Koka tomtegröt" }));
            hobbies.Add(new HobbyViewModel(new Hobby() { Description = "Äta pepparkakor" }));
            hobbies.Add(new HobbyViewModel(new Hobby() { Description = "Leverera paket" }));

            AddCommand = new RelayCommand(AddHobby);
            DeleteCommand = new RelayCommand(DeleteHobby, CanDelete);
        }
        public ObservableCollection<HobbyViewModel> Hobbies
        {
            get { return hobbies; }
            set { hobbies = value; RaisePropertyChanged(); }
        }

        public HobbyViewModel? SelectedHobby
        {
            get { return selectedHobby; }
            set
            {
                selectedHobby = value;
                RaisePropertyChanged();
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }
      
        private string newHobbyDescription;
        public string NewHobbyDescription
        {            
            get { return newHobbyDescription; }
            set
            {
                newHobbyDescription = value;
                RaisePropertyChanged(); 
            }
        }

        public RelayCommand AddCommand { get; }
        public RelayCommand DeleteCommand { get; }

        private void AddHobby(object? parameter)
        {            
            if (newHobbyDescription != null)
            {
                Hobby hobby = new Hobby() { Description = NewHobbyDescription };
                var hobbyViewModel = new HobbyViewModel(hobby);
                Hobbies.Add(hobbyViewModel);
                SelectedHobby = hobbyViewModel;
                NewHobbyDescription = string.Empty; 
            }
        }
        private void DeleteHobby(object? parameter)
        {
            if (SelectedHobby != null)
            {
                Hobbies.Remove(SelectedHobby);
                SelectedHobby = null;
            }
        }

        private bool CanDelete(object? parameter) => SelectedHobby != null;

        //TODO: ta bort? 
        //public async Task LoadAsync()
        //{
        //    if (hobbies.Any())
        //    {
        //        return;
        //    }
        //}

    }
}
