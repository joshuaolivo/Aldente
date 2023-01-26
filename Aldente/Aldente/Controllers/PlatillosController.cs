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
                platillo.Categoria = dbContext.Categorias.Where(e => e.Id == platilloDTO.CategoriaInt).First();
                platillo.SubCategoia = dbContext.subCategoias.Where(e => e.Id == platilloDTO.SubCategoiaInt).First();
                platillo.Restaurante = dbContext.Restaurantes.Where(e => e.user == User.Claims.Where(x => x.Type.Equals("TenantId")).Select(x => x.Value).FirstOrDefault()).First();
                dbContext.Add(platillo);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Show", "Platillos");
            }
            else
            {
                return Unauthorized();
            }
        }
        public IActionResult Show()
        {
            try
            {
                var idUser = User.Claims.Where(x => x.Type.Equals("TenantId")).Select(x => x.Value).FirstOrDefault();
                var restaurante = dbContext.Restaurantes.Where(e => e.user == idUser).First();
                ViewBag.RestauranteNombre = restaurante.Nombre;
                ViewBag.RestauranteLogo = restaurante.Logo;
                ViewBag.Categorias = dbContext.Categorias.ToList();
                ViewBag.SubCategorias = dbContext.subCategoias.ToList();

                var platos = (from p in dbContext.Platillos
                              join r in dbContext.Restaurantes
                              on p.Restaurante equals r
                              where r.user == idUser
                              select new Platillo { Nombre = p.Nombre, Id = p.Id, Categoria = new Categoria { Id = p.Categoria.Id, Nombre = p.Categoria.Nombre }, Descripcion = p.Descripcion, Imagen = p.Imagen, Precio = p.Precio, Restaurante = new Restaurante { Id = p.Restaurante.Id }, SubCategoia = new SubCategoia { Id = p.SubCategoia.Id, Nombre = p.SubCategoia.Nombre }, Proporcion = p.Proporcion, Tamanio = p.Tamanio, Unidad = p.Unidad }).ToList();

                return View(platos);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Create", "Restaurantes");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var platillo = dbContext.Platillos.Where(p => p.Id == id).First();
            dbContext.Remove(platillo);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Show");
        }

        public IActionResult Actualizar(int id)
        {
            var platillo = dbContext.Platillos.Where(x => x.Id == id).FirstOrDefault();
            return View(platillo);
        }
        [HttpPost]
        public IActionResult Actualizar(Platillo platillo)
        {
            dbContext.Entry(platillo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction("Show");
        }
    }
}
