Feature: Ex001_EndToEndFlow

Scenario: 01_Validate User Can Purchase Single Product(HTC One M8) Successfully
	Given User launch The Browser
	And User Launch The App
	And User is on Landing Page
	And User Clicks on Login Link
	When User Enters "Test1@email.com" in Email Field
	And Enters "Password@nopc.test" in Password Field
	And Clicks on Login Button
	Then User Nevigates to Home Page
	When User Clicks On HTC Product Link From Featured Products
	Then User Navigates To HTC Product Details Page
	When User Clicks On Add To Cart Button of HTC Product
	Then HTC One M8 is Added To Cart Successfully
	When Clicks On Shopping Cart Button
	Then User Navigates To Shopping Cart Page
	When User Clicks On T&C Checkbox on Shopping Cart Button
	And Clicks on Checkout Button
	Then User Navigates to Checkout Page
	When User Selects India From Country Dropdown Menu
	And Enters "Vadodara" in City 
	And Enters "My Address" in Address1
	And Enters "PostCode" in Zip/postal code
	And Enters 9876543210 Phone Numnber Field
	And Clicks on Continue 
	And Selects Next Day Air Shipping Method Check Box 
	And Clicks On Continue Button of shipping
	And Selects Credit Card Checkbox in Payment Method
	And Enters "scheme" in Cardholder name
	And Enters 5555555555554444 in Card Number Field
	And User Selects valid In Expirary Date, Month Dropdown Field
	And Enters 737 in Card Code Field
	And Clicks on Continue of Payment Info
	And User Clicks on Confirm Button of Confirm Order Page
	Then Order is Successfully Processed
	When user Clicks on - Click Here For Order Details LinK
	Then User is Navigated to Order Information Page
	When User Clicks on Logout link 
	Then Account is Logged out Successfully
	And User closed The Browser

Scenario: 02_Validate User Should Not Nevigate To Someone Else Order Info By Changing The Order ID In URL
	Given User launch The Browser
	And User Launch The App
	And User is on Landing Page
	And User Clicks on Login Link
	When User Enters "Test1@email.com" in Email Field
	And Enters "Password@nopc.test" in Password Field
	And Clicks on Login Button
	Then User Nevigates to Home Page
	When User Clicks On HTC Product Link From Featured Products
	Then User Navigates To HTC Product Details Page
	When User Clicks On Add To Cart Button of HTC Product
	Then HTC One M8 is Added To Cart Successfully
	When Clicks On Shopping Cart Button
	Then User Navigates To Shopping Cart Page
	When User Clicks On T&C Checkbox on Shopping Cart Button
	And Clicks on Checkout Button
	Then User Navigates to Checkout Page
	When User Selects India From Country Dropdown Menu
	And Enters "Vadodara" in City 
	And Enters "My Address" in Address1
	And Enters "PostCode" in Zip/postal code
	And Enters 9876543210 Phone Numnber Field
	And Clicks on Continue 
	And Selects Next Day Air Shipping Method Check Box 
	And Clicks On Continue Button of shipping
	And Selects Credit Card Checkbox in Payment Method
	And Enters "scheme" in Cardholder name
	And Enters 5555555555554444 in Card Number Field
	And User Selects valid In Expirary Date, Month Dropdown Field
	And Enters 737 in Card Code Field
	And Clicks on Continue of Payment Info
	And User Clicks on Confirm Button of Confirm Order Page
	Then Order is Successfully Processed
	When user Clicks on - Click Here For Order Details LinK
	Then Order ID is Added To URL
	When User Changes the Order ID in URL and Launch the URL
	Then User is asked to login Again with Another Account

