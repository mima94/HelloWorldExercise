using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldExercise
{
    public class Scenarios
    {
        public static void ValidCredentials() 
        {
            HomePageElements elements = new HomePageElements();

            elements.prijaviSe.Click();
            elements.email.SendKeys(Configuration.Credentials.ValidCredentials.Username);
            elements.password.SendKeys(Configuration.Credentials.ValidCredentials.Password);
            elements.logInButton.Click();
            Driver.Wait();
        }

        public static void InvalidCredentials()
        {
            HomePageElements elements = new HomePageElements();

            elements.prijaviSe.Click();
            elements.email.SendKeys(Configuration.Credentials.InvalidCredentials.Username);
            elements.password.SendKeys(Configuration.Credentials.InvalidCredentials.Password);
            elements.logInButton.Click();
            Driver.Wait();
        }

        public static void InvalidUsername()
        {
            HomePageElements elements = new HomePageElements();

            elements.prijaviSe.Click();
            elements.email.SendKeys(Configuration.Credentials.InvalidCredentials.Username);
            elements.password.SendKeys(Configuration.Credentials.ValidCredentials.Password);
            elements.logInButton.Click();
            Driver.Wait();
        }

        public static void InvalidPasword()
        {
            HomePageElements elements = new HomePageElements();

            elements.prijaviSe.Click();
            elements.email.SendKeys(Configuration.Credentials.ValidCredentials.Username);
            elements.password.SendKeys(Configuration.Credentials.InvalidCredentials.Password);
            elements.logInButton.Click();
            Driver.Wait();
        }
    }
}
