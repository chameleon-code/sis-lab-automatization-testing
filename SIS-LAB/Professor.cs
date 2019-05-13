using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SIS_LAB
{
    class Professor
    {
        public void create(IWebDriver driver, String names, String firstName, String secondName, String email, String codSis)
        {
            IWebElement wnames, wfirstName, wsecondName, wprofessorEmail, wcodSis, wprofessorPass, wconfirmCreate, professors, createProfessor;

            //botones sidebar
            professors = driver.FindElement(By.Id("professors"));
            createProfessor = driver.FindElement(By.Id("createProfessor"));

            professors.Click(); createProfessor.Click();

            wnames = driver.FindElement(By.Name("names"));
            wfirstName = driver.FindElement(By.Name("first_name"));
            wsecondName = driver.FindElement(By.Name("second_name"));
            wprofessorEmail = driver.FindElement(By.Name("email"));
            wcodSis = driver.FindElement(By.Name("code_sis"));
            wprofessorPass = driver.FindElement(By.Id("genPass"));
            wconfirmCreate = driver.FindElement(By.Id("confirmCreate"));

            wnames.SendKeys(names);
            wfirstName.SendKeys(firstName);
            wsecondName.SendKeys(secondName);
            wprofessorEmail.SendKeys(email);
            wcodSis.SendKeys(codSis);
            wprofessorPass.Click();
            wconfirmCreate.Click();
        }
    }
}
