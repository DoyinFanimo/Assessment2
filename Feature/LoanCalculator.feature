Feature: LoanCalculator
	As a customer I want Loan Repayment day to default to prior friday
	when I select a Repayment day that is Saturday or Sunday


@smoke
Scenario: Loan Amount with Repayment date on a Saturday
	Given I navigate to the site "https://www.auden.co.uk/credit/shorttermloan"
	When I select a loan amount that is not min or max
	And I select the first Saturday in July as repayment date
	Then the first repayment date option should default to the prior friday

@smoke
Scenario: Loan Amount with Repayment date on a Sunday
	Given I navigate to the site "https://www.auden.co.uk/credit/shorttermloan"
	When I select a loan amount that is not min or max
	And I select the first Sunday in July as repayment date
	Then the first repayment date option should default to the prior friday

