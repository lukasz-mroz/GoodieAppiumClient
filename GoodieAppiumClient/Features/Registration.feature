Feature: Registration


Scenario: Normal registration
          Given I enter email and password
          | email           | password |
          | random@moakt.cc | 123456   |
          And gender is Male
          Then I should see WelcomePage