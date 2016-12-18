using InternetOfJoran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace InternetOfJoran.API
{
    public class RiotGamesController : ApiController
    {
        // GET: api/RiotGames
        public SummonerDto Get()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://euw.api.pvp.net/api/lol/euw/v1.4/summoner/by-name/xFlawZy?api_key=RGAPI-fcc50458-8344-4759-9ebd-30716cb922e9");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync("").Result;
            var summoner = new SummonerDto();

            if (response.IsSuccessStatusCode)
            {
                summoner = response.Content.ReadAsAsync<SummonerDto>().Result;
            }

            return summoner;
        }

        // GET: api/RiotGames/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RiotGames
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RiotGames/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RiotGames/5
        public void Delete(int id)
        {
        }
    }
}
