﻿using HakunaMatata.Helpers;
using HakunaMatata.Models.DataModels;
using HakunaMatata.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HakunaMatata.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class LevelController : Controller
    {
        private readonly ILevelServices _services;
        public LevelController(ILevelServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            var levels = _services.GetListLevels();
            return View(levels);
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

        [HttpPost]
        public IActionResult CreateOrEdit(int id, [Bind("Id,LevelName")]Level level)
        {
            if (ModelState.IsValid)
            {
                //insert
                if (id == 0)
                {
                    _services.Create(level);
                }

                //update
                else
                {
                    try
                    {
                        _services.UpdateLevel(level);
                    }
                    catch (Exception)
                    {
                        if (!_services.IsExist(level.Id))
                        {
                            return NotFound();
                        }
                        else throw;
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAllLevels", _services.GetListLevels()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "CreateOrEdit", level) });
        }

        [HttpPost]
        public IActionResult CreateOrEditImage(int id, [Bind("Id,PictureName,NewsID,URL")] Newspicture newspic)
        {
            if (ModelState.IsValid)
            {
                //insert
                if (id == 0)
                {
                    _services.CreateNewsPicture(newspic);
                }

                //update
                else
                {
                    try
                    {
                        _services.UpdateNewsPicture(newspic);
                    }
                    catch (Exception)
                    {
                        if (!_services.IsExistNews(newspic.Id))
                        {
                            return NotFound();
                        }
                        else throw;
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAllNews", _services.GetListNews()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "CreateOrEditImage", newspic) });
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int id)
        {
            _services.DeleteLevel(id);
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAllLevels", _services.GetListLevels()) });
        }
    }
}