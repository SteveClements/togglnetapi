using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogglApi.Models;

namespace TogglApi
{
    public static class TogglExtensions
    {
        public static void AddTogglAuth(this IRestRequest req, TogglAuthRequest auth)
        {
            string encodedAuthString = String.IsNullOrWhiteSpace(auth.ApiToken) ?
                Convert.ToBase64String(Encoding.UTF8.GetBytes(auth.UserName + ":" + auth.Password)) :
                Convert.ToBase64String(Encoding.UTF8.GetBytes(auth.ApiToken + ":api_token"));

            req.AddHeader("Authorization", "Basic " + encodedAuthString);
        }

        public static bool IsValid(this TogglAuthRequest togglAuth)
        {
            if ((String.IsNullOrWhiteSpace(togglAuth.ApiToken) &&
                (String.IsNullOrWhiteSpace(togglAuth.UserName) || String.IsNullOrWhiteSpace(togglAuth.Password))))
                return false;
            return true;
        }
    }
}
