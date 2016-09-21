using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Laboratorio_B46671.Models;

namespace Laboratorio_B46671.Controllers
{
    public class ClienteController : Controller
    {
        BD_B46671Entities baseDatos = new BD_B46671Entities();
        // GET: Cliente
        public ActionResult Index()
        {
            ModeloIntermedio modelo = new ModeloIntermedio();
            modelo.listaCliente = baseDatos.cliente.ToList();
            modelo.listaTelefono = baseDatos.telefono.ToList();
            modelo.listaCuenta = baseDatos.cuenta.ToList();
            return View(modelo);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cliente cliente = baseDatos.cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModeloIntermedio modelo)
        {
            if (ModelState.IsValid)
            {
                baseDatos.cliente.Add(modelo.modeloCliente);
                baseDatos.SaveChanges();
                if (modelo.modeloTelefono1.numero != null)
                {
                    modelo.modeloTelefono1.cedula = modelo.modeloCliente.cedula;
                    baseDatos.telefono.Add(modelo.modeloTelefono1);
                }

                if (modelo.modeloTelefono2.numero != null)
                {
                    modelo.modeloTelefono2.cedula = modelo.modeloCliente.cedula;
                    baseDatos.telefono.Add(modelo.modeloTelefono2);
                }

                if (modelo.modeloCuenta1.numero != null)
                {
                    modelo.modeloCuenta1.cedula = modelo.modeloCliente.cedula;
                    baseDatos.cuenta.Add(modelo.modeloCuenta1);
                }

                if (modelo.modeloCuenta2.numero != null)
                {
                    modelo.modeloCuenta2.cedula = modelo.modeloCliente.cedula;
                    baseDatos.cuenta.Add(modelo.modeloCuenta2);
                }

                if (modelo.modeloCuenta3.numero != null)
                {
                    modelo.modeloCuenta3.cedula = modelo.modeloCliente.cedula;
                    baseDatos.cuenta.Add(modelo.modeloCuenta3);
                }

                baseDatos.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Debe completar toda la información necesaria.");
                return View(modelo);
            }
        }
    }
}