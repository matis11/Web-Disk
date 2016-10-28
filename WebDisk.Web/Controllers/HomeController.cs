﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDisk.BusinessLogic.Interfaces;
using WebDisk.BusinessLogic.ViewModels;
using WebDisk.Database.IdentityExtensions;
using WebDisk.Web.Attributes;
using WebDisk.Web.Models.Home;

namespace WebDisk.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ISpaceService _spaceService;

        public HomeController(ISpaceService spaceService)
        {
            _spaceService = spaceService;
        }

        [Route("")]
        [AutoMap(typeof(SpaceBusinessLogicViewModel), typeof(SpaceOverviewViewModel))]
        public ActionResult Index()
        {
            var spaces = _spaceService.GetSpaces(User.Identity.GetUserId());
            if (spaces.Count() == 0)
            {
                return RedirectToAction("Index", "Directory");
            }
            return View(spaces);
        }
    }
}