using BusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Controllers
{
    public class AccountController : Controller
    {
        Business context = new Business();

        // GET: AccountController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return RedirectToAction("Home", "Index");
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {


            return View("AddCustomer");
        }

        public ActionResult CreateCustomer()
        {


            return View("CreateCustomer");
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            

            return View("AddCustomer", customer);
        }

        [HttpPost]
        public ActionResult AccountCreate(Customer customer)
        {
            context.addCustomer(customer);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login()
        {

            return View("Login");
        }

        public ActionResult LoginPage()
        {
            return View("LoginPage");
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
