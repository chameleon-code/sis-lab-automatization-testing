using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SIS_LAB
{
    class Admin
    {
        public void login(IWebDriver driver, String email, String pass)
        {
            IWebElement sign, inputEmail, inputPass, login;

            sign = driver.FindElement(By.Id("login"));
            sign.Click();

            inputEmail = driver.FindElement(By.Id("email"));
            inputEmail.SendKeys(email);
            inputPass = driver.FindElement(By.Id("password"));
            inputPass.SendKeys(pass);
            login = driver.FindElement(By.Id("login"));
            login.Click();
        }
    }
}
