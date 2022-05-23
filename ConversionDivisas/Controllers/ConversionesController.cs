using ConversionDivisas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Service;
using DataLayer.ModelViews;

namespace ConversionDivisas.Controllers
{
    public class ConversionesController : Controller
    {
        private readonly DivisaService service;
        public ConversionesController()
        {
            service = new();
        }
        public IActionResult Index()
        {            
            return View();
        }
        [HttpPost]
        public IActionResult IndexPost(DivisiaEntradaModalView md)
        {
            md.Cambiado = service.getChangeDivisa(md);

            return View(md);
        }

    }
}
