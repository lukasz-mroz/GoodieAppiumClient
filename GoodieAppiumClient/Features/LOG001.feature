Feature: LOG001
	Affected region: Login
	Login with email starting from welcome screen

@smoke
Scenario: Perform simple login
	Given I click login (under buttons)
	And I enter own data (email and password)
	When I press try to log in
	Then Welcome screen should be visible


	Examples:
  | Login        | Password |
  | all@moakt.cc |123456|
