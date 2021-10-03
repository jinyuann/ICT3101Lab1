Feature: LogarithmicModel
	In order to calculate the Logarithmic model's failures/intensities
	As a Software Quality Metricenthusiast
	I want to use my calculator to do this

@Reliability
Scenario: Calculating failture intensity for logarithmic
	Given I have a calculator
	When I have entered "0.02" and "50" and "10" into the calculator and press failure intensity log
	Then the failure intensity log result should be "3.68"

@Reliability
Scenario: Calculating average number of expected failures for logarithmic
	Given I have a calculator
	When I have entered "0.02" and "10" and "10" into the calculator and press number of failure log
	Then the failure result log should be "54.93"

	
@Reliability
Scenario: Calculating in a single command
	Given I have a calculator
	When I have entered "0.02" and "10" and "10" and "50" into the calculator and press single logarithmic
	Then the failure intensity and result should be "3.68" and "54.93" 