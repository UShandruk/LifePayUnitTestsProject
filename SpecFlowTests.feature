Feature: Feature1

Тест на примере TestGreeting из UnitTestsPageMain.cs.
@tag1
Scenario: Open main page 
	Given I Opened main page
    And I see greetingText
	When DateTime.Now.Hour < 11
	Then T see greetintText contains "Доброе утро"

