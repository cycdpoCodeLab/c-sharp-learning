// Tutorial: https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/console-webapiclient

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace TutorialsConsoleWebApiClient
{
    class Program
    {
        private static readonly HttpClient Client = new HttpClient();

        static void Main(string[] args)
        {
            /*
            ProcessRepositories().Wait();
            */

            var repositories = ProcessRepositories().Result;
            foreach (var repository in repositories)
            {
                Console.WriteLine($"name:          {repository.Name}");
                Console.WriteLine($"Description:   {repository.Description}");
                Console.WriteLine($"GitHubHomeUrl: {repository.GitHubHomeUrl}");
                Console.WriteLine($"Homepage:      {repository.Homepage}");
                Console.WriteLine($"Watchers:      {repository.Watchers}");
                Console.WriteLine($"LastPush:      {repository.LastPush}");
                Console.WriteLine();
            }
        }

        private static async Task<List<Repository>> ProcessRepositories()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<Repository>));

            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            Client.DefaultRequestHeaders.Add("User-Agent", ".Net Foundation Repository Reporter");

            /*
            var stringTask = Client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            var msg = await stringTask;
            Console.Write(msg);
            */
            
            var streamTask = Client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = serializer.ReadObject(await streamTask) as List<Repository>;

            /*
            foreach (var repository in repositories)
            {
                Console.WriteLine(repository.Name);
            }
            */

            return repositories;
        }
    }
}