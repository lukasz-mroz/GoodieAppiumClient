Feature: LOG001
	Affected region: Login
	Login with email starting from welcome screen

@mytag
Scenario: Perform simple login
	Given I click login
	And I enter <Login> and <Password>
	When I try to login
	Then I should see WelcomeScreen

	Examples:
		| Login           | Password |
		| all@moakt.cc    | 123456   |
		| dziki@jmail.ovh | 123456   |