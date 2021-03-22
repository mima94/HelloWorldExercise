using OpenQA.Selenium;
using System;

namespace HelloWorldExercise
{
    public class Driver
    {
        public static IWebDriver driver { get; set; }

        public static void Wait()
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}
