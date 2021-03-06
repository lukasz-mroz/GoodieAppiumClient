@smoke
Feature: Login

Background:
	Given I click login on WelcomeScreen

@smoke
Scenario Outline: Standard login
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
Scenario: Google login
	Given I enter on google account on LoginPage
	When I try to login using Google Account
	Then I should see PermissionLocalizationPage

@smoke
@negativetest
Scenario: Login using email using no data to login and password
	Given I do not enter any Login and Password
	When I try to login on LoginPage screen
	Then I should see validation error

Scenario Outline: Log in and log out
	Given I enter on LoginPage <Login> and <Password>
	When I try to login on LoginPage screen
	And I skip permissionLocalizationPage
	And I go to Profile
	And I scroll down until the end of the screen
	And I click log out
	Then I should see WelcomeScreen

	Examples: 
	| Login        | Password |
	| all@moakt.cc | 123456   | 

Scenario Outline: Facebook login
Given I click Zaloguj się z Facebook
Then I should see PermissionLocalizationPage