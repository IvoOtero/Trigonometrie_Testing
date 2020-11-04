Feature: Perform trigonometric funtions
	As User
	I want to carry out trigonometic functions on my calculator
	So that I don´t have to calculate them myself.

@IvoOtero
Scenario: Sine
	Given I choose the <Sine> function in my calculator
	And the angular degree of the function is 3.14159265359
	When I press the <=> button 
	Then the result should be 0

Scenario: Cosine
	Given I choose the <Cosine> function in my calculator
	And the angular degree of the function is 3.14159265359
	When I press the <=> button 
	Then the result should be -1

Scenario: Tangent
	Given I choose the <Tangent> function in my calculator
	And the angular degree of the function is 3.14159265359
	When I press the <=> button 
	Then the result should be 0