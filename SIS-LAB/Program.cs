using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SIS_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://127.0.0.1:8000");
            driver.Manage().Window.Maximize();

            //logeo Admin
            Admin admin = new Admin();
            admin.login(driver, "admin@gmail.com", "admin");
            
            //Crear Docentes
            Professor professor = new Professor();
            
            professor.create(driver, "Leticia", "Blanco", "Coca", "leticia.blanco@gmail.com", "12345678");
            professor.create(driver, "Gustavo", "Patiño", "Lizarazu", "gustavo.patino@gmail.com", "87654321");
            professor.create(driver, "Josue", "Flores", "Ramos", "josue.flores@gmail.com", "18273645");
        }
    }
}
