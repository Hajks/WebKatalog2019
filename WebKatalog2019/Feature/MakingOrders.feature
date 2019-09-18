Feature: MakingOrders

Scenario Outline: MakingOrder
	Given I navigate to the page 'https://apbeta.webkatalog.pl/Account/Logowanie?ReturnUrl=/'
	And I Login with Username 'demo12' and Password 'demo12' on the Login Page
	And I make sure that im on the page 'https://apbeta.webkatalog.pl/artykul'
	And I make new order
	And I search for specific item with specific '<type>' number '<number>'
	And I add item with number '<number>' to order with amounts of : fv '<fvamount>', par '<paramount>', WZ '<wzamount>'
	When I go to order summary
	Then I should see list of items with a correct sum value


	 		 | type             | number  |
		 | Numer katalogowy | Ct848   |
		 | Numer katalogowy | 94737   |
		 | Numer katalogowy | CT848K4 |  
									
		| fvamount | paramount | wzamount |
	| 0        | 0         | 1        |
	| 0        | 0         | 1        |
	| 0        | 0         | 1        |


	
