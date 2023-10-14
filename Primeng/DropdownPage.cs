using OpenQA.Selenium;

namespace Primeng
{
    public class DropdownPage : BasePage
    {
        public DropdownPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenDropdown()
        {
            IWebElement dropdown = driver.FindElement(By.Id("pn_id_1_label"));
            dropdown.Click();
        }

        public void SelectCity(string cityName)
        {
            IWebElement cityOption = driver.FindElement(By.XPath("//*[@id=\"pn_id_1_list\"]/p-dropdownitem[2]/li"));
            cityOption.Click();
        }
    }
}
