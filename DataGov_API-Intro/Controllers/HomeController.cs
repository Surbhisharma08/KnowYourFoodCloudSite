using DataGov_API_Intro.DataAccess;
using DataGov_API_Intro.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DataGov_API_Intro.Controllers
{
    public class HomeController : Controller
    {
        HttpClient httpClient;

        //static string BASE_URL = "https://developer.nps.gov/api/v1";
        static string BASE_URL = "https://api.nal.usda.gov/fdc/v1";
        static string API_KEY = "yAdUGQQabSyuMX0CGur5SuEhS5Ud6xszLAWDMsr1"; //Add your API key here inside ""
        static string query = "banana";
        //static string BASE_URL = "https://data.cdc.gov/api/views/hk9y-quqm/rows.json";
        // Obtaining the API key is easy. The same key should be usable across the entire
        // data.gov developer network, i.e. all data sources on data.gov.
        // https://www.nps.gov/subjects/developer/get-started.htm

        public ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Add("query", query);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            // accept data-type in json format

            //string NATIONAL_PARK_API_PATH = BASE_URL + "/parks?limit=20";
            string NATIONAL_FOOD_API_PATH = BASE_URL + "/foods/search?limit=20";
            string foodsData = "";

            Rootobject foods = null;

            httpClient.BaseAddress = new Uri(NATIONAL_FOOD_API_PATH);
            //httpClient.BaseAddress = new Uri(BASE_URL);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_FOOD_API_PATH)
                                                        .GetAwaiter().GetResult();
                //HttpResponseMessage response = httpClient.GetAsync(BASE_URL)
                //                                        .GetAwaiter().GetResult();



                if (response.IsSuccessStatusCode)
                {
                    foodsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!foodsData.Equals(""))
                {
                    //JsonConvert is part of the NewtonSoft.Json Nuget package
                    foods = JsonConvert.DeserializeObject<Rootobject>(foodsData);
                }

                //dbContext.Parks.Add(parks);
                //await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(foods);
        }
        public ActionResult food()
        {
            
            return View();
        }
        public ActionResult Recipie()
        {

            return View();
        }
        public ActionResult AboutUs()
        {

            return View();
        }
        public ActionResult Component()
        {

            return View();
        }
    }
}





