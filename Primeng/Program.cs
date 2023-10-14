using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Primeng
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            ChromeOptions MyOptions = new ChromeOptions(); 
            MyOptions.AddArgument("--start-maximized");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            try
            {
                driver.Navigate().GoToUrl("https://primeng.org/dropdown");

                DropdownPage dropdownPage = new DropdownPage(driver);

                dropdownPage.OpenDropdown();
                Thread.Sleep(2000);
                dropdownPage.SelectCity("Rome");
                Thread.Sleep(2000);

                Console.WriteLine("City 'Rome' selected successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}