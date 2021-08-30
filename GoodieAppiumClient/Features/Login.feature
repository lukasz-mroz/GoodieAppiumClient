@smoke
Feature: Login

Background:
	Given I click login on WelcomeScreen

@smoke
Scenario Outline: Login with email starting from welcome screen
	Given I enter on LoginPage <Login> and <Password>
	When I try to login on LoginPage screen
	Then I should see PermissionLocalizationPage

	Examples:
		| Login           | Password |
		| all@moakt.cc    | 123456   |
		| dziki@jmail.ovh | 123456   |

@smoke
@negativetest
Scenario Outline: Login with email using incorrect data
	Given I enter on LoginPage <WrongLogin> and <WrongPassword>
	When I try to login on LoginPage screen
	Then I should see tooltip

	Examples:
		| WrongLogin      | WrongPassword |
		| asdsds@moakt.cc | 12345677      |

@smoke
Scenario: Login with SM account starting from welcome screen
	Given I enter on google account on LoginPage
	When I try to login using Google Account
	Then I should see PermissionLocalizationPage

@smoke
@negativetest
Scenario: Login using email using no data to login and password
	Given I do not enter any Login and Password
	When I try to login on LoginPage screen
	Then I should see validation error