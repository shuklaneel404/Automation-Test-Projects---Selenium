Feature: Ex07_Wishlist

A short summary of the feature

Scenario: 01_Validate User Can Add The Prododuct To Cart From Wishlist Page
	Given User Launched Chrome Browser successfully
	And User launch app url
	When user clicks on add to wish list button of HTC mobile 
	And User Clicks on Wishlist Link 
	Then User Is Able to Navigate to Wishlist Page
	When User Selects Add to Cart Checkbox
	And User Clicks on Add to Cart Button on Wishlist page
	Then User is redirected to Shopping Cart Page

Scenario: 02_Validate User is Able To Remove The Product From Wishlist 
	Given User Launched Chrome Browser successfully
	And User launch app url
	When user clicks on add to wish list button of HTC mobile 
	And User Clicks on Wishlist Link 
	Then User Is Able to Navigate to Wishlist Page
	When User Clicks on Remove Button 
	Then Wishlist becomes empty

Scenario: 03_Validate Qty Field does not Accepts Negative Value
	Given User Launched Chrome Browser successfully
	And User launch app url
	When user clicks on add to wish list button of HTC mobile 
	And User Clicks on Wishlist Link 
	Then User Is Able to Navigate to Wishlist Page
	When User Enters -1 in Qty Field
	And Clicks on Update Wishlist Button
	Then Error Message is Displayed Successfully 
	
