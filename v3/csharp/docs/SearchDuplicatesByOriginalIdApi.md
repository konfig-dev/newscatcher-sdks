# Newscatcherapi.Net.Api.SearchDuplicatesByOriginalIdApi

All URIs are relative to *https://v3-api.newscatcherapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get**](SearchDuplicatesByOriginalIdApi.md#get) | **GET** /api/search_duplicates_by_original_id | [Get] Search Duplicate Articles For Articles Request |
| [**Post**](SearchDuplicatesByOriginalIdApi.md#post) | **POST** /api/search_duplicates_by_original_id | [Post] Search Duplicate Articles For Articles Request |


# **Get**



This endpoint allows you to search for duplicate articles by original article id.

### Example
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            NewscatcherClient client = new NewscatcherClient();
            // Configure API key authorization: apiKey
            client.SetApiKey("YOUR_API_KEY");

            var originalArticleId = "originalArticleId_example";
            var page = 1;
            var pageSize = 100;
            
            try
            {
                // [Get] Search Duplicate Articles For Articles Request
                SearchduplicatesbyoriginalidGetResponse result = client.SearchDuplicatesByOriginalId.Get(originalArticleId, page, pageSize);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SearchDuplicatesByOriginalIdApi.Get: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [Get] Search Duplicate Articles For Articles Request
    ApiResponse<SearchduplicatesbyoriginalidGetResponse> response = apiInstance.GetWithHttpInfo(originalArticleId, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchDuplicatesByOriginalIdApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **originalArticleId** | **string** |  |  |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 100] |

### Return type

[**SearchduplicatesbyoriginalidGetResponse**](SearchduplicatesbyoriginalidGetResponse.md)


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# **Post**



This endpoint allows you to search for duplicate articles by original article id.

### Example
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Model;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            NewscatcherClient client = new NewscatcherClient();
            // Configure API key authorization: apiKey
            client.SetApiKey("YOUR_API_KEY");

            var originalArticleId = "originalArticleId_example";
            var page = 1;
            var pageSize = 100;
            
            var duplicatesByOriginalIdRequest = new DuplicatesByOriginalIdRequest(
                originalArticleId,
                page,
                pageSize
            );
            
            try
            {
                // [Post] Search Duplicate Articles For Articles Request
                SearchduplicatesbyoriginalidPostResponse result = client.SearchDuplicatesByOriginalId.Post(duplicatesByOriginalIdRequest);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SearchDuplicatesByOriginalIdApi.Post: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
```

#### Using the PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [Post] Search Duplicate Articles For Articles Request
    ApiResponse<SearchduplicatesbyoriginalidPostResponse> response = apiInstance.PostWithHttpInfo(duplicatesByOriginalIdRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchDuplicatesByOriginalIdApi.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **duplicatesByOriginalIdRequest** | [**DuplicatesByOriginalIdRequest**](DuplicatesByOriginalIdRequest.md) |  |  |

### Return type

[**SearchduplicatesbyoriginalidPostResponse**](SearchduplicatesbyoriginalidPostResponse.md)


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

