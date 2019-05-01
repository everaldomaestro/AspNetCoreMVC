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
        private readonly IPacienteService _pacienteService;
        private readonly IMapper _mapper;

        public NotificacaoIncidenteController(
            INotificacaoIncidenteService notificacaoIncidenteService,
            ISetorService setorService,
            IPacienteService pacienteService,
            IMapper mapper)
        {
            _notificacaoIncidenteService = notificacaoIncidenteService;
            _setorService = setorService;
            _pacienteService = pacienteService;
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
            //ViewBag.SetorId = new SelectList(_setorService.GetAll(), "SetorId", "Nome");
            return View();
        }

        // POST: NotificacaoIncidente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NotificacaoIncidenteViewModel notificacaoIncidente)
        {
            notificacaoIncidente.NomePaciente = _pacienteService.GetById(notificacaoIncidente.PacienteId).Nome;

            if (ModelState.IsValid)
            {
                var _notificacaoIncidente = _mapper.Map<NotificacaoIncidenteViewModel, NotificacaoIncidente>(notificacaoIncidente);
                _notificacaoIncidenteService.Add(_notificacaoIncidente);

                return RedirectToAction("Index");
            }

            return View(notificacaoIncidente);
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
            var setores = _setorService.GetAll()
                .Select(s => new { id = s.SetorId , nome = s.Nome}).ToList();
               
            return Content(JsonConvert.SerializeObject(setores.Distinct()));
        }

        public ActionResult OnGetNomeSetores(string nome)
        {
            var setores = _setorService.GetByNome(nome)
                .Select(s => new { id = s.SetorId, nome = s.Nome }).ToList();

            return Content(JsonConvert.SerializeObject(setores.Distinct()));
        }

        public ActionResult OnGetPacientes()
        {
            var pacientes = _pacienteService.GetAll()
                .Select(p => new { id = p.PacienteId, nome = p.Nome }).ToList();

            return Content(JsonConvert.SerializeObject(pacientes.Distinct()));
        }

        public ActionResult OnGetNomePacientes(string nome)
        {
            var pacientes = _pacienteService.GetByNome(nome)
                .Select(p => new { id = p.PacienteId, nome = p.Nome }).ToList();

            return Content(JsonConvert.SerializeObject(pacientes.Distinct()));
        }
    }
}