Feature: MakingOrders

Background:
	Given I make sure that im on the test page
	And I make new order
	And I search for specific item with specific 'Numer katalogowy' number 'CT848'
	And I add item with number 'CT848' to order with amounts of : fv '0', par '0', WZ '1'

	@LoginUser
Scenario Outline: MakingOrder
	And I search and add some items:
		| number  | fvamount | paramount | wzamount |
		| Ct848   | 0        | 0         | 1        |
		| 94737   | 0        | 0         | 1        |
		| CT848K4 | 0        | 0         | 1        |
	When I go to order summary
	Then I should see list of items with a correct sum value

	Examples:
		| type             | number  | fvamount | paramount | wzamount | number2 |
		| Numer katalogowy | Ct848   | 0        | 0         | 1        | Ct848   |
		| Numer katalogowy | 94737   | 0        | 0         | 1        | Ct848   |
		| Numer katalogowy | CT848K4 | 0        | 0         | 1        | Ct848   |