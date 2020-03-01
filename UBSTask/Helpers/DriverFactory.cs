using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;



namespace UBSTask.Helpers
{
    public class DriverFactory
    {
        public IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);
        Random random = new Random();
       

        public void SetTimeout(int secondsToWait)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(secondsToWait);
            
        }

        public void Maximize()
        {
            driver.Manage().Window.Maximize();
        }

        public void ClickElementByXpatch(string xPatchToFind)
        {
            driver.FindElement(By.XPath(xPatchToFind)).Click();
        }
 
        public int ChooseRandomValueFromList(string xpatch, string Tag)
        {
            IWebElement select = driver.FindElement(By.XPath(xpatch));
            
            IList<IWebElement> allOptions = select.FindElements(By.TagName(Tag));
            int weDone = random.Next(1, allOptions.Count);
            int areWeDone = 0;
            foreach (IWebElement option in allOptions)
            {
                if (areWeDone == weDone)
                {
                    ClickElementByXpatch(xpatch);
                    option.Click();
                    break;
                }
                areWeDone++;
            }
            //Console.WriteLine(listField + " = " + select.Text);
            return weDone;
        }
        public void NavigateTo(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        public string GetText(string xpatch)
        {
          string op =  driver.FindElement(By.XPath(xpatch)).Text;
            return op;
        }



        public void GoUpOrDown(string value)
        {
            Actions actions = new Actions(driver);

            if(value == "High")
            actions.SendKeys((OpenQA.Selenium.Keys.ArrowUp));
            if(value == "Low")
            actions.SendKeys((OpenQA.Selenium.Keys.ArrowDown));
            actions.Perform();
            actions.Perform();
            actions.Perform();
            actions.Perform();
            actions.Perform();
        }

        public void ClickElement(string elementToClick)
        {
            driver.FindElement(By.Id(elementToClick)).Click();
        }


        public void FillFieldById(string nameOfElement, string valueToFill)
        {

            
             driver.FindElement(By.Id(nameOfElement)).SendKeys(valueToFill);
            //Console.WriteLine("Wartość pola " + nameOfElement + " = " + valueToFill);
        }

        public void FillFieldByXpatch(string nameOfElement, string valueToFill)
        {


            driver.FindElement(By.XPath(nameOfElement)).SendKeys(valueToFill);
        }

        //public enum DriverType
        //{
        //    Chrome,
        //    Firefox,
        //    Edge
        //}
        //
        //public static IWebDriver ReturnDriver(DriverType driverType)
        //{
        //    IWebDriver driver;
        //    switch (driverType)
        //    {
        //        case DriverType.Chrome:
        //            driver = new ChromeDriver();
        //            break;
        //        case DriverType.Firefox:
        //            driver = new FirefoxDriver();
        //            break;
        //        case DriverType.Edge:
        //            driver = new EdgeDriver();
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException(nameof(driverType), driverType, null);
        //    }
        //    return driver;
        //}


    }
}

