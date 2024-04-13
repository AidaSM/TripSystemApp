using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TripSystemApp.Models;
using TripSystemApp.DataAccess;

namespace TripSystemApp.ViewModels
{
    public class BookingViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Accommodation> _accommodations;
        private Accommodation _selectedAccommodation;
        private readonly AccommodationRepository _accommodationRepository;

        public BookingViewModel()
        {
            _accommodationRepository = new AccommodationRepository(new TravelDbContext());
            LoadAccommodations();
        }

        public ObservableCollection<Accommodation> Accommodations
        {
            get { return _accommodations; }
            set
            {
                _accommodations = value;
                OnPropertyChanged();
            }
        }

        public Accommodation SelectedAccommodation
        {
            get { return _selectedAccommodation; }
            set
            {
                _selectedAccommodation = value;
                OnPropertyChanged();
            }
        }

        private void LoadAccommodations()
        {
            //Accommodations = new ObservableCollection<Accommodation>(_accommodationRepository.GetAllAccommodations());
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
