using Aldente.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.Controllers
{
    public class RestaurantesController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public RestaurantesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Create() => View(); 
    }
}
