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

@tag1
Scenario: Search a PDF by name
    Given the PDF name is "D:\\prueba1.pdf"
    When the PDF is searched by name
    Then the name from the PDF obtained should be "D:\\prueba1.pdf"

@tag1
Scenario: Find all PDFs in the repository
    Given there are multiple PDFs in the repository
    When all PDFs are searched
    Then all PDFs should be retrieved from the repository