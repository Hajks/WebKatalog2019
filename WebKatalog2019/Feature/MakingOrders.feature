Feature: MakingOrders

@LoginUser
Scenario Outline: MakingOrder
	Given I make sure that im on the page 'https://apbeta.webkatalog.pl/artykul'
	And I make new order
	And I search for specific item with specific '<type>' number '<number>'
	And I add item with number '<number>' to order with amounts of : fv '<fvamount>', par '<paramount>', WZ '<wzamount>'
	When I go to order summary
	Then I should see list of items with a correct sum value

Examples: 
| type             | number  | fvamount | paramount | wzamount |
| Numer katalogowy | Ct848   | 0        | 0         | 1        |
| Numer katalogowy | 94737   | 0        | 0         | 1        |
| Numer katalogowy | CT848K4 | 0        | 0         | 1        |
		 
									






	
