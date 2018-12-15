using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Meetup.Model
{
    public class MeetManager
    {
        private static string authorizationkey = "4434407c561c2b1e356a26785960f42";
        private static int MaxResults = 5;
        

        public static string AddApiKey(string url)
        {
            return string.Format(url + "?key={0}&page={1}", authorizationkey, MaxResults);
        }

        public static async Task<List<Location>> GetLocations()
        {
            HttpClient client = new HttpClient();
            string url = "https://api.meetup.com/find/locations";
            client.DefaultRequestHeaders.Add("Accept", "Application/json");
            //Debug.WriteLine(await client.GetStreamAsync(AddApiKey(url)));
            string result = await client.GetStringAsync(AddApiKey(url));

            if (result != null)
            {
                List<Location> locations = JsonConvert.DeserializeObject<List<Location>>(result);
                return locations;
            }
            else
            {
                return null;
            }
        }
    }
}
