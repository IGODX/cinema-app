using System.Diagnostics;
using System.Text.Json;
using CinemaApp.Data;
using CinemaApp.Models;
using CinemaApp.Models.ViewModel;
using CinemaApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CinemaApp.Controllers
{
    public class HomeController : Controller
    {
        const string APIURL = @"https://api.themoviedb.org/3/movie/popular?api_key=42e67cea25d38af9ed69a9e36de60346&language=en-US&page=";
        const string APIKEY = @"42e67cea25d38af9ed69a9e36de60346";
        private readonly ILogger<HomeController> _logger;
        private readonly IJsonParser _parser;


        public HomeController(ILogger<HomeController> logger, IJsonParser parser)
        {
            _parser = parser;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string? search, int page = 1)
        {
            if(page == 0)
                return RedirectToAction("Index", "Home");
            Popular deserializedPopular = null!;
            if (search != null)
            {
                string searchURL = @$"https://api.themoviedb.org/3/search/movie?api_key={APIKEY}&language=en-US&query={search}&page={page}&include_adult=false";
                deserializedPopular = await _parser.GetDeserializedObject<Popular>(searchURL, _logger);
            }
            else
                deserializedPopular = await _parser.GetDeserializedObject<Popular>(APIURL + page, _logger);
            if(deserializedPopular == null)
            {
                return Content("Error!");
            }
            IndexViewModel vM = new IndexViewModel
            {
                Popular = deserializedPopular,
                Search = search
            };
            return View(vM);
        }
        public async Task<IActionResult> Details(int? id)
        {
            string filmURL = $"https://api.themoviedb.org/3/movie/{id}?api_key={APIKEY}&language=en-US";
            string creditsURL = $"https://api.themoviedb.org/3/movie/{id}/credits?api_key={APIKEY}&language=en-US";
            Details details = await _parser.GetDeserializedObject<Details>(filmURL, _logger);
            Credits credits = await _parser.GetDeserializedObject<Credits>(creditsURL, _logger);
            if (details == null || credits == null)
                return Content("Error!");
            DetailsViewModel vM = new DetailsViewModel
            {
              Details = details,
              Credits = credits
               
            };
            return View(vM);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}