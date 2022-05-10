using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Search_features
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

            driver.FindElement(By.XPath("//img[@class='logo img-responsive']")).Click();
            Thread.Sleep(2000);
            Js.ExecuteScript("window.scrollBy(0,550)");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//img[@class='replace-2x img-responsive' and @title='Blouse']")).Click();
            Thread.Sleep(1000);
            Js.ExecuteScript("window.scrollBy(0,220)");
            Thread.Sleep(2000);

            //Quantity
            /*
            driver.FindElement(By.XPath("//a[@class='btn btn-default button-plus product_quantity_up']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@class='btn btn-default button-minus product_quantity_down']")).Click();
            Thread.Sleep(1000);
            */
            driver.FindElement(By.XPath("//select[@id='group_1']//option[@value='2']")).Click();

        }
    }
}
