using TechTalk.SpecFlow;

namespace UBSTask.Steps
{
    
    [Binding]
    public class TestAutomationSecondFeatureSteps
    {
        Helpers.SecondFeatureMethods methods = new Helpers.SecondFeatureMethods();

        [Given(@"I navigate to ""(.*)"" page")]
        public void GivenIEntersToPage(string startPage)
        {
            methods.FirstStep(startPage);
        }

       
        [Given(@"I also fullfill the whole test on ""(.*)"" values")]
        public void GivenIAlsoFullfillTheWholeTestOnValues(string values)
        {
            methods.FillWholeForm(values);
        }
        
        [When(@"I press ""(.*)"" button")]
        public void WhenIPressButton(string button)
        {
            methods.PressGetResultButton(button);
        }
        
        [Then(@"The results of test will be ""(.*)""")]
        public void ThenTheResultsOfTestWillBe(string personality)
        {
            methods.CompareResult(personality);
        }
    }
}
