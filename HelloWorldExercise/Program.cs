using NUnit.Framework;
using OpenQA.Selenium;

namespace HelloWorldExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ActionsForCode.InitializeDriver();
        }

        [SetUp]
        public void SetUp()
        {
            Driver.driver.Navigate().GoToUrl(Configuration.url);
            Driver.driver.Manage().Cookies.AddCookie(new Cookie("test", "cookie"));
        }

        [Test]
        public void PositiveTestCase() 
        {
            Scenarios.ValidCredentials();
            Driver.Wait();
            ActionsForCode.LogOut(Driver.driver);
        }

        [Test]
        public void NegativeTestCase() 
        {
            Scenarios.InvalidCredentials();
            ActionsForCode.GetText().Contains(Configuration.message);
            Driver.Wait();
        }

        [Test]
        public void NegativeUsernameTestCase() 
        {
            Scenarios.InvalidUsername();
            ActionsForCode.GetText().Contains(Configuration.message);
            Driver.Wait();
        }

        [Test]
        public void NegativePasswordTestCase() 
        {
            Scenarios.InvalidPassword();
            ActionsForCode.GetText().Contains(Configuration.message);
            Driver.Wait();
        }


        [OneTimeTearDown]
        public void TearDown() 
        {
            Driver.driver.Quit();
            Driver.driver.Dispose();
        }
    }
}
