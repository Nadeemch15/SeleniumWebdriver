using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigationToUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
    }
}
