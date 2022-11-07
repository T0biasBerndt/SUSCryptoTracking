using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.ViewModel
{
    class MainWindowViewModel
    {
        private int _dashboardName;

        public int DashboardName
        {
            get { return _dashboardName; }
            set { _dashboardName = value; }
        }

    }
}
