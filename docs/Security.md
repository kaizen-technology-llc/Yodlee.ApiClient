# Yodlee.ApiClient.Model.Security

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StockExchangeDetails** | [**List&lt;StockExchangeDetail&gt;**](StockExchangeDetail.md) | Securities exchange provide the securities information at the corresponding exchanges. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**IssueTypeMultiplier** | **double** | Price units corresponding to the security style. This is used to derive actual price of the security from market value.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**StateTaxable** | **bool** | The state in which the security is taxed.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**CallDate** | **string** | Next call date of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**CdscFundFlag** | **bool** | cdsc fund flag of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**Cusip** | **string** | A CUSIP is a nine-character alphanumeric code that identifies a North American financial security for the purposes of facilitating clearing and settlement of trades.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**FederalTaxable** | **bool** | Flag indicating federal taxable.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**SAndPRating** | **string** | Unique identifier for S&amp;P rating on Envestnet platform.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**ShareClass** | **string** | Share class of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**IsEnvestnetDummySecurity** | **bool** | Flag indicating a dummy security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**Description** | **string** | The description (name) of the security. For example, Cisco Systems.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**MinimumPurchase** | **int** | Minimum purchase of security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**Type** | **string** | Indicates the type of security like stocks, mutual fund, etc. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**FirstCouponDate** | **string** | First coupon date of security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**Frequency** | **int** | Coupon Frequency.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**AccrualMethod** | **string** | The method in which interest is accrued or earned.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**IncomeCurrency** | **string** | ISO 4217 currency code indicating income currency of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**MaturityDate** | **string** | Maturity date of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**CallPrice** | **double** | Next call price of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**Id** | **long** | The unique identifier of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**IssueDate** | **string** | Issue date of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**Sector** | **string** | Identifier of the sector to which the security belongs to.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**AgencyFactor** | **double** | Agency factor of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**InterestRate** | **double** | The rate of interest paid annually, expressed as a percentage of the bond&#39;s par or face value.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**LastModifiedDate** | **string** | The last updated date of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**GicsSector** | **string** | GICS Sector is a categorization the S&amp;P assigns to all publically traded companies. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**ClosedFlag** | **bool** | &lt;b&gt;true&lt;/b&gt;:Closed for all investors , &lt;b&gt;false&lt;/b&gt;: Open to all investors.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**Sedol** | **string** | The Stock Exchange Daily Official List (SEDOL) is a set of security identifiers used in the United Kingdom and Ireland for clearing purposes.&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;: The SEDOL field is only applicable to the trade related transactions.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**SubSector** | **string** | GICS sector ID to which the security belongs to.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**LastCouponDate** | **string** | Last coupon date of security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**IsSyntheticSecurity** | **bool** | Indicates whether the security is a simulated security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**TradeCurrencyCode** | **string** | ISO 4217 currency code indicating trading currency of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**IsDummySecurity** | **bool** | Indicates whether the security is a dummy security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**MoodyRating** | **string** | Unique identifier for Moody rating on Envestnet platform.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**Style** | **string** | Classification of the style for the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**FirmEligible** | **string** | &lt;b&gt;1&lt;/b&gt;- indicates Eligible,&lt;b&gt;0&lt;/b&gt;- indicates firm is not eligible.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**FundFamily** | **string** | Mutual Fund Family Name.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 
**Isin** | **string** | The International Securities Identification Number (ISIN) is used worldwide to identify specific securities. It is equivalent to CUSIP for international markets.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt; | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

