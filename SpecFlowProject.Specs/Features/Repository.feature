Feature: Repository

This feature has all the necessary methods for a repository to perform the CRUD operations on an object.

@tag1
Scenario: Search a PDF entry
	Given the id is 1
	When the id is searched
	Then the id from the pdf obtained should be 1
