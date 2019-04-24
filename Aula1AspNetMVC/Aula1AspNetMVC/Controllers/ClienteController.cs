﻿using Aula1AspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1AspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente()
            {
                Nome = "Thaina",
                SobreNome = "Ribeiro",
                DataCadastro = DateTime.Now,
                Id = 1
            };

            return View(cliente);
        }

        public ActionResult Lista()
        {
            var listaCliente = new List<Cliente>()
            {
                new Cliente(){ Nome = "Renan", SobreNome = "Rodrigues", DataCadastro = DateTime.Now, Id = 1},
                new Cliente(){ Nome = "Joao", SobreNome = "Silva", DataCadastro = DateTime.Now, Id = 2}
            };


            return View(listaCliente);
        }
    }
}