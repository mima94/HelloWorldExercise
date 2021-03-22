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
            Actions.InitializeDriver();
        }

        [SetUp]
        public void SetUp()
        {
            Driver.driver.Navigate().GoToUrl(Configuration.url);
        }

        [Test]
        public void PositiveTestCase() 
        {
            Scenarios.ValidCredentials();
            Driver.Wait();
            Actions.LogOut();
        }

        [Test]
        public void NegativeTestCase() 
        {
            Scenarios.InvalidCredentials();
            Actions.GetText().Contains(Configuration.message);
            Driver.Wait();
        }

        [Test]
        public void NegativeUsernameTestCase() 
        {
            Scenarios.InvalidUsername();
            Actions.GetText().Contains(Configuration.message);
            Driver.Wait();
        }

        [Test]
        public void NegativePasswordTestCase() 
        {
            Scenarios.InvalidPasword();
            Actions.GetText().Contains(Configuration.message);
            Driver.Wait();
        }


        [OneTimeTearDown]
        public void TearDown() 
        {
            Driver.driver.Quit();
        }
    }
}
