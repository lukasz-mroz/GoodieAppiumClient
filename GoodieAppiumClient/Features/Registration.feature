Feature: Registartion

Background: 
Given I click registration on WelcomeScreen

@smoke
Scenario: Standard Registration
	Given I enter registration data User and Password on RegistrationPage
	And I choose Gender on RegistrationPage
	When I click register on RegistrationPage
	And I select brands and click Next button
	Then I should see PermissionLocalizationPage screen

Scenario: Facebook Registration
Given I click on Zarejestruj się z Faceboook
Then I should see PermissionLocalizationPage

Scenario: Google Registration
Given I click on Zarejestruj się z Google
Then I should see PermissionLocalizationPage