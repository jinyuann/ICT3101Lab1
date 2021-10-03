Feature: Factorial
	In order to test a factorial calculator program
	as a software tester
	i want to test whether the program works

@Factorial
Scenario: Normal Factorial Test
	Given I have a calculator
	When I have entered "5" into the calculator and press factorial
	Then the factorial result should be "120"

@Factorial
Scenario: Zero Factorial Test
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the factorial result should be "1"