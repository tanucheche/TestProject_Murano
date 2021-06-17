using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace TestProjectMuramo
{
    public class SignUpPage : BaseTests
    {
        //здесь будут тесты на авторизацию

        [Test]
        public void TestClickSignUp()
        {
            IWebElement course = driver.FindElement(By.Id("signup-button"));
            // Click on Sign Up			
            course.Click();
        }
    }
}