﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace WebDriverHomeTask.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void WaitClickabilityOfElement(long timeToWait, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void WaitLittle(long timeToWait)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeToWait);
        }
    }
}
