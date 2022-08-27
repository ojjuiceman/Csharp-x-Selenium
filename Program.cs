using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_Automation
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver("/Users/okerajohnson/Desktop/");

			// This will open up the URL
			driver.Url = "https://www.geeksforgeeks.org/";
		}
	}
}

