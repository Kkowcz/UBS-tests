using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UBSTask.Steps
{
    //Methods in this Steps are not implement as rest of Features Steps due to lack of time
    [Binding]
    public class TestAutomationFirstFeatureSteps
    {
        Helpers.DriverFactory DF = new Helpers.DriverFactory();
        Helpers.Arrays arrays = new Helpers.Arrays();

        [Given(@"I'm on a ""(.*)"" page")]
        public void GivenIMOnAPage(string StartPage)
        {
            DF.driver.Url = "https://www.ubs.com/global/en/homepage/cookies/r-cookie-pop-up.lightbox.logo.footer_links.disclaimer_text.html";
            DF.SetTimeout(20);
            DF.ClickElementByXpatch("/html/body/div[1]/main/article/div/div/div/div/div/div/div[2]/div/div/div/button/span/span");
            DF.Maximize();
            DF.NavigateTo(StartPage);
            
        }
        
        [Given(@"I also have filled whole form with ""(.*)"" answers")]
        public void GivenIAlsoHaveFilledWholeFormWithAnswers(string p0)
        {
            System.Threading.Thread.Sleep(4000);
            DF.ClickElement("serivce_1");
            DF.ClickElementByXpatch("/html/body/div[1]/main/div/div/div/div/div[1]/div[2]/div/form/div[2]/div[5]/fieldset/div[2]/fieldset/ul/li[1]/label");
            DF.FillFieldById("Firstname", arrays.GetName());
            DF.FillFieldById("Lastname", arrays.GetSurname());
            DF.FillFieldById("Company", "UBS");
            DF.FillFieldById("Address", arrays.GetStreet());
            DF.FillFieldById("ZIP", arrays.GetZipCode());
            DF.FillFieldById("City", arrays.GetCity());
            DF.ChooseRandomValueFromList("/html/body/div[1]/main/div/div/div/div/div[1]/div[2]/div/form/div[2]/div[12]/div[2]/select", "option");
            DF.FillFieldById("Phone", "666666666");
            DF.FillFieldById("Email", "example@email.mail");
            DF.FillFieldById("Comment", "This is a test message....");

            //DF.ClickElement("Accept-disclaimer_1");
            //DF.ClickElement("Marketingusage_1");
        }

        [When(@"I click on ""(.*)""")]
        public void WhenIClickOn(string Submit)
        {
            DF.ClickElementByXpatch(Submit);
        }

        [Then(@"message ""(.*)"" succes will show on the form")]
        public void ThenMessageSuccesWillShowOnTheForm(string Message)
        {
            Assert.AreEqual(Message, DF.GetText("/html/body/div[1]/main/div/div/div/div/div[1]/div[2]/div/form/div[2]/div[18]/fieldset/div[2]/fieldset/div"));
            DF.driver.Quit();
            DF.driver.Dispose();
        }

    }
}
