Feature: Login
	Simple calculator for adding two numbers


@mytag
Scenario: Login to website Check if user is able to Add, Edit, and Delete the Certificates and Add description and Edit description
	Given I login to the website
	Given I add a new Certification details
	Then that Certification Details should be displayed on my listings
	Then I Click on Edit button on certificate
	And  I edit details to certificate
	Then I press update button
	Then I verifiy certificate is updated correctly or not
	Then I click on Delete option in certificate list
	Then I check if certificate is deleted or not
	Given user clicks on the description icon under Profile page
	When user add description and save
	Then That Description should be displayed in Descrption tab
	Then User clicks on description Edit button
	And  user edit details on description box
	When User click on update button
	Then User verify description is updated correctly or not