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
                ViewBag.Categorias = dbContext.Categorias.ToList();
                ViewBag.SubCategorias = dbContext.subCategoias.ToList();
                return View();
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create(PlatilloDTO platilloDTO)
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
            var platos = (from p in dbContext.Platillos
                          join r in dbContext.Restaurantes
                          on p.Restaurante equals r
                          //where r.user == 
                          select new Platillo { Nombre = p.Nombre, Id = p.Id, Categoria = new Categoria { Id = p.Categoria.Id, Nombre = p.Categoria.Nombre }, Descripcion = p.Descripcion, Imagen = p.Imagen, Precio = p.Precio, Restaurante = new Restaurante { Id = p.Restaurante.Id }, SubCategoia = new SubCategoia { Id = p.SubCategoia.Id } }).ToList();
            return View(platos);
        }

    }
}
