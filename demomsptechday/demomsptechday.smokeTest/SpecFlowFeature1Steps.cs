using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace demomsptechday.smokeTest
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        //[A]rrange
        private static IWebDriver driver;
        private IWebElement element;
        private static string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Driver\\";

        public static IWebDriver Driver
        {
            get { return driver; }

            set { driver = value; }
        }
        public IWebElement Element
        {
            get { return element; }

            set { element = value; }
        }

        private string title { get; set; }

        [BeforeFeature]
        public static void Initialized()
        {
            Driver = new ChromeDriver(driverPath);
        }

        [Given(@"acessei o site ""(.*)""")]
        public void GivenAcesseiOSite(string p0)
        {
            Driver.Navigate().GoToUrl("http://demomsptechday.azurewebsites.net/");
        }

        //[A]ct        
        [Given(@"pequei o titulo do site")]
        public void GivenPequeiOTituloDoSite()
        {
            title = Driver.Title;
        }
        
        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            // Mentira não precisei apertar o enter
            // e as ações abaixo são um voltar, ir para frente e atualizar rsrs
            Driver.Navigate().Back();
            Driver.Navigate().Forward();
            Driver.Navigate().Refresh();
        }

        //[A]ssert
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            Assert.IsTrue(title.Contains("Demo MSP Tech Day"));
        }

        [AfterFeatureAttribute]
        public static void Finished()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
