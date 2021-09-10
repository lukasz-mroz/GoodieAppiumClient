Feature: Registartion

Background: 
Given I click registration on WelcomeScreen

@smoke
@positivetest
Scenario: Standard Registration
	Given I enter registration data User and Password on RegistrationPage
	And I choose Gender on RegistrationPage
	When I click register on RegistrationPage
	And I select brands and click Next button
	Then I should see PermissionLocalizationPage screen

