﻿using ArtShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategory _categoryRepository;
        public CategoryMenu(ICategory categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllCategory.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
