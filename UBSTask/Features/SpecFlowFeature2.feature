Feature: TestAutomationSecondFeature
	In order to get knowledge how Financially confident I'am
	As a Tester
	I want to check, that self-assessment test always give me the same result for defined values

@SelfAssessmentTest
Scenario: Filling the self-assessment test on High values
	Given I navigate to "SelfAssessment" page
	And I also fullfill the whole test on "High" values
	When I press "Get result" button
	Then The results of test will be "Pioneer"

@SelfAssessmentTest
Scenario: Filling the self-assessment test on Low values
	Given I navigate to "SelfAssessment" page
	And I also fullfill the whole test on "Low" values
	When I press "Get result" button
	Then The results of test will be "Wanderer"