using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldExercise
{
    public class HomePageElements
    {
        public HomePageElements() 
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "ul#main-menu > li > a > div")]
        public IWebElement prijaviSe { get; set; }


        [FindsBy(How = How.Name, Using = "Email")]
        public IWebElement email { get; set; }


        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement password { get; set; }


        [FindsBy(How = How.ClassName, Using = "col-sm-6")]
        public IWebElement logInButton { get; set; }


        [FindsBy(How = How.Id, Using = "common_login_msg")]
        public IWebElement alertMessage { get; set; }


        [FindsBy(How = How.ClassName, Using = "user-avatar-navbar-icon")]
        public IWebElement logOutIcon { get; set; }


        [FindsBy(How = How.XPath, Using = "/html//div[@id='secondary-menu']/ul//a[@href='/odjava']")]
        public IWebElement logOut { get; set; }
    }
}
