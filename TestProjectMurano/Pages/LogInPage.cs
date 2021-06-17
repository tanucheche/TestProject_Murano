using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProjectMuramo
{
    public class LogInPage : BaseTests
    {
        //здесь будут тесты на логин
        [Test]
        public void TestClickLogin()
        {
            IWebElement course = driver.FindElement(By.Id("login-button"));
           // Click on Log In			
            course.Click();
        }
    }
}