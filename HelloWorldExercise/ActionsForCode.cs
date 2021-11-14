using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace HelloWorldExercise
{
    public class ActionsForCode
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            //Driver.driver.Navigate().GoToUrl(Configuration.url);
            Driver.Wait();

        }

        public static void FillingLogInForm(string username, string password)
        {
            HomePageElements elements = new HomePageElements();

            elements.email.SendKeys(username);
            elements.password.SendKeys(password);
            Driver.Wait();
        }

        public static void LogOut(IWebDriver driver) 
        {
            HomePageElements elements = new HomePageElements();

            Actions action = new Actions(driver);
            //action.MoveToElement(driver.FindElement(By.XPath("/html/body/header/div[1]/nav/div[@class='flex items-center']/div[1]/a[@href='/moj-kutak']/span[.='Moj nalog']")))
            // .Build().Perform();

            action.MoveToElement(elements.logOutIcon).MoveToElement(elements.logOut).Click().Build().Perform();            
            //elements.logOut.Click();
        }

        public static string GetText() 
        {
            HomePageElements elements = new HomePageElements();

            elements.alertMessage.Text.ToString();
            return elements.alertMessage.Text;
        }

    }
}
