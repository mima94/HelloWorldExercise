using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HelloWorldExercise
{
    public class HomePageElements
    {
        public HomePageElements() 
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/header/div[1]/nav/div[@class='flex items-center']/div[1]/a[@href='/prijava']/span[.='Prijavi se']")]
        public IWebElement prijaviSe { get; set; }


        [FindsBy(How = How.Name, Using = "Email")]
        public IWebElement email { get; set; }


        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement password { get; set; }


        [FindsBy(How = How.XPath, Using = "/html//form[@id='login_form']//button[@type='submit']")]
        public IWebElement logInButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".rounded-md .__login-errors-text")]
        public IWebElement alertMessage { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/header/div[1]/nav/div[@class='flex items-center']/div[1]/a[@href='/moj-kutak']/span[.='Moj nalog']")]
        public IWebElement logOutIcon { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/header[@class='bg-white']//nav/div[@class='flex items-center']/div[1]/div/a[@href='/odjava']")]
        public IWebElement logOut { get; set; }
    }
}
