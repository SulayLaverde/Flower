using FlowersAndBushes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowersAndBushes.Controllers
{
    public class ProductosController : Controller
    {
        public static List<Producto> productos = new List<Producto>();
        //
        // GET: /Productos/
        public ActionResult Index()
        {
            return View(productos);
        }


        //
        // GET: /Productos/Crear
        public ActionResult Crear()
        {
             Producto producto = new Producto();
            var tipoHoja = new List<TipoHoja>();
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 1, Nombre = "Acicular" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 2, Nombre= "Lanceolada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 3, Nombre = "Orbicular" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 4, Nombre= "Romboide"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 5, Nombre = "Orbicular" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 6, Nombre= "Acumitada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 7, Nombre = "Flabelada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 8, Nombre= "Ovada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 9, Nombre = "En roseta" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 10, Nombre= "Alternas"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 11, Nombre = "Hastada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 12, Nombre= "Palmeada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 13, Nombre = "Espatulada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 14, Nombre= "Aristada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 15, Nombre = "Palma simple" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 16, Nombre= "Sagitada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 17, Nombre = "Bipinnada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 18, Nombre= "Lineal"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 19, Nombre = "Peltada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 20, Nombre= "Subulada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 21, Nombre = "Cordada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 22, Nombre= "Lobulada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 23, Nombre = "Amplexicaule" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 24, Nombre= "Trifoliada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 25, Nombre = "Cuneada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 26, Nombre= "Imparipinnada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 27, Nombre = "Tripinnada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 28, Nombre= "Triangular"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 29, Nombre = "Obovada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 30, Nombre= "Paripinnada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 31, Nombre = "Truncada" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 32, Nombre= "Digitada"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 33, Nombre = "Obtusa" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 34, Nombre= "Pinnatisecta"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 35, Nombre = "Eliípitica" });
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 36, Nombre= "Opuestas"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 37, Nombre= "Reniforme"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 38, Nombre= "Verticilados"});
            tipoHoja.Add(new TipoHoja() {IdTipoHoja = 39, Nombre= "Entera"});

            ViewBag.TipoHoja =
                    tipoHoja.Select(x => new SelectListItem
                    {
                        Text = x.Nombre,
                        Value = x.IdTipoHoja.ToString()
                    });
            return View(producto);
        }

        //
        // GET: /Productos/Crear
        public ActionResult Create()
        {
           
            return View();
        }

        //
        // POST: /Productos/Crear
        [HttpPost]
        public JsonResult Crear(Producto producto)
        {
            try
            {
                productos.Add(producto);
                var json = Json(new { mensaje = "" });
                return json;
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message });
                            
            }
        }

        //
        // GET: /Productos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Productos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Productos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Productos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
