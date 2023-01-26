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
                if (!ModelState.IsValid)
                {
                    return View(platilloDTO);
                }
                var platillo = mapper.Map<Platillo>(platilloDTO);
                using (var ms = new MemoryStream())
                {
                    platilloDTO.Img.CopyTo(ms);
                    platillo.Imagen = ms.ToArray();
                }
                platillo.Categoria = dbContext.Categorias.Where(e => e.Id == platilloDTO.CategoriaInt).First();
                platillo.SubCategoia = dbContext.subCategoias.Where(e => e.Id == platilloDTO.SubCategoiaInt).First();
                var id = User.Claims.Where(x => x.Type.Equals("TenantId")).Select(x => x.Value).FirstOrDefault();
                platillo.Restaurante = dbContext.Restaurantes.Where(e => e.user == id).FirstOrDefault();
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
            if (User.Identity.IsAuthenticated)
            {
                var idUser = User.Claims.Where(x => x.Type.Equals("TenantId")).Select(x => x.Value).FirstOrDefault();
                if (dbContext.Restaurantes.Any(e => e.user == idUser))
                {
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
                else
                {
                    return RedirectToAction("Create", "Restaurantes");
                }
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
               
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var platillo = dbContext.Platillos.Where(p => p.Id == id).First();
                dbContext.Remove(platillo);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Show");
            }
            else
            {
                return Unauthorized();
            }
            
        }

        public IActionResult Actualizar(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.Categorias = dbContext.Categorias.ToList();
                ViewBag.SubCategorias = dbContext.subCategoias.ToList();
                ViewBag.platillo = (from p in dbContext.Platillos
                                    join r in dbContext.Restaurantes
                                    on p.Restaurante equals r
                                    where p.Id == id
                                    select new Platillo { Nombre = p.Nombre, Id = p.Id, Categoria = new Categoria { Id = p.Categoria.Id, Nombre = p.Categoria.Nombre }, Descripcion = p.Descripcion, Imagen = p.Imagen, Precio = p.Precio, Restaurante = new Restaurante { Id = p.Restaurante.Id }, SubCategoia = new SubCategoia { Id = p.SubCategoia.Id, Nombre = p.SubCategoia.Nombre }, Proporcion = p.Proporcion, Tamanio = p.Tamanio, Unidad = p.Unidad }).FirstOrDefault();
                return View();
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
            
        }
        [HttpPost]
        public IActionResult Actualizar(PlatilloDTO platilloDTO)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!ModelState.IsValid)
                {
                    return View(platilloDTO);
                }
                var platillo = mapper.Map<Platillo>(platilloDTO);
                if (platilloDTO.Img != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        platilloDTO.Img.CopyTo(ms);
                        platillo.Imagen = ms.ToArray();
                    }
                }
                platillo.Categoria = dbContext.Categorias.Where(e => e.Id == platilloDTO.CategoriaInt).First();
                platillo.SubCategoia = dbContext.subCategoias.Where(e => e.Id == platilloDTO.SubCategoiaInt).First();
                var id = User.Claims.Where(x => x.Type.Equals("TenantId")).Select(x => x.Value).FirstOrDefault();
                platillo.Restaurante = dbContext.Restaurantes.Where(e => e.user == id).FirstOrDefault();
                dbContext.Entry(platillo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                if (platilloDTO.Img == null) dbContext.Entry(platillo).Property(x => x.Imagen).IsModified = false;
                dbContext.SaveChanges();
                return RedirectToAction("Show");
            }
            else
            {
                return Unauthorized();
            }
            
        }
    }
}
