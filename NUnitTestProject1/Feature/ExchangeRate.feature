Feature: ExchangeRate
	Get Exchange rates for Euro currency


@feature
Scenario: Compare request URl
	Given I created request with Url
	And I executed the request
	Then I should have same url after execution

@feature
Scenario: Verify response status
	Given I created request with Url
	And I executed the request
	Then I should have Ok status

@feature
Scenario: Should exist response content
	Given I created request with Url
	And I executed the request
	Then I should have content

@feature
Scenario: Verify date from response
	Given I created request with Url
	And I executed the request
	Then I should have latest date

@feature
Scenario: Verify exchange rate base currency
	Given I created request with Url
	And I executed the request
	Then I should euro base currency

@feature
Scenario: Verify exchange rates for CAD from specific date
	Given I created request with Url
	And I executed the request
	Then I should have exactly same exchange rate CAD like in database