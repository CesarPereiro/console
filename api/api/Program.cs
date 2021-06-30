using Newtonsoft.Json;
using RestSharp;
using System;


namespace api
{
    class Program
    {
        static void Main(string[] args)
        {
            getUser();
        }
        public static void getUser() {
            var client = new RestClient("https://dummyapi.io/data/api/");
            var request = new RestRequest("user");
            request.AddHeader("Authorization", "Basic Z3JvdXAxOlByb2otMzI1");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("app-id", "60dc16d63b525f3ffed0de31");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                dynamic resp = JsonConvert.DeserializeObject(response.Content);
                Console.Out.WriteLine(resp.data[0].id);
            }
        }
    }
}
