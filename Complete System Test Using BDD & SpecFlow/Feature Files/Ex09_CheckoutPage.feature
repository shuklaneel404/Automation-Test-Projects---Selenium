Feature: Ex09_CheckoutPage


Scenario: 01_Validate User is Able To Successfully Complete The Ckeckout Process till Shipping Method
	Given User Have Launched Chrome  Browser 
	And App Is  Launched
	And User is on nopCommerce App Landing  Page
	When User Clicks on Login  Link
	Then User is Navigate to Login Page  Successfully
	When User Has Entered Valid Email  "test@nopc.com"
	And User Has Entered Valid Password  "Nopc@password.com"
	And Selects Remember Me  Field
	And User Clicks On Login  Button
	When user clicks on add to cart button of HTC  mobile
	And Clicks On Shopping Cart  Button
	Then User is Navigated to Shopping Cart  Page
	And HTC Product is Added  successfully
	When User Selects Terms and Condition Checkbox
	And Clicks on Checkout  Button
	Then User is Navigated to Checkout Page Successfully
	When User Selects India From Country Drop Box
	And Enters "Vadodara" in City Text Field
	And Enters The "MyAddress" in Address1 Fiels
	And Enters 390008 in Postal code
	And Enters 9876543210 in phone Number Field
	And Clicks on Continue Button of Billing Address
	And User Selects Next Day Air Radio Button
	And Clicks on Continue Button of Shipping Method 
	Then User is Successfully Navigated To Payment Method Page

Scenario: 02_Validate User is not Allowed to Checkout Without Selecting Terms and Service Checkbox
	Given User Have Launched Chrome  Browser 
	And App Is  Launched
	And User is on nopCommerce App Landing  Page
	When User Clicks on Login  Link
	Then User is Navigate to Login Page  Successfully
	When User Has Entered Valid Email  "test@nopc.com"
	And User Has Entered Valid Password  "Nopc@password.com"
	And Selects Remember Me  Field
	And User Clicks On Login  Button
	When user clicks on add to cart button of HTC  mobile
	And Clicks On Shopping Cart  Button
	Then User is Navigated to Shopping Cart  Page
	And HTC Product is Added  successfully
	When User Do Not Selects Terms and Condition Checkbox
	And Clicks on Checkout  Button
	Then Error Message should be displayed Please accept the terms of service before the next step.

	



	
