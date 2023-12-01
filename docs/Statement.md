# Yodlee.ApiClient.Model.Statement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Apr** | **double** | The APR applied to the balance on the credit card account, as available in the statement.&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; In case of variable APR, the APR available on the statement might differ from the APR available at the account-level.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**CashApr** | **double** | The APR applicable to cash withdrawals on the credit card account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**BillingPeriodStart** | **string** | The start date of the statement period.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**DueDate** | **string** | The date by when the minimum payment is due to be paid.&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; The due date that appears in the statement may differ from the due date at the account-level.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**InterestAmount** | [**Money**](Money.md) |  | [optional] 
**StatementDate** | **string** | The date on which the statement is generated.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**CashAdvance** | [**Money**](Money.md) |  | [optional] 
**BillingPeriodEnd** | **string** | The end date of the statement period.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**PrincipalAmount** | [**Money**](Money.md) |  | [optional] 
**LoanBalance** | [**Money**](Money.md) |  | [optional] 
**AmountDue** | [**Money**](Money.md) |  | [optional] 
**AccountId** | **long** | Account to which the statement belongs to.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**LastUpdated** | **string** | The date when the account was last updated by Yodlee.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**IsLatest** | **bool** | The field is set to true if the statement is the latest generated statement.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**MinimumPayment** | [**Money**](Money.md) |  | [optional] 
**LastPaymentDate** | **string** | The date on which the last payment was done during the billing cycle.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**LastPaymentAmount** | [**Money**](Money.md) |  | [optional] 
**Id** | **long** | Unique identifier for the statement.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt; | [optional] [readonly] 
**NewCharges** | [**Money**](Money.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

