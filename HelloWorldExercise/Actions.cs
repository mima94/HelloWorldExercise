using OpenQA.Selenium.Chrome;
using System;

namespace HelloWorldExercise
{
    public class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Navigate().GoToUrl(Configuration.url);
            Driver.Wait();
        }

        public static void FillingLogInForm(string username, string password)
        {
            HomePageElements elements = new HomePageElements();

            elements.email.SendKeys(username);
            elements.password.SendKeys(password);
        }

        public static void LogOut() 
        {
            HomePageElements elements = new HomePageElements();

            elements.logOutIcon.Click();
            elements.logOut.Click();
        }

        public static string GetText() 
        {
            HomePageElements elements = new HomePageElements();

            elements.alertMessage.Text.ToString();
            return elements.alertMessage.Text;
        }

    }
}
