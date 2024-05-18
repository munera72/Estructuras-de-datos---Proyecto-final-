Feature: Repository

This feature has all the necessary methods for a repository to perform the CRUD operations on an object.

@tag1
Scenario: Search a PDF entry
	Given the id is 1
	When the pdf is searched
	Then the id from the pdf obtained should be 1


@tag1
Scenario: Delete a PDF entry
	Given the id is 3
	When the pdf with that id is deleted
	And the pdf is searched
	Then the result of the search should be null
