Feature: Registration (with Providers)
	Simple calculator for adding two numbers

Background:
	Given I delete an account before I create it.

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