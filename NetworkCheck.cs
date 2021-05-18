using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    class NetworkCheck
    {
        //needs Xam.Plugin.Connectivity in nugent manager.
        public static bool IsInternet()
        {
            if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected)
            {
                return true;
            }
            else
            {
                //add 'No internet connection error'
                return false;
            }
        }
    }
}
