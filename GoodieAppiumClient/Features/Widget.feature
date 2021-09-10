Feature: Widgets
	Simple calculator for adding two numbers

@smoke
Scenario Outline: Check if all widgets are displayed
	Given I click login on WelcomeScreen
	And I enter on LoginPage <Login> and <Password>
	When I try to login on LoginPage screen
	And I skip permissionLocalizationPage
	Then I should see the content of the app

	Examples:
		| Login        | Password |
		| all@moakt.cc | 123456   |