Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metricenthusiast
	I want to use my calculator to do this
	
	#100= failure inifinite time
	#50 = experienced failure
	#10 =faillure/cpu hour

@Reliability
Scenario: Calculating failture intensity
	Given I have a calculator
	When I have entered "100" and "50" and "10" into the calculator and press failure intensity
	Then the failure intensity result should be "5"

@Reliability
Scenario: Calculating average number of expected failures
	Given I have a calculator
	When I have entered "100" and "10" and "10" into the calculator and press number of failure
	Then the failure result should be "63.21"