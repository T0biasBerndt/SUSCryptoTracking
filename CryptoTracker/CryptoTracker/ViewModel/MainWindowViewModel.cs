using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommandHelper;

namespace CryptoTracker.ViewModel
{
    class MainWindowViewModel
    {
        private string _dashboardName;
        private string _selectedCoin;
        private string _selectedCurrency;
        private bool _isNewDashboard;
        private ICommand _saveProfile;
        private ICommand _openDaschboard;
        private ObservableCollection<string> _profiles = new ObservableCollection<string> { "profile1" };//todo array wir nicht angezeigt ???????ß
        private ObservableCollection<string> Profiles
        { get; set; }
        //Array of the existing profiles in db

        private string _selectedProfile;

        public string Selectedprofile
        {
            get { return _selectedProfile; }
            set { _selectedProfile = value; }
        }

        public MainWindowViewModel()
        {
            _dashboardName = "please enter dashboard name";

        }
        
        public ICommand SaveProfile
        {
           get
            {
                if(_saveProfile == null)
                    _saveProfile = new RelayCommand(c => SaveNewProfile());

            return _saveProfile;
            }
        }
        public ICommand OpenDashboard
        {
            get
            {
                if (_openDaschboard == null)
                    _openDaschboard = new RelayCommand(c => OpenSavedDashboard());

                return _openDaschboard;
            }
        }



        public bool IsNewDashboard
        {
            get { return _isNewDashboard; }
            set { _isNewDashboard = value; }
        }
        public string SelectedCurrency
        {
            get { return _selectedCurrency; }
            set { _selectedCurrency = value; }
        }

        public string SelectedCoin
        {
            get { return _selectedCoin; }
            set { _selectedCoin = value; }
        }

        public string DashboardName
        {
            get { return _dashboardName; }
            set { _dashboardName = value; }
        }
        private void SaveNewProfile()
        {

        }
        private void OpenSavedDashboard()
        {
           
        }


    }
}
