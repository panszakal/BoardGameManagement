using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace GameMngmt.Repository
{
    public class GameRepository
    {
        public HttpClient Client { get; set; }
        public GameRepository()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:57982/api/");
        }

        public HttpResponseMessage GetResponse(string url)
        {
            return Client.GetAsync(url).Result;
        }
        public HttpResponseMessage PutResponse(string url, object model)
        {
            return Client.PutAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage PostResponse(string url, object model)
        {
            return Client.PostAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage DeleteResponse(string url)
        {
            return Client.DeleteAsync(url).Result;
        }
    }
}

