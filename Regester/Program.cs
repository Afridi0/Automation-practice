using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Testing Registration and Login of the Online Shopping Website
             
            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor Js = (IJavaScriptExecutor)driver;
            Actions action = new Actions(driver);
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Thread.Sleep(500);

            // driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");
            driver.FindElement(By.CssSelector("[class='login']")).Click();
            Thread.Sleep(1500);
            Js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email_create")).SendKeys("kevinthehellboy@gmail.com");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("SubmitCreate")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='id_gender' and @value='1']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.Id("customer_firstname")).SendKeys("Md Afridi");
            Thread.Sleep(500);
            driver.FindElement(By.Id("customer_lastname")).SendKeys("khurshid");
            Thread.Sleep(500);
            driver.FindElement(By.Id("passwd")).SendKeys("12345678");
            driver.FindElement(By.Id("days")).SendKeys("23");
            driver.FindElement(By.Id("months")).SendKeys("january");
            driver.FindElement(By.Id("years")).SendKeys("2022");
            Thread.Sleep(500);
            driver.FindElement(By.Id("newsletter")).Click();
            driver.FindElement(By.Id("optin")).Click();
            Js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(1000);

            //address
            driver.FindElement(By.Id("firstname")).Clear();
            Thread.Sleep(500);
            driver.FindElement(By.Id("firstname")).SendKeys("kolkata");
            Thread.Sleep(500);
            driver.FindElement(By.Id("lastname")).Clear();
            Thread.Sleep(500);
            driver.FindElement(By.Id("lastname")).SendKeys(" india");
            Thread.Sleep(500);
            driver.FindElement(By.Id("company")).SendKeys("Bassetti, india");
            Thread.Sleep(500);
            driver.FindElement(By.Id("address1")).SendKeys("kolkata . saltlake");
            Thread.Sleep(500);
            driver.FindElement(By.Id("address2")).SendKeys("sector 5 , ");
            Thread.Sleep(500);
            driver.FindElement(By.Id("city")).SendKeys("kolkata");
            Thread.Sleep(500);
            driver.FindElement(By.Id("id_state")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("id_state")).SendKeys("f");
            Thread.Sleep(500);
            driver.FindElement(By.Id("id_state")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("postcode")).SendKeys("00003");
            Thread.Sleep(1000);

            driver.FindElement(By.Id("phone_mobile")).SendKeys("123456789");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("alias")).SendKeys(" is kolkata");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@id='submitAccount']")).Click();
            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector("[class='logout']")).Click();
            Thread.Sleep(1000);

            //  driver.Close();
        }
    }
}
