Feature: Ex06_ProductDetailsPage

Scenario: 01_Validate Add to Cart Functionality On Product Details Page
	Given User Launched the Chrome Browser
	And User Launched the App
	And User is on Landing Page.
	When User Clicks On “$25 Virtual Gift Card” Product Link
	Then User is Navigated To Product Details Page of “$25 Virtaul Gift Card”
	When User Enters Recipient's Name:
	And  User Enters Recipient's Email:
	And User Enters Your Name:
	And USer Enters Your Email:
	And USer Enters Message 
	And User Enter 2 in Qty Text Box
	And User Clicks on Add to Cart Button
	Then 2 Qty Must be Added in Cart Successfully

Scenario: 02_validate Email a Friend Feature Without Login 
	Given User Launched the Chrome Browser
	And User Launched the App
	And User is on Landing Page.
	When User Clicks On “$25 Virtual Gift Card” Product Link
	Then User is Navigated To Product Details Page of “$25 Virtaul Gift Card”
	When User Clicks On Email a Frined Button
	Then User is Navigated To Email a Friend Page
	When User Enters "myfriend@email.com" in email field
	And Enters "test@nopc.com" in Your Email address Field
	And Enters PErsonal Message "A Gift For You My Friend"
	And CLicks on Send Email Button
	Then Error Message is Displayed - Only registered customers can use email a friend feature

	
