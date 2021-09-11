Feature: Registration (with Providers)

Background:
	Given I delete an account before I create it.

@smoke
@positivetest
Scenario Outline: Facebook Registration
	Given I click on Zarejestruj się z Faceboook
	Then I should see PermissionLocalizationPage

	Examples:
		| loginfa                | paswordfa |
		| polskagoodie@gmail.com | 123Qwerty |

@smoke
@positivetest
Scenario Outline: Google Registration
	Given I click on Zarejestruj się z Google
	When I try to register using Google Account
	Then I should see PermissionLocalizationPage

	Examples:
		| logingoo               | passwordgoo |
		| polskagoodie@gmail.com | 123Qwerty   |