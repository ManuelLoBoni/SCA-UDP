using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaWeb_Laboratorios.Models;
using SistemaWeb_Laboratorios.Models.ViewModels;

namespace SistemaWeb_Laboratorios.Controllers
{
    public class ControlAccesosController : Controller
    {
        // GET: ControlAccesos
        public ActionResult Index()
        {
            using (UDP_CONTROLEntities context = new UDP_CONTROLEntities())
            {
                // Realizar una operación de unión entre ControlUsuario y Usuario
                var controlUsuarios = from controlUsuario in context.ControlUsuario
                                      join usuario in context.usuario on controlUsuario.IdUsuario equals usuario.IdUsuario
                                      orderby controlUsuario.IdRegistro descending
                                      select new VistaControlUsuario // ViewModel es una clase personalizada para almacenar los datos que quieres mostrar en la vista
                                      {
                                          IdRegistro = controlUsuario.IdRegistro,
                                          fecha = controlUsuario.fecha,
                                          IdUsuario = usuario.Nombre + " " + usuario.Apellidos,
                                          HoraEntrada = controlUsuario.HoraEntrada,
                                          HoraSalida = controlUsuario.HoraSalida,
                                          TipoActividad = controlUsuario.TipoActividad,
                                          CantidadAlumnos = controlUsuario.CantidadAlumnos,
                                          Semestre = controlUsuario.Semestre,
                                          IdCarrera = controlUsuario.IdCarrera,
                                          Area = controlUsuario.Area
                                      };

                return View(controlUsuarios.ToList());
            }

            //using (UDP_CONTROLEntities context = new UDP_CONTROLEntities())
            //{
            //    return View(context.ControlUsuario.ToList());
            //}
        }

        // GET: ControlAccesos/Details/5
        public ActionResult Details(int id)
        {
            using (UDP_CONTROLEntities context = new UDP_CONTROLEntities())
            {
                return View(context.ControlUsuario.Where(x => x.IdRegistro == id).FirstOrDefault());
            }
        }

        // GET: ControlAccesos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ControlAccesos/Create
        [HttpPost]
        public ActionResult Create(ControlUsuario Registro)
        {
            try
            {
                using (UDP_CONTROLEntities context = new UDP_CONTROLEntities())
                {
                    context.ControlUsuario.Add(Registro);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ControlAccesos/Edit/5
        public ActionResult Edit(int id)
        {
            using (UDP_CONTROLEntities context = new UDP_CONTROLEntities())
            {
                return View(context.ControlUsuario.Where(x => x.IdRegistro == id).FirstOrDefault());
            }
        }

        // POST: ControlAccesos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ControlUsuario Registro)
        {
            try
            {
                using (UDP_CONTROLEntities context = new UDP_CONTROLEntities())
                {
                    context.Entry(Registro).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ControlAccesos/Delete/5
        public ActionResult Delete(int id)
        {
            using (UDP_CONTROLEntities context = new UDP_CONTROLEntities())
            {
                return View(context.ControlUsuario.Where(x => x.IdRegistro == id).FirstOrDefault());
            }
        }

        // POST: ControlAccesos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (UDP_CONTROLEntities context = new UDP_CONTROLEntities())
                {
                    ControlUsuario Registro = context.ControlUsuario.Where(x => x.IdRegistro == id).FirstOrDefault();
                    context.ControlUsuario.Remove(Registro);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
