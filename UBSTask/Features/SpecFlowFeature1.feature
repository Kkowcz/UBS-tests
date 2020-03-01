Feature: TestAutomationFirstFeature
	In order to express my opinion about the UBS site
	As a customer
	I want to submit my opinion by filling the form on the site

@FillingSurvey
Scenario: As User I enter UBS site and I submit not completly filled up survey form
	Given I enter to "Survey" page 
	And I also fullfill the "NotWhole" survey
	When I press "Submit" 
	Then Comunicate "Please enter your opinion" will show on the form 

@FillingSurvey
Scenario: As User I enter UBS site and I submit completly filled up survey form
	Given I enter to "Survey" page 
	And I also fullfill the "Whole" survey
	When I press "Submit" 
	Then Comunicate "Thank you for your feedback!" will show on the form 



