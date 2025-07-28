# IPGeolocation.Model.ASNResponseAsn

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsNumber** | **string** |  | [optional] 
**Organization** | **string** |  | [optional] 
**Country** | **string** |  | [optional] 
**AsnName** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**Domain** | **string** |  | [optional] 
**DateAllocated** | **DateTimeOffset** |  | [optional] 
**AllocationStatus** | **string** |  | [optional] 
**NumOfIpv4Routes** | **int** |  | [optional] 
**NumOfIpv6Routes** | **int** |  | [optional] 
**Rir** | **string** |  | [optional] 
**Routes** | **List&lt;string&gt;** | It will only be included in the response, if you set include&#x3D;routes in the request | [optional] 
**Upstreams** | [**List&lt;ASNConnection&gt;**](ASNConnection.md) | It will only be included in the response, if you set include&#x3D;upstreams in the request | [optional] 
**Downstreams** | [**List&lt;ASNConnection&gt;**](ASNConnection.md) | It will only be included in the response, if you set include&#x3D;downstreams in the request | [optional] 
**Peers** | [**List&lt;ASNConnection&gt;**](ASNConnection.md) | It will only be included in the response, if you set include&#x3D;peers in the request | [optional] 
**WhoisResponse** | **string** | It will only be included in the response, if you set include&#x3D;whois_response in the request | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

