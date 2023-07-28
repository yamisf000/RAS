using HakunaMatata.Helpers;
using HakunaMatata.Models.DataModels;
using HakunaMatata.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HakunaMatata.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class NewsController : Controller
    {
        private readonly ILevelServices _services;
        public NewsController(ILevelServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            var news = _services.GetListNews();
            return View(news);
        }

        [NoDirectAccess]
        public IActionResult CreateOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Level());
            }
            else
            {
                var level = _services.GetDetails(id);
                if (level == null)
                {
                    return NotFound();
                }
                return View(level);
            }
        }

        [NoDirectAccess]
        public IActionResult CreateOrEditImage(int id = 0)
        {
            if (id == 0)
            {
                return View(new Newspicture());
            }
            else
            {
                var newspic = _services.GetNewsDetails(id);
                if (newspic == null)
                {
                    return NotFound();
                }
                return View(newspic);
            }

        }
    }
}