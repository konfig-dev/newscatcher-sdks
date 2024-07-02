/*
 * NewsCatcher-V3 Production API
 *
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: 3.2.16
 * Contact: maksym@newscatcherapi.com
 * Generated by: https://konfigthis.com
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Api;
using Newscatcherapi.Net.Model;

namespace Newscatcherapi.Net.Test.Api
{
    /// <summary>
    ///  Class for testing SearchLinkApi
    /// </summary>
    public class SearchLinkApiTests : IDisposable
    {
        private NewscatcherClient client;

        public SearchLinkApiTests()
        {
            client = new NewscatcherClient();
            client.SetBasePath("http://127.0.0.1:4010");
            // Configure API key authorization: apiKey
            client.SetApiKey("YOUR_API_KEY");

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Fact]
        public void GetTest()
        {
            var ids = new Object(
            );
            var links = new Object(
            );
            var from = new From1(DateTime.Now);
            var to = new To1(DateTime.Now);
            var page = 1;
            var pageSize = 100;
            
            try
            {
                // [Get] Search For Articles By Id Or Link
                DtoResponsesSearchResponseSearchResponse result = client.SearchLink.Get(ids, links, from, to, page, pageSize);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SearchLinkApi.Get: " + e.Message);
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

        /// <summary>
        /// Test Post
        /// </summary>
        [Fact]
        public void PostTest()
        {
            var ids = "ids_example";
            var links = "links_example";
            var from = new From1(DateTime.Now);
            var to = new To1(DateTime.Now);
            var page = 1;
            var pageSize = 100;
            
            var searchURLRequest = new SearchURLRequest(
                ids,
                links,
                from,
                to,
                page,
                pageSize
            );
            
            try
            {
                // [Post] Search For Articles Request
                DtoResponsesSearchResponseSearchResponse result = client.SearchLink.Post(searchURLRequest);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SearchLinkApi.Post: " + e.Message);
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
