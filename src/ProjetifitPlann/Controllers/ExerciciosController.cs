using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ProjetoFit.Controllers
{
    public class ExerciciosController : Controller
    {
        private static List<string> historicoExercicios = new List<string>();

        public IActionResult Index()
        {
            ViewBag.GrupoMuscular = new List<SelectListItem>
            {
                new SelectListItem { Value = "peito", Text = "Peito" },
                new SelectListItem { Value = "braco", Text = "Braço" },
                new SelectListItem { Value = "pernas", Text = "Pernas" },
                new SelectListItem { Value = "costas", Text = "Costas" }
            };

            return View();
        }

        [HttpGet]
        public IActionResult Concluir(string exercicio)
        {
            if (!string.IsNullOrEmpty(exercicio))
            {
                historicoExercicios.Add(exercicio);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Historico()
        {
            ViewBag.HistoricoExercicios = historicoExercicios;
            return View();
        }
    }
}
