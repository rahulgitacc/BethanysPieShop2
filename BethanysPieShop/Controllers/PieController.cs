using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private IPieRepository _pieRepository;
        private ICategoryRepository _categoryRepository;

        public PieController(IPieRepository _pieRepository, ICategoryRepository _categoryRepository)
        {
            this._categoryRepository = _categoryRepository;
            this._pieRepository = _pieRepository;
        }
        
        public ViewResult List()
        {
            var viewModel = new PieListVIewModel()
            {
                Pies = _pieRepository.Pies,
                Category = "Cheese cakes"
            };
            return View(viewModel);
        }
    }
}