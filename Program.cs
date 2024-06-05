using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasics
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World");

            // step #1 : Launch Chrome Browser 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // maximized mode

            // step #2 : Navigate to TurnUp Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // step #3 : Enter Username value in username field using locator as ID and actions as Sendkey
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            // step #4 : Enter Password value in Password field using locator as Name and actions as Sendkey
            driver.FindElement(By.Name("Password")).SendKeys("123123");

            // step #5 : Click Login Button using locator as XPath and actions as Click
            driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]")).Click();

            // step #6 : Verify user Login was successful by using XPath of hello hari in login page
            string message = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a")).Text;
            if (message == "Hello hari!")
            {
                Console.WriteLine("User Login was successfull");
            }
            else
            {
                Console.WriteLine("User Login was unsuccessfull");
            }

            //step #7 close the chrome browser
            driver.Quit();
        }
    }
}
