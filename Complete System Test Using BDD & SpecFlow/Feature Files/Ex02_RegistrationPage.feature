Feature: Ex02_RegistrationPage

Scenario: 01_Validate User is Able to Register with Valid Data
	Given Chrome Browser is Opened Successfully
	And User is on The nopCommerce Landing Page
	When User Clicks on Register Link
	Then User Should Navigate to Register Page
	When User Enters "Arjun" in First Name
	And User Enters "Linux" in Last Name 
	And User Enters "test@nopc.com" in Email
	And User Enters "NOPC" in Company Details
	And User Selected Newsletter Checkbox
	And User Enteres "Nopc@password.com" in Password
	And User Entered "Nopc@password.com" Confirm Password Same as Password
	And User Clicks on Register Button
	Then User Should Registered Successfully

Scenario: 02_Validate User Should Not Be Able to Register By Keeping Mandatory Fields Blank
	Given Chrome Browser is Opened Successfully
	And User is on The nopCommerce Landing Page
	When User Clicks on Register Link
	Then User Should Navigate to Register Page
	When User Enters Keeps Blank "" in First Name
	And User Enters "Linux" in Last Name 
	And User Enters "test@nopc.com" in Email
	And User Enters "NOPC" in Company Details
	And User Selected Newsletter Checkbox
	And User Enteres "Nopc@password.com" in Password
	And User Entered "Nopc@password.com" Confirm Password Same as Password
	And User Clicks on Register Button
	Then Error Should Be Displayed “First Name Field Is Required.” 

Scenario: 03_Validate User Should Not Be Able to Register Different Password & Confirm Password
Given Chrome Browser is Opened Successfully
	And User is on The nopCommerce Landing Page
	When User Clicks on Register Link
	Then User Should Navigate to Register Page
	When User Enters "Arjun" in First Name
	And User Enters "Linux" in Last Name 
	And User Enters "test@nopc.com" in Email
	And User Enters "NOPC" in Company Details
	And User Selected Newsletter Checkbox
	And User Enteres "Nopc@password.com" in Password
	And User Entered "123Nopc@password.com" Confirm Password Not Same as Password
	Then Error Should Be Displayed “The password and confirmation password do not match..” 

Scenario: 04_Validate Password Field Does Not Accepts Less Than 6 Characters
Given Chrome Browser is Opened Successfully
	And User is on The nopCommerce Landing Page
	When User Clicks on Register Link
	Then User Should Navigate to Register Page
	When User Enters "Arjun" in First Name
	And User Enters "Linux" in Last Name 
	And User Enters "test@nopc.com" in Email
	And User Enteres "Pwd" Password in less then 6 Characters
	Then Error Should Be Displayed “The password and confirmation password do not match..” Password must meet the following rules: must have at least 6 characters