Feature: NumberTranslation
	As an intergalactic merchant
	I want to translate from alien language to numbers
	So that I am never short changed

Scenario Outline: Single word translation
	Given translation glob is <numeral>
	When I ask how much is <value>?
	Then the result should be <result>
	
	Scenarios: 
	  | value | numeral | result                 |
	  | glob  | I       | glob is 1              |
	  | glob  | V       | glob is 5              |
	  | foo   | I       | No translation for foo |

Scenario: Multi-word translation
	Given these translations
	| translation |
	| glob is I   |
	| prok is V   |
	| pish is X   |
	| tegj is L   |
	When I ask how much is pish tegj glob glob?
	Then the result should be pish tegj glob glob is 42
