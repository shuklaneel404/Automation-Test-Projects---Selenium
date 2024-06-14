Feature: Ex12_UserInfoPage

Scenario: 01_validate User is able to Update and Save User Info
	Given User Have Launched The Chrome Browser
	And App Is Been Launched 
	And User is on The nopCommerce App Landing Page
	When User Clicks on the Login Link
	Then User is Navigate to the Login Page Successfully
	When User Has Entered the Valid Email "test@nopc.com"
	And User Has Entered Valid the Password "Nopc@password.com"
	And Selects the Remember Me Field
	And User Clicks On the Login Button
	Then User Should Be Logged in Successfully.
	When User Clicks on My Account Link 
	And Enters "NOPC" in Company Text Field
	And Clicks On Save Button
	Then User Information is Saved Successfully


Scenario: 02_Validate user is able to Change Password successfully
	Given User Have Launched The Chrome Browser
	And App Is Been Launched 
	And User is on The nopCommerce App Landing Page
	When User Clicks on the Login Link
	Then User is Navigate to the Login Page Successfully
	When User Has Entered the Valid Email "test@nopc.com"
	And User Has Entered Valid the Password "Nopc@password.com"
	And Selects the Remember Me Field
	And User Clicks On the Login Button
	Then User Should Be Logged in Successfully.
	When User Clicks on My Account Link 
	And Clicks on Change Password Link
	And Enters "Nopc@password.com" in Old Password 
	And Enters "NewNopc@password.com" in New Password Field
	And Enters "NewNopc@password.com" in Confirm Password Field
	And Click on Change Password Button
	Then Password Is Changed Successfully

Scenario: 03_Validate user is Not able to Change Password with Invalid Old Password
	Given User Have Launched The Chrome Browser
	And App Is Been Launched 
	And User is on The nopCommerce App Landing Page
	When User Clicks on the Login Link
	Then User is Navigate to the Login Page Successfully
	When User Has Entered the Valid Email "test@nopc.com"
	And User Has Entered Valid the Password "Nopc@password.com"
	And Selects the Remember Me Field
	And User Clicks On the Login Button
	Then User Should Be Logged in Successfully.
	When User Clicks on My Account Link 
	And Clicks on Change Password Link
	And Enters Invalid "InvalidNopc@password.com" in Old Password 
	And Enters "NewNopc@password.com" in New Password Field
	And Enters "NewNopc@password.com" in Confirm Password Field
	And Click on Change Password Button
	Then Password Error Message Is Displayed
	
