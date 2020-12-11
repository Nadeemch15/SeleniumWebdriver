using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.BaseClasses
{
    public class BasePage
    {
        private IWebDriver driver;
        public BasePage(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
        }
    }
}
