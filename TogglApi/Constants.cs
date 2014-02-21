using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi
{
    public class Constants
    {
        public class Urls
        {
            public const string API_URL = "https://www.toggl.com/api/v8";
            public const string TIMEENTRIES_URL = API_URL + "/time_entries?";
            public const string ME = API_URL + "/me";
            public const string ME_DETAILED = ME + "?with_related_data=true";
            public const string ME_CLIENTS = API_URL + "/clients";
        }


        public class Request
        {
            public class Properties
            {
                public const string API_TOKEN = "api_token";
                public const string CONTENT_TYPE = "Content-Type";
            }

            public class Values
            {
                public const string CONTENT_TYPE = "application/json";
            }
        }
    }
}
