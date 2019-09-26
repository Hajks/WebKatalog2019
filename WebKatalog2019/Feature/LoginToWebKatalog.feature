Feature: LoginToWebKatalogs
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Navigating to WebKatalog login page
Given the user has an open browser
When the user navigates to login page
Then the 'login' page should be displayed

Scenario Outline: Succesful user login to WebKatalog page
Given the user is on the 'login' page
When the user enters '<Login>' in the login field
And the user enters '<Password>' in the password field
And the user clicks login button
Then the 'dashboard' page should be displayed
And the logout button should be visible

Examples: 
| Login  | Password |
| demo11 | demo11   |
| demo12 | demo12   |
| demo13 | demo13   |

Scenario Outline: Not succesful user login to WebKatalog Page
Given the user is on the 'login' page
When the user enters '<Login>' in the login field
And the user enters '<Password>' in the password field
And the user clicks login button
Then validation '<Type>' error should be displayed

Examples: 
| Login         | Password         | Type |
|               |                  | any  |
| notvalidlogin |                  | any  |
|               | notvalidpassword | any  |
| demo12        |                  | any  |
|               | demo12           | any  |
| demo12        | notvalidpassword | any  |
| notvalidlogin | demo12           | any  |
| notvalidlogin | notvalidpassword | any  |

Scenario Outline: Proper validation showing up
Given the user is on the 'login' page
When the user enters '<Login>' in the login field
And the user enters '<Password>' in the password field
And the user clicks login button
Then validation '<Type>' error should be displayed

Examples:  
| Login         | Password         | Type                  |
|               |                  | emptyloginandpassword |
| notvalidlogin |                  | emptypassword         |
|               | notvalidpassword | emptylogin            |
| demo12        |                  | emptypassword         |
|               | demo12           | emptylogin            |
| demo12        | notvalidpassword | badloginandpassword   |
| notvalidlogin | demo12           | badloginandpassword   |
| notvalidlogin | notvalidpassword | badloginandpassword   |
#type: any, emptylogin, emptypassword, badloginandpassword, emptyloginandpassword



