Feature: MakingOrder

Scenario: MakingOrder
	Given I navigate to the Login page 'https://apbeta.webkatalog.pl/Account/Logowanie?ReturnUrl=/'
	And I Login with Username 'Login' and Password 'Password'
	And I make new order
	And I search for specific item with specific number 'number'
	And I add item to order with amounts of : fv 'amount', par 'amount', WZ 'amount'
	When I press realize order
	Then ?
