Feature: AppiumTest

@smoke 
Scenario: Perform simple login test
    Given I launch the application
    Given I enter email and password
      | email        | password |
      | all@moakt.cc | 123456   |
    And I select login