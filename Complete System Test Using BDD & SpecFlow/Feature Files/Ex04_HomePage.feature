Feature: Ex04_HomePage


Scenario: 01_Validate User is Able to Navigate to  My Account Link From Home Page
	Given User Launched Chrome Browser
	And App is Launched 
	And user is on Landing Page
	And User Clicks on Login Link.
	And User Navigates to Login Page
	When User Has Entered Valid Email "test@nopc.com" .
	And User Has Entered Valid Password "Nopc@password.com" .
	When User Clicks on Login Button
	Then User is Navigated To Home Page
	When User Clicks on My Account Link.
	Then User is Redirected To “My Account – Customer Info” Page

Scenario: 02_Validate User is able to Logout successfully from Home Page
	Given User Launched Chrome Browser
	And App is Launched 
	And user is on Landing Page
	And User Clicks on Login Link.
	And User Navigates to Login Page
	When User Has Entered Valid Email "test@nopc.com" .
	And User Has Entered Valid Password "Nopc@password.com" .
	When User Clicks on Login Button
	Then User is Navigated To Home Page
	When User Clicks on Logout Link
	Then User is Redirected To “Landing Page” Page
