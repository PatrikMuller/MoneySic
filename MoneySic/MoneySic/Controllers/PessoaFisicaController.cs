using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MoneySic.DataAccess;
using MoneySic.Models;

namespace MoneySic.Controllers
{
    public class PessoaFisicaController : Controller
    {
        // GET: PessoaFisica
        public ActionResult Index()
        {
            PessoaFisicaAccess dao = new PessoaFisicaAccess();
            IList<PessoaFisica> posts = dao.Lista();
            return View(posts);
        }

        public ActionResult Form(int? id)
        {
            PessoaFisicaAccess dao = new PessoaFisicaAccess();
            PessoaFisica obj = id == null ? new PessoaFisica() : dao.BuscaPorId(Convert.ToInt32(id));
            return View(obj);
        }

        [HttpPost] //Força esse método aceitar por post
        public ActionResult Grava(PessoaFisica obj)
        {
            if (ModelState.IsValid)
            {
                PessoaFisicaAccess dao = new PessoaFisicaAccess();

                dao.Grava(obj);

                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", obj);
            }
        }
    }
}