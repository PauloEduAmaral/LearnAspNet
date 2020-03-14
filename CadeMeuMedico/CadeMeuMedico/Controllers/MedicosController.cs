﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CadeMeuMedico.Models;

namespace CadeMeuMedico.Controllers
{
    public class MedicosController : Controller
    {
        private CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities();

        // GET: Medicos
        public ActionResult Index()
        {
            var medicos = db.Medicos.Include(m => m.Cidades).Include(m => m.Especialidades).ToList();
            return View(medicos);
        }

        public ActionResult Adicionar()
        {
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome");
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Nome");
            return View();
        }
    }
}