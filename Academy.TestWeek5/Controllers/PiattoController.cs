using Academy.TestWeek5.Core;
using Academy.TestWeek5.Core.Interfaces;
using Academy.TestWeek5.Core.Models;
using Academy.TestWeek5.Models;
using Academy.TestWeek5.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academy.TestWeek5.MVC.Controllers
{
    [Authorize]
    public class PiattoController : Controller
    {
        private readonly IBusinessLayer bl;

        public PiattoController(IBusinessLayer businessLayer)
        {
            this.bl = businessLayer;
        }

        [Route("Piat/Index", Order = 1)]
        [Route("Piatto/Index", Order = 2)]
       
        public IActionResult Index()
        {
            var model = bl.FetchPiatti();
            return View(model);
        }

        //GET Piatto/Details/{id}
        [HttpGet("emp/details/{id}")]
        public IActionResult Details(int id)
        {
            //Validazione dell'input
            if (id <= 0)
            {
                return View("Error", new ErrorViewModel());
            }

            //Recupero impiegato da visualizzare
            var emp = bl.GetPiattoById(id);

            //Restituzione della vista (check del modello)
            if (emp == null)
            {
                return View("NotFound", new NotFoundViewModel()
                {
                    EntityId = id,
                    Message = "Something wrong"
                });
            }
            return View(emp);
        }

        [Authorize(Policy = "AccountRistoratore")]
        //GET
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "AccountRistoratore")]
        [HttpPost]
        public IActionResult Create(PiattoViewModel data)
        {
            //validazione
            if (data == null)
            {
                return View("Error", new ErrorViewModel());
            }
            if (ModelState.IsValid)
            {
                //chiamata al business layer
                PiattoResult result = bl.AddNewPiatto(new Piatto
                {
                    Nome = data.Nome,
                    Descrizione = data.Descrizione,
                    //Tipologia = data.Tipologia.ToString(),
                    Prezzo = data.Prezzo
                });
                //restituzione della view
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
        [Authorize(Policy = "AccountRistoratore")]
        public IActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return View("Error", new ErrorViewModel());
            }

            //recupero l'impiegato da modificare
            var model = bl.GetPiattoById(id);
            if (model == null)
            {
                return View("NotFound", new NotFoundViewModel { EntityId = id, Message = "Sorry, not found" });
            }
            var piattoViewModel = new PiattoViewModel
            {
                Id = model.Id,
                Nome = model.Nome,
                Descrizione = model.Descrizione,
                Tipologia = model.Tipologia.ToString(),
                Prezzo = model.Prezzo
            };
            return View(piattoViewModel);
        }
        [Authorize(Policy = "AccountRistoratore")]
        [HttpPost]
        public IActionResult Edit(PiattoViewModel data)
        {
            if (data == null)
            {
                return View("Error", new ErrorViewModel());
            }
            if (ModelState.IsValid)
            {
                var result = bl.EditPiatto(new Piatto
                {
                    Id = data.Id,
                    Nome = data.Nome,
                    Descrizione = data.Descrizione,
                    //Tipologia = data.Tipologia.,
                    Prezzo = data.Prezzo
                }
                );
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
        [Authorize(Policy = "AccountRistoratore")]
        public IActionResult Delete(int id)
        {
            //... GUARDIA SULL'ID
            var model = bl.GetPiattoById(id);
            //guardia sul model
            return View(model);
        }
        [Authorize(Policy = "AccountRistoratore")]
        [HttpPost]
        public IActionResult Delete(Piatto data)
        {
            var piattoToDelete = bl.GetPiattoById(data.Id);

            var result = bl.DeletePiatto(piattoToDelete);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}

