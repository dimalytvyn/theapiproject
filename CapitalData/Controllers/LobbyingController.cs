﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class LobbyingController : Controller
    {
        public IActionResult Index()
        {
            return View("ComingSoon");
        }
    }
}