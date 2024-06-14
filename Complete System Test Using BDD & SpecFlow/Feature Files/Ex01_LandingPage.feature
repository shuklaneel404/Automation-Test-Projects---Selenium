Feature: Ex01_LandingPage

Scenario: 01_Validate Register Link is Displayed On Landing Page
	Given Chrome is opened 
	When User launch the url
	Then User Navigates to Landing Page
	And Register Link is Displayed Properly
	
Scenario: 02_Validate Register Link is Enabled On Landing Page
	Given Chrome is opened 
	When User launch the url
	Then User Navigates to Landing Page
	And Register Link is Enabled Properly

Scenario: 03_Validate Login Link is Displayed On Landing Page
	Given Chrome is opened 
	When User launch the url
	Then User Navigates to Landing Page
	And Login Link is Displayed Properly
	
Scenario: 04_Validate Login Link is Enabled On Landing Page
	Given Chrome is opened 
	When User launch the url
	Then User Navigates to Landing Page
	And Login Link is Enabled Properly

Scenario: 05_Validate User is Able to See Featured Products on Landing Page
	Given Chrome is opened 
	When User launch the url
	Then User Navigates to Landing Page
	And Featured Products Are Diaplayed Properly
	