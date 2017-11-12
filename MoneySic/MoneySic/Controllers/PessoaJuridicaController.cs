using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MoneySic.DataAccess;
using MoneySic.Models;

namespace MoneySic.Controllers
{
    public class PessoaJuridicaController : Controller
    {
        // GET: PessoaFisica
        public ActionResult Index()
        {
            PessoaJuridicaAccess acesso = new PessoaJuridicaAccess();
            IList<PessoaJuridica> pessoa = acesso.Lista();
            return View(pessoa);
        }

        public ActionResult Form(int? id)
        {
            PessoaJuridicaAccess acesso = new PessoaJuridicaAccess();
            PessoaJuridica pessoa = id == null ? new PessoaJuridica() : acesso.Ler(Convert.ToInt32(id));
            return View(pessoa);
        }

        [HttpPost] //Força esse método aceitar por post
        public ActionResult Grava(PessoaJuridica pessoa)
        {
            if (ModelState.IsValid)
            {
                PessoaJuridicaAccess acesso = new PessoaJuridicaAccess();
                acesso.Grava(pessoa);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", pessoa);
            }
        }

    }
}