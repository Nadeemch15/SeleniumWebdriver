using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageObject
    {
        [TestMethod]
        public void Login()
        {

            NavigationHelper.NavigationToUrl(ObjectRepository.Config.GetWebsite());
            HomePage hp = new HomePage(ObjectRepository.Driver);
            hp.SignInLink();
            hp.EnterUserDetials(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            hp.SignInButton();
            
            //hp.ConfirmUserLoggedIn();


        }
    }
}
