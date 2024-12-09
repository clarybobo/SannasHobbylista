
using SannasHobbylista.Models;

namespace SannasHobbylista.ViewModels
{
    public class HobbyViewModel: ViewModelBase
    {
        private readonly Hobby model;

        public HobbyViewModel(Hobby model)
        {
            this.model = model;
        }

        public string? Description
        {
            get { return model.Description; }
            set
            {
                model.Description = value;
                RaisePropertyChanged();
            }
            
        }

    }
}
