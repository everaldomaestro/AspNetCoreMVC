using AspNET.MVC.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNET.MVC.Controllers
{
    public class NotificacaoIncidenteController : Controller
    {
        private readonly INotificacaoIncidenteService _notificacaoIncidenteService;
        private readonly IMapper _mapper;

        public NotificacaoIncidenteController(INotificacaoIncidenteService notificacaoIncidenteService, IMapper mapper)
        {
            _notificacaoIncidenteService = notificacaoIncidenteService;
            _mapper = mapper;
        }

        // GET: NotificacaoIncidente
        public ActionResult Index()
        {
            var result = _mapper.Map<ICollection<NotificacaoIncidente>, ICollection<NotificacaoIncidenteListViewModel>>
                (_notificacaoIncidenteService.GetAll());
            return View(result);
        }

        // GET: NotificacaoIncidente/Details/5
        public ActionResult Details(int id)
        {
            var result = _mapper.Map<NotificacaoIncidente, NotificacaoIncidenteListViewModel>
                (_notificacaoIncidenteService.GetById(id));
            return View(result);
        }

        // GET: NotificacaoIncidente/Create
        public ActionResult Create()
        {
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
    }
}