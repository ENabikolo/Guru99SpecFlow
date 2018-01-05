Feature: Guru99 Login
	
@mytag
Scenario: Valid Login 
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	Then I clean up the environnement
