using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
