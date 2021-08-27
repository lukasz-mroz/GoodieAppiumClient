﻿Feature: Registartion


@smoke
Scenario: Registration with email starting from welcome screen
	Given I click registration on WelcomeScreen
	And I enter registration data User and Password on RegistrationPage
	And I choose Gender on RegistrationPage
	When I click register on RegistrationPage
	And I select brands and click Next button
	Then I should see PermissionLocalizationPage screen

Scenario: Login with SM account starting from welcome screen
	Given I click login on Welcome Screen
	And I enter on google account on LoginPage
	When I try to login using Google Account
	Then I should see next screen