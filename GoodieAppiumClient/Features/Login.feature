Feature: Login

@smoke
Scenario: Login with email starting from welcome screen
	Given I click login on WelcomeScreen
	And I enter on LoginPage <Login> and <Password>
	When I try to login on LoginPage
	Then I should see PermissionLocalizationPage

	Examples:
		| Login           | Password |
		| all@moakt.cc    | 123456   |
		| dziki@jmail.ovh | 123456   |

@smoke
Scenario: Login with email using incorrect data
Given I click login on Welcome Screen
And I enter on LoginPage <p0> and <p1>
When I try to login on LoginPage
Then I should see tooltip

Examples:
| p0           | p1 |
| asdsds@moakt.cc | 12345677 |
