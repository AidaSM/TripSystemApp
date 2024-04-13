using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TripSystemApp.Models;
using TripSystemApp.DataAccess;

namespace TripSystemApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<User> _users;
        private User _selectedUser;
        private readonly UserRepository _userRepository;

        public MainViewModel()
        {
            _userRepository = new UserRepository(new TravelDbContext());
            LoadUsers();
        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }

        private void LoadUsers()
        {
            Users = new ObservableCollection<User>(_userRepository.GetAll());
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
