Feature: MakingOrders

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

