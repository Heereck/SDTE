using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace UnitTestProject1
{
    public class SelectBrowsers
    {        
        RemoteWebDriver browser;        
        public RemoteWebDriver ReturnBrowser(int a)
        {

            switch (a)
            {
                case 1:
                   browser =  new ChromeDriver();
                    break;
                case 2:
                    browser = new EdgeDriver();
                    break;
                case 3:
                    browser = new FirefoxDriver();
                    break;
                default:
                    Console.WriteLine("Wrong number entered.");
                    break;
            }
            return browser;

        }
    }
}

