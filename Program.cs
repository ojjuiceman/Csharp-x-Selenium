using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Selenium_Automation
{
	class Program
	{
		static void Main(string[] args)
		{
			

			WebDriver driver = new ChromeDriver("/Users/okerajohnson/Desktop/");

				// This will open up the URL
			driver.Url = "https://mychart.montefiore.org/mychart/Authentication/Login";

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

			driver.FindElement(By.Id("submit")).Click();

		

			


		}
	}
}

