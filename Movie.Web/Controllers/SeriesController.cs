using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Contract.Services;

namespace Movie.Web.Controllers
{
    public class SeriesController : Controller
    {
        private readonly ISeriesService _seriesService;
        public SeriesController(ISeriesService seriesService)
        {
            _seriesService = seriesService;
        }
        public IActionResult Series()
        {
            var series = _seriesService.GetSeries();

            return View();
        }
    }
}