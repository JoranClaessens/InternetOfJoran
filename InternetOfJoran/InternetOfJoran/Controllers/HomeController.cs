using InternetOfJoran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace InternetOfJoran.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async new Task<ActionResult> Profile()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60030/api/RiotGames");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("");
            var summoner = new SummonerDto();

            if (response.IsSuccessStatusCode)
            {
                summoner = await response.Content.ReadAsAsync<SummonerDto>();
            }

            return View(summoner);
        }
    }
}