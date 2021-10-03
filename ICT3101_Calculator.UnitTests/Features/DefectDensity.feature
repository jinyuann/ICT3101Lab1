Feature: DefectDensity
	In order to calculate the defect density first/second release
	As a Software Quality Metricenthusiast
	I want to use my calculator to do this

@DefectDesnsity
Scenario: Calculating Defect Desnsity
	Given I have a calculator
	When I have entered "36" and "20" into the calculator and press Defect Density
	Then the DD decimal result should be "1.8"

@DefectDesnsity
Scenario: Calculating Second Release
	Given I have a calculator
	When I have entered "50" and "20" and "4" into the calculator and press SSI
	Then the DD double result should be "66"
	