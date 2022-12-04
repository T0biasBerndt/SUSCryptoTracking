using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Profile
    {
        private string _dashboardName;
        private string _selectedCoin;
        private string _selectedCurrency;

        private double _changeToday;
        private double _currentPrice;


        public double ChangedToday
        {
            get { return _changeToday; }
            set { _changeToday = value ; }//rest zugriff wenn fertig
        }

        public double CurrentCoinValue
        {
            get { return _currentPrice; }
            set { _currentPrice = value; }//rest zugriff wenn fertig
        }

        public Profile(string _dashboardName, string _selectedCoin, string _selectedCurrency)
        {
            string profileHeader = _dashboardName;
            string selectedCoins = _selectedCoin;
            string currency = _selectedCurrency;
            double currentValue = _currentPrice;
            double changedToday = _changeToday;
        }
    }
}
