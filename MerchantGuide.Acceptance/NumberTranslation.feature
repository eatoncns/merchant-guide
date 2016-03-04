Feature: NumberTranslation
	As an intergalactic merchant
	I want to translate from alien language to numbers
	So that I am never short changed

Scenario: Single word translation
	Given translation glob is I
	When I ask how much is glob?
	Then the result should be 1
