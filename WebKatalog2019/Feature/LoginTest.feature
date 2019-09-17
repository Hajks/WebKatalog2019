Feature: LoginTest

Scenario Outline: Successful Login by User
Given I navigate to the Login page 'https://apbeta.webkatalog.pl/Account/Logowanie?ReturnUrl=/'
When I Login with Username '<Login>' and Password '<Password>' on the Login Page
Then the page should contain element like this 'Reklamacje'

Examples: 
| Login  | Password |
| demo11 | demo11   |
| demo12 | demo12   |
| demo13 | demo13   |

Scenario Outline: Login with not valid login and password
Given I navigate to the Login page 'https://apbeta.webkatalog.pl/Account/Logowanie?ReturnUrl=/'
When I Login with Username '<Login>' and Password '<Password>' on the Login Page
Then the page should contain element like this 'Integra Software'

Examples: 
| Login         | Password         |
|               |                  |
| notvalidlogin |                  |
|               | notvalidpassword |
| demo12        |                  |
|               | demo12           |
| demo12        | notvalidpassword |
| notvalidlogin | demo12           |
| notvalidlogin | notvalidpassword |


