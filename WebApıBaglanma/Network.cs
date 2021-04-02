using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using System.Collections.Specialized;
using System.IO;
using static WebApıBaglanma.Form1;

namespace WebApıBaglanma
{
    class Network
    {
        public string Fetch()
        {
             using (WebClient client = new WebClient())
            {
                return client.DownloadString("https://jsonplaceholder.typicode.com/posts");
            };
           
        }
       
        public string FetchRestSharp()
        {
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/");
            RestRequest request = new RestRequest("photos", Method.GET);
            string queryResult = client.Execute<string>(request).Data;
            return queryResult;
        }
        public string FetchRestEase()
        {
            IGitHubApi api = RestEase.RestClient.For<IGitHubApi>("https://jsonplaceholder.typicode.com/");
            List<Item> user = api.GetPhotosAsync("photos").Result;
            string u;
            u = user.ToString();
            return u;
           
           
        }
      
    }
}
