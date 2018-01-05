Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 80 into the calculator
	And I have entered 50 into the calculator
	When I press add
	Then the result should be 130 on the screen

Scenario: Subtract two numbers
	Given I have entered 80 into the calculator
	And I have entered 60 into the calculator
	When I press subtract
	Then the result should be 20 on the screen


Scenario: Multiply two numbers
	Given I have entered 4 into the calculator
	And I have entered 25 into the calculator
	When I press multiply
	Then the result should be 100 on the screen

Scenario: Divide two numbers
	Given I have entered 1000 into the calculator
	And I have entered 25 into the calculator
	When I press divide
	Then the result should be 40 on the screen

Scenario: Add then subtract
	Given I have entered 10 into the calculator
	And I have entered 25 into the calculator
	And I have entered 12 into the calculator
	When I press add and I subtract
	Then the result should be 23 on the screen
	