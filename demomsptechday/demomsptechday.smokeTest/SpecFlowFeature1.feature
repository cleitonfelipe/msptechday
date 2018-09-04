Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Accesando o site e verificando o titulo
	Given acessei o site "http://demomsptechday.azurewebsites.net/"
	And pequei o titulo do site
	When I press enter
	Then the result should be "Demo MSP Tech Day"
