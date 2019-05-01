using AspNET.MVC.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AspNET.MVC.Controllers
{
    public class NotificacaoIncidenteController : Controller
    {
        private readonly INotificacaoIncidenteService _notificacaoIncidenteService;
        private readonly ISetorService _setorService;
        private readonly IMapper _mapper;

        public NotificacaoIncidenteController(
            INotificacaoIncidenteService notificacaoIncidenteService,
            ISetorService setorService,
            IMapper mapper)
        {
            _notificacaoIncidenteService = notificacaoIncidenteService;
            _setorService = setorService;
            _mapper = mapper;
        }

        // GET: NotificacaoIncidente
        public ActionResult Index()
        {
            var result = _mapper.Map<ICollection<NotificacaoIncidente>, ICollection<NotificacaoIncidenteViewModel>>
                (_notificacaoIncidenteService.GetAll());
            return View(result);
        }

        // GET: NotificacaoIncidente/Details/5
        public ActionResult Details(int id)
        {
            var result = _mapper.Map<NotificacaoIncidente, NotificacaoIncidenteViewModel>
                (_notificacaoIncidenteService.GetById(id));
            return View(result);
        }

        // GET: NotificacaoIncidente/Create
        public ActionResult Create()
        {
            ViewBag.SetorId = new SelectList(_setorService.GetAll(), "SetorId", "Nome");
            return View();
        }

        // POST: NotificacaoIncidente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NotificacaoIncidente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NotificacaoIncidente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NotificacaoIncidente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NotificacaoIncidente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult OnGetSetores()
        {
            //Will need to add one predefined request, handler=Countries in Url.
            var setores = _setorService.GetAll()
                .Select(s => new { id = s.SetorId , nome = s.Nome}).ToList();
               
            return Content(JsonConvert.SerializeObject(setores.Distinct()));
        }

        public ActionResult OnGetCountries()
        {
            //Will need to add one predefined request, handler=Countries in Url.
            List<string> countryNames = new List<string>();

            foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                var country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                countryNames.Add(country.DisplayName.ToString());
            }

            return Content(JsonConvert.SerializeObject(countryNames.Distinct()));
        }

        public JsonResult OnGetCountriesStartwith(string startWith)
        {
            //Will need to add one predefined request, handler=CountriesStartwith&startWith=A  
            List<string> countryNames = new List<string>();
            foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                var country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                countryNames.Add(country.DisplayName.ToString());
            }
            return new JsonResult(countryNames.Distinct().Where(o => o.StartsWith(startWith)));
        }
    }
}