Feature: FirstFeature

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I again entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Substract two numbers
	Given I have entered 70 into the calculator
	And I have entered 60 into the calculator
	When I press Substract
	Then the result should be 10 on the screen