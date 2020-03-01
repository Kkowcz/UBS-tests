using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UBSTask.Helpers
{
    public class SecondFeatureMethods
    {
        DriverFactory DF = new DriverFactory();

        public void FirstStep(string startPage)
        {
            if (startPage == "SelfAssessment")
            {
                startPage = "https://unique-community.ubs.com/financial-confidence?pk_campaign=#/";
                DF.NavigateTo(startPage);
                DF.Maximize();
                DF.ClickElementByXpatch("/html/body/div[2]/div[1]/ng-include/div[1]/ng-include/div/div[2]/div/button");
            } 
            DF.SetTimeout(10);
        }

        public void Fillname(string name)
        {
            const string nameField = "/html/body/div[2]/div[1]/ng-include/div[2]/div/div[1]/form/label/input";
            DF.FillFieldByXpatch(nameField, name);
            DF.ClickElement("first_name-submit");
            System.Threading.Thread.Sleep(2000);
        }

        public void SpecifyPerson()
        {
            const string tag = "li";
            const string firstCollectionSource = "/html/body/div[2]/div[1]/ng-include/div[2]/div/div[2]/label/ul";
            DF.ChooseRandomValueFromList(firstCollectionSource, tag);
            System.Threading.Thread.Sleep(2000);

            const string secondCollectionSource = "/html/body/div[2]/div[1]/ng-include/div[2]/div/div[3]/label/ul";
            DF.ChooseRandomValueFromList(secondCollectionSource, tag);
            System.Threading.Thread.Sleep(2000);

            const string thirdCollectionSource = "/html/body/div[2]/div[1]/ng-include/div[2]/div/div[4]/label/ul";
            DF.ChooseRandomValueFromList(thirdCollectionSource, tag);
            System.Threading.Thread.Sleep(2000);

            const string nextButtonSource = "/html/body/div[2]/div[1]/ng-include/div[2]/div/div[5]/div[2]/button";
            DF.ClickElementByXpatch(nextButtonSource);
            System.Threading.Thread.Sleep(4000);
        }

        public void AnswerSingleQuestion(string value, string xpatch)
        {
            DF.GoUpOrDown(value);
            System.Threading.Thread.Sleep(2000);
            DF.ClickElementByXpatch(xpatch);
        }

        public void FillTest(string value)

        {
            const string question1AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[1]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question1AnswerButton);

            const string question2AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[2]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question2AnswerButton);

            const string question3AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[3]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question3AnswerButton);

            const string question4AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[4]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question4AnswerButton);

            const string question5AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[5]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question5AnswerButton);

            const string question6AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[6]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question6AnswerButton);

            const string question7AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[7]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question7AnswerButton);

            const string question8AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[8]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question8AnswerButton);

            const string question9AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[9]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question9AnswerButton);

            const string question10AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[10]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question10AnswerButton);

            const string question11AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[11]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question11AnswerButton);

            const string question12AnswerButton = "/html/body/div[2]/div[2]/div/ul/li[12]/ng-include/div/div[3]/button";
            AnswerSingleQuestion(value, question12AnswerButton);

            System.Threading.Thread.Sleep(2000);
        }


        public void FillWholeForm(string value)
        {
            Fillname("Test User");
            SpecifyPerson();
            FillTest(value);
        }

        public void PressGetResultButton(string button)
        {
            if (button == "Get result")

            DF.ClickElementByXpatch("/html/body/div[2]/div[3]/ng-include/div/ng-include/button");
        }

        public void CompareResult(string personality)
        {
            System.Threading.Thread.Sleep(6000);
            Assert.AreEqual(personality, DF.GetText("/html/body/div[2]/div[3]/ng-include/div/ng-include/div/div[1]/div[1]/span"));
            DF.driver.Quit();
            DF.driver.Dispose();
        }
    }
}
