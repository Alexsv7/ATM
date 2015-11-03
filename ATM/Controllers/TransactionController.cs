﻿using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class TransactionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Transaction
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Deposit(int checkingAccountId  )
        {
            return View();
        }

    [HttpPost]
        public ActionResult Deposit(Transaction transaction)
        {
        if(ModelState.IsValid)
        {
            db.Transactions.Add(transaction);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
            return View();
        }
    }
}