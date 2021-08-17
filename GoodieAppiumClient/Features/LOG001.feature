Feature: LOG001
	Affected region: Login
	Login with email starting from welcome screen

@smoke
Scenario: Perform simple login
	Given I click login on WelcomeScreen
	And I enter on LoginPage <Login> and <Password>
	When I try to login on LoginPage
	Then I should see PermissionLocalizationPage

	Examples:
		| Login           | Password |
		| all@moakt.cc    | 123456   |
		| dziki@jmail.ovh | 123456   |

