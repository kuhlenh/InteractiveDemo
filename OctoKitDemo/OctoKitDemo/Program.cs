using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoKitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            OctokitExampleAsync().Wait();
        }

        private static async Task OctokitExampleAsync()
        {
            var github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
            var user = await github.User.Get("half-ogre");
            Console.WriteLine(user.Followers + " folks love the half ogre!");
        }
    }
}
