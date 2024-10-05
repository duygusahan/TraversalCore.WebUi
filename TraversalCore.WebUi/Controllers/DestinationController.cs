﻿using Microsoft.AspNetCore.Mvc;
using TraversalCore.BusinessLayer.Abstract;
using TraversalCore.EntityLayer.Concrete;

namespace TraversalCore.WebUi.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i=id;
            var values = _destinationService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
