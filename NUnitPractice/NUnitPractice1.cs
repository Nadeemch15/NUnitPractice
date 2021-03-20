using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingNov
{

    [TestFixture]
    public class Test2
    {
        //[Test]
        //public void TestClickLink()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        //    driver.FindElement(By.XPath("//a[text()='A/B Testing']")).Click();

        //}
        //[Test]
        //public void TestAddRemoveButton()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    string url = "http://the-internet.herokuapp.com/";
        //    driver.Navigate().GoToUrl(url);
        //    driver.FindElement(By.XPath("//a[text()='Add/Remove Elements']")).Click();
        //    driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
        //}
        //[Test]
        //public void CheckBox()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        //    driver.FindElement(By.XPath("//a[contains(text(),'Checkboxes')]")).Click();
        //    driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/input[1]")).Click();
        //}
        [Test]
        public void RightClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://the-internet.herokuapp.com/";
            driver.FindElement(By.XPath("//a[text()='Context Menu']")).Click();
            Actions action = new Actions(driver);
            IWebElement rightclick = driver.FindElement(By.XPath("//div[@id='hot-spot']"));
            action.ContextClick(rightclick).Perform();
        }
        [Test]
        public void DragDrop()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/";
            Actions action = new Actions(driver);
            action.DragAndDrop(driver.FindElement(By.Id("draggable")),
            driver.FindElement(By.Id("droppable"))).Perform();
        }
        [Test]
        public void DoublClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/";
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.Name("dblClick"))).DoubleClick().Perform();
        }
        [Test]
        public void Slider()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/";

            //scroll down
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 4000)");

            //slider
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(driver.FindElement(By.ClassName("ui-handle-helper-parent")), 100, 0).Perform();

        }
        [Test]
        public void AO()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://ao.com/";


        }
    }
}
