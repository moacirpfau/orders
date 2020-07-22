using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using orders.Models;
using orders.Repositories;

namespace orders.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoRepository pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            this.pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Pedidos = pedidoRepository.GetPedidos();
            ViewBag.Canal = pedidoRepository.GetCanal();
            return View();
        }

        public IActionResult GetCanal()
        {
            return View(pedidoRepository.GetCanal());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        public IActionResult Index(Int32 pedido, string canal)
        {
            ViewBag.Pedidos = pedidoRepository.GetPedidos(pedido, canal);
            ViewBag.Canal = pedidoRepository.GetCanal();
            return View();
        }
    }
}
