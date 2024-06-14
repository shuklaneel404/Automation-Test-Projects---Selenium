Feature: Ex10_PaymentPage


Scenario: 01_Validate User is able to Complete The Payment Proceess Successfully With Valid Credit Card Details
	Given User Have Launched Chrome  Browser.
	And App Is  Launched.
	And User is on nopCommerce App Landing  Page.
	When User Clicks on Login  Link.
	Then User is Navigate to Login Page  Successfully.
	When User Has Entered Valid Email  "test@nopc.com".
	And User Has Entered Valid Password  "Nopc@password.com".
	And Selects Remember Me  Field.
	And User Clicks On Login  Button.
	When user clicks on add to cart button of HTC  mobile.
	And Clicks On Shopping Cart  Button.
	Then User is Navigated to Shopping Cart  Page.
	And HTC Product is Added  successfully.
	When User Selects Terms and Condition Checkbox.
	And Clicks on Checkout  Button.
	Then User is Navigated to Checkout Page Successfully.
	When User Selects India From Country Drop Box.
	And Enters "Vadodara" in City Text Field.
	And Enters The "MyAddress" in Address1 Fiels.
	And Enters 390008 in Postal code.
	And Enters 9876543210 in phone Number Field.
	And Clicks on Continue Button of Billing Address.
	And User Selects Next Day Air Radio Button.
	And Clicks on Continue Button of Shipping Method.
	And User Selects Credit Card Radio Button
	And User Clicks on Continue Button of Payment Method
	And Enters "scheme" in Cardholder name.
	And Enters 5555555555554444 in Card Number Field.
	And User Selects valid In Expirary Date, Month Dropdown Field.
	And Enters 737 in Card Code Field.
	And Clicks on Continue of Payment Info.
	And User Clicks on Confirm Button of Confirm Order Page.
	Then Order is Successfully Processed.
	When User Clicks on Logout Link. 
	Then User is Locked Out Successfully 
	And Browser is Closed

Scenario: 02_Validate User is able to Complete The Payment Proceess with Money Order Feature 
	Given User Have Launched Chrome  Browser.
	And App Is  Launched.
	And User is on nopCommerce App Landing  Page.
	When User Clicks on Login  Link.
	Then User is Navigate to Login Page  Successfully.
	When User Has Entered Valid Email  "test@nopc.com".
	And User Has Entered Valid Password  "Nopc@password.com".
	And Selects Remember Me  Field.
	And User Clicks On Login  Button.
	When user clicks on add to cart button of HTC  mobile.
	And Clicks On Shopping Cart  Button.
	Then User is Navigated to Shopping Cart  Page.
	And HTC Product is Added  successfully.
	When User Selects Terms and Condition Checkbox.
	And Clicks on Checkout  Button.
	Then User is Navigated to Checkout Page Successfully.
	When User Selects India From Country Drop Box.
	And Enters "Vadodara" in City Text Field.
	And Enters The "MyAddress" in Address1 Fiels.
	And Enters 390008 in Postal code.
	And Enters 9876543210 in phone Number Field.
	And Clicks on Continue Button of Billing Address.
	And User Selects Next Day Air Radio Button.
	And Clicks on Continue Button of Shipping Method.
	And Clicks on Continue of the Payment Info..
	And User Clicks on Confirm Button of Confirm Order Page.
	Then Order is Successfully Processed with Money Order Feature
	When User Clicks on Logout Link. 
	Then User is Locked Out Successfully 
	And Browser is Closed
	