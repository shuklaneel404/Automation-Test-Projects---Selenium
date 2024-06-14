Feature: Ex03_LoginPage

Scenario: 01_Validate User is Able to Login Successfully With Valid Data
Given User Have Launched Chrome Browser
	And App Is Launched 
	And User is on nopCommerce App Landing Page
	When User Clicks on Login Link
	Then User is Navigate to Login Page Successfully
	When User Has Entered Valid Email "test@nopc.com"
	And User Has Entered Valid Password "Nopc@password.com"
	And Selects Remember Me Field
	And User Clicks On Login Button
	Then User Should Be Logged in Successfully

Scenario: 02_Validate User Should Not be Able to Loggin using Invalid Password
Given User Have Launched Chrome Browser
	And App Is Launched 
	And User is on nopCommerce App Landing Page
	When User Clicks on Login Link
	Then User is Navigate to Login Page Successfully
	When User Has Entered Valid Email "test@nopc.com"
	And User Has Entered Inalid Password "123Nopc@password.com"
	And Selects Remember Me Field
	When User Clicks On Login Button
	Then Error Message is Displayed “Login was unsuccessful”

Scenario: 03_Validate Login Functionality is Secured With SQL injection in Password Field
Given User Have Launched Chrome Browser
	And App Is Launched 
	And User is on nopCommerce App Landing Page
	When User Clicks on Login Link
	Then User is Navigate to Login Page Successfully
	When User Has Entered Valid Email "test@nopc.com"
	And User Has Entered Inalid Password with SQL Payload "DemoPass or true--"
	And Selects Remember Me Field
	When User Clicks On Login Button
	Then Error Message is Displayed “Login was unsuccessful”


