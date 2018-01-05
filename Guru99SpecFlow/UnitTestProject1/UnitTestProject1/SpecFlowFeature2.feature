Feature: SpecFlowFeature2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Take x numbers 
	Given I have entered 5 into the calculator
	And I entered 7 into the calculator
	When I press add
	Then the result should be 120 on the screen
