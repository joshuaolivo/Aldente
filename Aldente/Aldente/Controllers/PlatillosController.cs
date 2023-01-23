using Aldente.Data;
using Aldente.Data.Entities;
using Aldente.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.Controllers
{
    public class PlatillosController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public PlatillosController(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(PlatilloDTO platilloDTO)
        {
            if (User.Identity.IsAuthenticated)
            {
                var platillo = mapper.Map<Platillo>(platilloDTO);
                using (var ms = new MemoryStream())
                {
                    platilloDTO.Img.CopyTo(ms);
                    platillo.Imagen = ms.ToArray();
                }
                dbContext.Add(platillo);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return Unauthorized();
            }
        }
        public IActionResult Show()
        {
            return View(dbContext.Platillos.ToList());
        }

    }
}
