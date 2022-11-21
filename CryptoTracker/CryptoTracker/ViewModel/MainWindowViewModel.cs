using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.ViewModel
{
    class MainWindowViewModel
    {
        private string _dashboardName;
        private string _selectedCoin;
        private string _selectedCurrency;
        private bool _isNewDashboard;

        public bool IsNewDashboard
        {
            get { return _isNewDashboard; }
            set { _isNewDashboard = value; }
        }

        public MainWindowViewModel()
        {
            _dashboardName = "please enter dashboard name";
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

    }
}
