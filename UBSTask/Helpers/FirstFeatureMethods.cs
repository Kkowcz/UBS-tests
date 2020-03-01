using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UBSTask.Helpers
{
    public class FirstFeatureMethods
    {

        DriverFactory DF = new DriverFactory();

        public void FirstStep(string startPage)
        {
            DF.driver.Url = "https://www.ubs.com/global/en/homepage/cookies/r-cookie-pop-up.lightbox.logo.footer_links.disclaimer_text.html";
            DF.Maximize();
            DF.SetTimeout(20);
            DF.ClickElementByXpatch("/html/body/div[1]/main/article/div/div/div/div/div/div/div[2]/div/div/div/button/span/span");
            if (startPage == "Survey")
                startPage = "https://www.ubs.com/global/en/wealth-management/survey-weboptimization.lightbox.html";
            DF.NavigateTo(startPage);
            
        }

        private void FillFormWithRandomValue(bool whole)
        {
            const string Tag = "label";
            const string LabelUsefulSource = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[1]/div[2]";
            const string LabelLogicalSource = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[2]/div[2]";
            const string LabelTrustworthySource = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[3]/div[2]";
            const string LabelAccurateSource = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[4]/div[2]";
            const string LabelTermSource = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[6]/div[2]";
            const string LabelUpToDateSource = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[7]/div[2]";
            const string LabelInterestingSource = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[8]/div[2]";
            const string LabelWellPreparedSource = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[9]/div[2]";
            const string LabelComprehensibleSource = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[10]/div[2]";
            const string LabelTerms2Source = "/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[12]/div[2]";

            DF.ChooseRandomValueFromList(LabelUsefulSource, Tag);
            DF.ChooseRandomValueFromList(LabelLogicalSource, Tag);
            DF.ChooseRandomValueFromList(LabelTrustworthySource, Tag);
            DF.ChooseRandomValueFromList(LabelAccurateSource, Tag);
            DF.ChooseRandomValueFromList(LabelTermSource, Tag);
            DF.ChooseRandomValueFromList(LabelUpToDateSource, Tag);
            DF.ChooseRandomValueFromList(LabelInterestingSource, Tag);
            DF.ChooseRandomValueFromList(LabelWellPreparedSource, Tag);
            DF.ChooseRandomValueFromList(LabelComprehensibleSource, Tag);
            if (whole == true)
                DF.ChooseRandomValueFromList(LabelTerms2Source, Tag);

        }

        public void FillForm(string levelOfComplete)
        {
            System.Threading.Thread.Sleep(1000);

            switch (levelOfComplete)
            {
                case "NotWhole":
                    FillFormWithRandomValue(false);
            break;
                case "Whole":
                    FillFormWithRandomValue(true);
                    //wait is required for minimal time of fullfilling form
                    System.Threading.Thread.Sleep(10000);
                    break;
            }
        }

        public void PressButton(string button)
        {
            if (button == "Submit")
            {
                button = "/html/body/div[1]/main/article/div/div/div/div/div/div[4]/div/form/div[2]/div[13]/div/div[2]/button";
                DF.ClickElementByXpatch(button);
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void CompareResult(string resultTxt)
        { 
            switch (resultTxt)
            {
                case "Please enter your opinion":
                        Assert.AreEqual(DF.GetText("/html/body/div[1]/main/article/div/div/div/div/div/div[2]/form/div/div/div/div[12]/div[4]/p"), resultTxt);
                        break;
                case "Thank you for your feedback!":
                    System.Threading.Thread.Sleep(1000);
                    Assert.AreEqual(DF.GetText("/html/body/div[1]/main/div/div/div/div/div/div/div/div/h2/span"), resultTxt);
                        break;
                default:
                    DF.driver.Quit();
                    DF.driver.Dispose();
                    Assert.Fail();
                    break;
             }
              DF.driver.Quit();
              DF.driver.Dispose();
        }
    }
}
