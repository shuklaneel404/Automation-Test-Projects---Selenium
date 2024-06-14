Feature: Ex08_AddToCart

Scenario: 01_Validate User is able to add Product In Shopping Cart
	Given User Have Launched Chrome Browser.
	And App Is Launched .
	And User is on nopCommerce App Landing Page.
	When User Clicks on Login Link.
	Then User is Navigate to Login Page Successfully.
	When User Has Entered Valid Email "test@nopc.com".
	And User Has Entered Valid Password "Nopc@password.com".
	And Selects Remember Me Field.
	And User Clicks On Login Button.
	When user clicks on add to cart button of HTC mobile.
	And Clicks On Shopping Cart Button.
	Then User is Navigated to Shopping Cart Page
	And HTC Product is Added successfully

Scenario: 02_Validate User is Able to Update the Qty in From Shopping Cart Page
	Given User Have Launched Chrome Browser.
	And App Is Launched .
	And User is on nopCommerce App Landing Page.
	When User Clicks on Login Link.
	Then User is Navigate to Login Page Successfully.
	When User Has Entered Valid Email "test@nopc.com".
	And User Has Entered Valid Password "Nopc@password.com".
	And Selects Remember Me Field.
	And User Clicks On Login Button.
	When user clicks on add to cart button of HTC mobile.
	And Clicks On Shopping Cart Button.
	Then User is Navigated to Shopping Cart Page
	And HTC Product is Added successfully
	When user Clears The Qty Field
	And Enters 2 in the Qty Field
	And Clicks on Update Shopping Cart Button
	Then Cart is Updated Successfully

Scenario: 03_Validate User is Not Able to Update the Qty with Negative Value
	Given User Have Launched Chrome Browser.
	And App Is Launched .
	And User is on nopCommerce App Landing Page.
	When User Clicks on Login Link.
	Then User is Navigate to Login Page Successfully.
	When User Has Entered Valid Email "test@nopc.com".
	And User Has Entered Valid Password "Nopc@password.com".
	And Selects Remember Me Field.
	And User Clicks On Login Button.
	When user clicks on add to cart button of HTC mobile.
	And Clicks On Shopping Cart Button.
	Then User is Navigated to Shopping Cart Page
	And HTC Product is Added successfully
	When user Clears The Qty Field
	And Enters -1 in the Qty Field.
	And Clicks on Update Shopping Cart Button
	Then The Error Message Is Displayed Successfully


	
	