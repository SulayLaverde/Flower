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
        // GET: /Productos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Productos/Create
        public ActionResult Crear()
        {
            return View();
        }

        //
        // POST: /Productos/Create
        [HttpPost]
        public JsonResult Crear(Producto producto)
        {
            try
            {
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
