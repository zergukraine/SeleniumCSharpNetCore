Feature: Login
	Check IF login works



@LoginSF
Scenario: Login user as Administarator
	Given I navigate to the app
	And I click a login link
	And I enter username and pass
			| UserName | Password |
			| admin    | password |
	And I click login
	Then I should see that user login to the app
