﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Demo
{
	class FirstTestCase
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new FirefoxDriver();
			driver.Url = "http://www.demoqa.com";
		}
	}
}
