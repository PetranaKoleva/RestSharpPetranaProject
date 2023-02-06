using RestSharp;
using System.Text.Json;

namespace RestSharpPetranaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://api.github.com");
            RestRequest request = new RestRequest("/repos/PetranaKoleva/postman/issues/1", Method.Get);

            var response = client.Execute(request);
            Console.WriteLine("STATUS CODE; " + response.StatusCode);
            var issue = JsonSerializer.Deserialize<Issue>(response.Content);

            Console.WriteLine("Issue name: " + issue.title);
            Console.WriteLine("Issue number: " + issue.number);

           // Console.WriteLine("Response: " + response.Content);
        }
    }
}