Feature: Guru99 Add New Customer
	

@mytag
Scenario: Add New Customer 
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	And I click on the New Customer Link
	Then I clean up the environment

Scenario: Add No Customer Name
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	And I click on the New Customer Link
	And I enter the character " " in the Name Field 
	Then I clean up the environment


Scenario: Add New Customer Name with special characters.
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	And I click on the New Customer Link
	And I enter the Customer Name "Al1c£ Nank8a"
	Then I clean up the environment

Scenario: Add New Customer Name with space
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	And I click on the New Customer Link
	And I enter the Customer name with space " Alice"
	Then I clean up the environment

Scenario: Select a gender
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	And I click on the New Customer Link
	And I select a gender 
	Then I clean up the environment

Scenario: Select No Date Of Birth 
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	And I click on the New Customer Link
	And I do not select the date of birth "dd/mm/yyyy"
	Then I clean up the environment


Scenario: Select different format for DOB  
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	And I click on the New Customer Link
	And I enter the Date of Birth "dd/mm/yy"
	Then I clean up the environment

Scenario: Enter different formt for DOB  
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	And I click on the New Customer Link
	And I enter the format for DOB as "d/m/yy"
	

Scenario: Adding No Customer Address
	Given I open chrome
	And I go to http://www.demo.guru99.com/V4/ 
	When I enter the username mngr111936
	And I enter the password sUmagYp
	And I click the login button
	And I am successfully logged in
	And I click on the New Customer Link
	And I do not enter an address 
	Then I clean up the environment
	

   