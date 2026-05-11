Feature: Login

  Scenario: Successful login
    Given user opens login page
    When user enters valid credentials
    Then dashboard page should appear

  Scenario: Invalid password
    Given user opens login page
    When user enters invalid credentials
    Then error message should appear

  Scenario: Empty login form
    Given user opens login page
    When user clicks login without entering data
    Then validation message should appear