using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
    public class SearchSummerDress : BasePage
    {
        private IWebDriver driver;
        public SearchSummerDress(IWebDriver _driver) :base (_driver)
        {
            this.driver = _driver;  
        }
        [FindsBy(How = How.Name, Using = "search_query")]
        private IWebElement SearchText;

        [FindsBy(How = How.Name, Using = "submit_search")]
        private IWebElement SearchButton;

        public void SearchDress(string dress)
        {
            SearchText.SendKeys(dress);
            SearchButton.Click();
        }
    }
}
