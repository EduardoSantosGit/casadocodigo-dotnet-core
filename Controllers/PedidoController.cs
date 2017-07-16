using System;
using Microsoft.AspNetCore.Mvc;

namespace casadocodigo.Controllers
{
    public class PedidoController : Controller
    {
       public IActionResult Carrossel()
       {
           return View();
       }

       public IActionResult Carrinho()
       {
           return View();
       }

       public IActionResult Resumo()
       {
           return View();
       }

    }
}