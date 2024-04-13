using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TripSystemApp.Models;
using TripSystemApp.DataAccess;

namespace TripSystemApp.ViewModels
{
    public class TripPlannerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Destination> _destinations;
        private Destination _selectedDestination;
        private readonly DestinationRepository _destinationRepository;

        public TripPlannerViewModel()
        {
            _destinationRepository = new DestinationRepository(new TravelDbContext());
            LoadDestinations();
        }

        public ObservableCollection<Destination> Destinations
        {
            get { return _destinations; }
            set
            {
                _destinations = value;
                OnPropertyChanged();
            }
        }

        public Destination SelectedDestination
        {
            get { return _selectedDestination; }
            set
            {
                _selectedDestination = value;
                OnPropertyChanged();
            }
        }

        private void LoadDestinations()
        {
            //Destinations = new ObservableCollection<Destination>(_destinationRepository.GetAllDestinations());
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
