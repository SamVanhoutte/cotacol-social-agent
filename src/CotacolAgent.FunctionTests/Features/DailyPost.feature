Feature: CotacolPoster

Cotacol description

@mytag
Scenario: A description of a cotacol should contain the right content 
	Given the cotacol number is 270
	And the post type is Bluesky
	When the post is created
	Then the description should contain Stockai
	And the description should contain Flamierge
