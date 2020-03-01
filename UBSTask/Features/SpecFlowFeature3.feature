Feature: TestAutomationThirdFeature
	In order to get in touch with UBS
	As a user
	I want to send the form about my contact info

@mytag
Scenario: Get touch with UBS
	Given I'm on a "https://www.ubs.com/je/en/wealth-management/contact-us/get-in-touch.html" page 
	And I also have filled whole form with "right" answers
	When I click on "/html/body/div[1]/main/div/div/div/div/div[1]/div[2]/div/form/div[2]/div[20]/div/div[2]/button[1]/span"
	Then message "Please confirm your acceptance" succes will show on the form
