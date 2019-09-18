using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    [TestClass]
    public class Facebook
    {
        [TestMethod]
        public void TestMethod1()
        {
            //driver = new ChromeDriver();
            //#Elements used for the exercise
            string b;
            int a;
            string FirstName = "//input[@name='firstname']";
            string LastName = "//input[@name='lastname']";
            string Phone = "//input[@name='reg_email__']";
            string FbText = "//div[@class='mbl _3m9 _6o _6s _mf']";///"//div[contains(text(),'It’s quick and easy.')]";
            string NotElement = "//input[@name='carros']";
            string ValidateText = "It's free and always will be.";
            
            try
            {
                Console.WriteLine("Select the Browser you want to use 1.-Chrome, 2.-Edge, 3.-Firefox");
                b = "2";//Console.ReadLine();
                a = Convert.ToInt16(b);
            }
            catch
            {
                a = 4;
            }

            SelectBrowsers select = new SelectBrowsers();
            var x = select.ReturnBrowser(a);

            x.Manage().Window.Maximize();
            x.Navigate().GoToUrl("http://www.facebook.com");
            string TextElement = x.FindElement(By.XPath(FbText)).Text;
            x.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            try
            { 
                x.FindElement(By.XPath(NotElement)).SendKeys("No Valido");
            }
            catch(Exception e)
            {
                Console.WriteLine("Object was not found", e);
            }
            finally
            {
                x.FindElement(By.XPath(FirstName)).SendKeys("Piter");
                Console.WriteLine("Name is Piter");
                x.FindElement(By.XPath(LastName)).SendKeys("Bananas");
                Console.WriteLine("Last Name is Bananas");
                x.FindElement(By.XPath(Phone)).SendKeys("3121114567");
                Console.WriteLine("Mobile phone is 3121114567");
                Assert.AreNotEqual(ValidateText, TextElement);
            }


            //driver.Quit();

        }
    }
}