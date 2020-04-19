using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Data;
using OnlineShopping.Models;

namespace OnlineShopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductTypesController : Controller
    {
        private ApplicationDbContext _db;
        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }
       
        public IActionResult Index()
        {
            return View(_db.ProductTypes.ToList());
        }

        //Create GET Action Method
        public IActionResult Create()
        {
            return View();
        }

        //Create POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.ProductTypes.Add(productTypes);
                await _db.SaveChangesAsync();
                TempData["Save"] = "Product Type Has been Saved";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(productTypes);
        }

        //Edit GET Action Method
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                await _db.SaveChangesAsync();
                TempData["Edit"] = "Tag Name Has been Updated";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(productTypes);
        }


        //Details GET Action Method
        public IActionResult Details(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }
            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Details POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ProductTypes productTypes)
        {
            return RedirectToAction(actionName: nameof(Index));
        }


        //Delete GET Action Method
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Delete POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return NotFound();
                }
                if (id != productTypes.ID)
                {
                    return NotFound();
                }
                var productType = _db.ProductTypes.Find(id);
                if (productType == null)
                {
                    return NotFound();
                }

                _db.Remove(productType);
                await _db.SaveChangesAsync();
                TempData["Delete"] = "Product Type Has been Deleted";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(productTypes);
        }

    }
}

