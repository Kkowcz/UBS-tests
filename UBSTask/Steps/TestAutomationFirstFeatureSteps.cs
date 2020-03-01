using TechTalk.SpecFlow;


namespace UBSTask

{
    [Binding]
    public class TestAutomationFirstFeatureSteps
    {

        Helpers.FirstFeatureMethods methods = new Helpers.FirstFeatureMethods();
        

        [Given(@"I enter to ""(.*)"" page")]
        public void GivenIEnterToPage(string startPage)
        {
            methods.FirstStep(startPage);
        }

        [Given(@"I also fullfill the ""(.*)"" survey")]
        public void GivenIAlsoFullfillTheSurvey(string levelOfComplete)
        {
            methods.FillForm(levelOfComplete);
        }


        [When(@"I press ""(.*)""")]
        public void WhenIPress(string button)
        {
            methods.PressButton(button);
        }

        [Then(@"Comunicate ""(.*)"" will show on the form")]
        public void ThenComunicateWillShowOnTheForm(string resultTxt)
        {
            methods.CompareResult(resultTxt);
        }


    }
}
