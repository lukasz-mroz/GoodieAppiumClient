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

@smoke
@positivetest
Scenario: Facebook Registration
Given I click on Zarejestruj się z Faceboook
Then I should see PermissionLocalizationPage

@smoke
@positivetest
Scenario: Google Registration
Given I click on Zarejestruj się z Google
When I try to register using Google Account
Then I should see PermissionLocalizationPage