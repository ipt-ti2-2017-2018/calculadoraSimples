using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraSimples.Controllers {

   public class HomeController : Controller {

      // GET: Home
      public ActionResult Index() {
         return View();
      }

      // POST: Home
      [HttpPost]
      public ActionResult Index(
         int operando1,
         int operando2,
         string operador) {

         int resultado = 0;

         switch(operador) {
            case "+":
               resultado=operando1+operando2;
               break;
            case "-":
               resultado=operando1-operando2;
               break;
            case "x":
               resultado=operando1*operando2;
               break;
            case ":":
               resultado=operando1/operando2;
               break;
         }

         // view bag que envia o Resultado do Controller para a View
         ViewBag.Resultado=resultado;
         ViewBag.Operando1=operando1;
         ViewBag.Operando2=operando2;
         ViewBag.Operador=operador;

         return View();
      }
   }
}