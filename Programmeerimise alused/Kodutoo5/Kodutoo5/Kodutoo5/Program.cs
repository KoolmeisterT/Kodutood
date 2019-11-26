using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Kodutoo5
{
    class Program
    {
        static void Main()
        {
            WebClient wc = new WebClient();
            Console.WriteLine("Enter one Star Wars Character:");
            string character = Console.ReadLine();
            string url =
                $"https://swapi.co/api/people/?search" +
                $"={character}";
            string json = wc.DownloadString(url);
            SWApi apiResponse =
            JsonConvert.DeserializeObject<SWApi>(json);

            foreach (Character result in apiResponse.Results)
            {
                Console.WriteLine(result.Name + " Has appeared in " + result.Films.Length + " films");
            }
            Console.ReadKey();
        }

        public class SWApi
        {
            public Character[] Results { get; set; }
        }

        public class Character
        {
            public string Name { get; set; }
            public string[] Films { get; set; }
        }
    }
}
