using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUniteOfWork<Owner> _owner;
        private readonly IUniteOfWork<PortfolioItem> _portfolio;

        public HomeController(IUniteOfWork<Owner> owner, IUniteOfWork<PortfolioItem> portfolio)
        {
            _owner = owner;
            _portfolio = portfolio;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _portfolio.Entity.GetAll().ToList()
            };
            return View(homeViewModel);
        }
    }
}
