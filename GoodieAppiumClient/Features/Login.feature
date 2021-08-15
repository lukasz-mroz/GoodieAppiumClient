Feature: Login


Scenario: Perform simple log-in
        Given I enter email and password
        | email        | password |
        | all@moakt.cc | 123456   |
        And I click on Login
        Then I should see a WelcomePage