using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UBSTask.Helpers;

namespace UBSTask.Specs
{
    [Binding]
    public sealed class TestHook
    {
       // private IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
          
            //driver = DriverFactory.ReturnDriver(DriverFactory.DriverType.Chrome);
          //  ScenarioContext.Current["driver"] = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}