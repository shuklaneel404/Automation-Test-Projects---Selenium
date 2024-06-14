Feature: Ex11_OrderHistory

Scenario: 01_Validate User is able to See The Order Details On Order Details Page
	Given User Have Launched the Chrome  Browser
	And App Is Launched.
	And User is on the nopCommerce App Landing Page.
	When User Clicks on the Login  Link.
	Then User is Navigate to the Login Page  Successfully.
	When User Has Entered the Valid Email  "test@nopc.com".
	And User Has Entered the Valid Password  "Nopc@password.com".
	And Selects the Remember Me Field.
	And User Clicks On the Login  Button.
	When user clicks on add to cart button ofHTC mobile.
	And Clicks On Shopping CartButton.
	Then User is Navigated toShopping Cart  Page.
	And HTC Product is Added successfully.
	When User Selects TermsandCondition Checkbox.
	And Clicks on Checkout Button.
	Then User is Navigated Checkout Page Successfully.
	When User Selects India From Country DropBox.
	And Enters "Vadodara" in City  Text Field.
	And Enters The "MyAddress" in  Address1 Fiels.
	And Enters 390008 in Postalcode.
	And Enters 9876543210 in phonenumber Field.
	And Clicks on Continue Button of  Billing Address.
	And User Selects Next Day Air  Radio Button.
	And Clicks on Continue Button  of Shipping Method.
	And User Selects Credit Card  Radio Button
	And User Clicks on Continue  Button of Payment Method
	And Enters "scheme" in Cardholder  name.
	And Enters 5555555555554444 in Card  Number Field.
	And User Selects valid In ExpiraryDate, Month Dropdown Field.
	And Enters 737 in Card Code  Field.
	And Clicks on Continue of Payment  Info.
	And User Clicks on Confirm Button of Confirm  Order Page.
	Then Order is Successfully  Processed.
	When user Clicks on Click Here For Order Details  LinK
	Then User is Navigated to Order Information  Page
	When User Clicks on Logout  Link. 
	Then User is Locked Out  Successfully 
	And Browser is  Closed