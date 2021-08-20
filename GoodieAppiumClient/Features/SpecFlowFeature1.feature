Feature: LOG002
	Affected region: Login


@mytag
Scenario: Login with SM account starting from welcome screen
	Given I click login on Welcome Screen
	And I enter on google account on LoginPage
	When I try to login using Google Account
	Then I should see next screen