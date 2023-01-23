﻿using Aldente.Data;
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
    public class RestaurantesController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public RestaurantesController(ApplicationDbContext dbContext, IMapper mapper)
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
        public async Task<IActionResult> CreateAsync(RestauranteDTO restaurnateDTO) {
            if (User.Identity.IsAuthenticated)
            {
                var restaurante = mapper.Map<Restaurante>(restaurnateDTO);
                using (var ms = new MemoryStream())
                {
                    restaurnateDTO.Imagen.CopyTo(ms);
                    restaurante.Logo = ms.ToArray();
                }
                dbContext.Add(restaurante);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                 return Unauthorized();   
            }
        }
    }
}
