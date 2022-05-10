using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace login_Automation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor Js = (IJavaScriptExecutor)driver;
            Actions actions = new Actions(driver);
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
           
            Thread.Sleep(500);

            // driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");
            driver.FindElement(By.CssSelector("[class='login']")).Click();
            Thread.Sleep(1500);
            Js.ExecuteScript("window.scrollBy(0,450)");
            Thread.Sleep(1000);

            driver.FindElement(By.Id("email")).SendKeys("kevinthehellboy@gmail.com");
            Thread.Sleep(1000);

            driver.FindElement(By.Id("passwd")).SendKeys("12345678");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(3000);
            


            IWebElement womenoptn = driver.FindElement(By.XPath("//a[@title='Women']"));
            //Mouse hover womenoptn 'women'

            actions.MoveToElement(womenoptn).Perform();
            IWebElement tsrt = driver.FindElement(By.XPath("//a[@title='T-shirts']"));
            tsrt.Click();
            Thread.Sleep(2000);
            Js.ExecuteScript("window.scrollBy(0,450");
            driver.FindElement(By.XPath("//img[@title='Faded Short Sleeve T-shirts']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("search_query_top")).SendKeys("Faded Short Sleeve T-shirts");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            Thread.Sleep(2000);
            Js.ExecuteScript("window.scrollBy(0,350");

        }
    }
}
