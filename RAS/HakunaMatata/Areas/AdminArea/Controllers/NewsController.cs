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
      
    }
}