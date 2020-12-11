using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.TestPageObject.SearchDress
{
    [TestClass]
    public class TestSearchSummerDress
    {
        [TestMethod]
        public void SearchDress()
        {
            NavigationHelper.NavigationToUrl(ObjectRepository.Config.GetWebsite());
         
            SearchSummerDress search = new SearchSummerDress(ObjectRepository.Driver);
            search.SearchDress("Summer Dress");
        }
        
    }
}
