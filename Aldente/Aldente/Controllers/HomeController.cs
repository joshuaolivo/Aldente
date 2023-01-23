using Aldente.Data;
using Aldente.DTOs;
using Aldente.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext, IMapper mapper)
        {
            _logger = logger;
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var rest = dbContext.Restaurantes.ToList();
            List<PlatillaRestauranteDTO> restaurantes = new List<PlatillaRestauranteDTO>();
            foreach (var restaurante in rest)
            {
                //NECESITAMOs VER COMO MANDAMOS LOS BYTES AL UI 
                var restarant = mapper.Map<PlatillaRestauranteDTO>(restaurante);
                restaurantes.Add(restarant);
            }
            return View(restaurantes);   
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
