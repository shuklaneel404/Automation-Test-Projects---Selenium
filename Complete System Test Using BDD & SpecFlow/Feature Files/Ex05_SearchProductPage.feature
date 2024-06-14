Feature: Ex05_SearchProductPage


Scenario: 01_Validate Search Field with Valid Data
	Given User Launched The Chrome Browser
	And User Launched App
	When User Clicks on Search Link from Footer
	Then User Redirects To Search Product Page
	When User Search Products With More Than 3 Characters
	Then Product Search is Successfull 

Scenario: 02_Validate Search Field with Invalid Data
	Given User Launched The Chrome Browser
	And User Launched App
	When User Clicks on Search Link from Footer
	Then User Redirects To Search Product Page
	When User Search Products With Less Than 3 Characters
	Then Error Must Be Displayed - Search term minimum length is 3 characters

Scenario: 03_Validate Advance Search Functionality
	Given User Launched The Chrome Browser
	And User Launched App
	When User Clicks on Search Link from Footer
	Then User Redirects To Search Product Page
	When User Search Products With Valid Data
	And User Clicks on Advance Search Checkbox
	And User Selects Electronics From Category DropBox
	And user Selects Automatically Search Sub Categories Checkbox
	And User Selects Apple From Manufacturer DropBox
	Then Apple icam Product Should Be Displayed

