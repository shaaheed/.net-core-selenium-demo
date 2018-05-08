using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumDemo
{
    class Program
    {
        // the directory of driver without the binary file name.
        private static string _driverDirectory = @"E:\DotNet\chromedriver_win32";
        private static string _navigationUrl = "http://google.com";
        private static string _query = "github";

        static void Main(string[] args)
        {
            var driver = new ChromeDriver(_driverDirectory);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(_navigationUrl);

            var queryInput = driver.FindElementByCssSelector("#lst-ib");
            queryInput.SendKeys(_query);
            queryInput.Submit();

            var githubAnchor = driver.FindElementByCssSelector("h3.r a:first-child");
            githubAnchor.Click();

            Console.ReadLine();
        }
    }
}
