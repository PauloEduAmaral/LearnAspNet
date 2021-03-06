﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CadeMeuMedico.Models;

namespace CadeMeuMedico.Controllers
{
    public class EspecialidadesController : Controller
    {
        private CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities();

        // GET: Especialidades
        public ActionResult Index()
        {
            var especialidades = db.Especialidades.ToList();
            return View(especialidades);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Especialidades especialidade)
        {
            if (ModelState.IsValid)
            {
                db.Especialidades.Add(especialidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(especialidade);
        }

        public ActionResult Editar(long id)
        {
            Especialidades especialidade = db.Especialidades.Find(id);
            return View(especialidade);
        }

        [HttpPost]
        public ActionResult Editar(Especialidades especialidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(especialidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(especialidade);
        }

        public string Excluir(long id)
        {
            try
            {
                Especialidades especialidade = db.Especialidades.Find(id);
                db.Especialidades.Remove(especialidade);
                db.SaveChanges();
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
        }
    }
}
