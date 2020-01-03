using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediares.Models;
using Mediares.Models.ViewModels;
using Mediares.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mediares.Controllers
{
    public class TurmasController : Controller
    {
        private readonly TurmaService _turmaService;
        private readonly DisciplinaService _disciplinaService;

        public TurmasController(TurmaService turmaService, DisciplinaService disciplinaService)
        {
            _turmaService = turmaService;
            _disciplinaService = disciplinaService;
        }

        public IActionResult Index()
        {
            var list = _turmaService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var disciplinas = _disciplinaService.FindAll();
            var viewModel = new TurmaFormularioDeCadastro { Disciplinas = disciplinas };
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create (Turma turma)
        {
            _turmaService.Insert(turma);
            return RedirectToAction("Index");
        }
    }
}