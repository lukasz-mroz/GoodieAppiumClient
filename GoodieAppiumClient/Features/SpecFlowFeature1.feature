Feature: LoginFeature
	Normal process using known credentials

@smoke
Scenario: Perform simple login
	Given I enter email and password
	And I choose Male gender
	Then I should see WelcomeScreen