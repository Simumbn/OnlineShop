using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Data;
using OnlineShopping.Models;

namespace OnlineShopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private ApplicationDbContext _db;
        private IHostingEnvironment _he;
        public ProductsController(ApplicationDbContext db,IHostingEnvironment he )
        {
            _db = db;
            _he = he;
        }
        //GET Index action method
        public IActionResult Index()
        {
            return View(_db.Products.Include(c=>c.ProductTypes).Include(f=>f.TagNames).ToList());
        }

        //POST Index action method
        [HttpPost]
        public IActionResult Index(decimal? lowAmount, decimal? largeAmount)
        {
            var products = _db.Products.Include(c => c.ProductTypes).Include(c => c.TagNames)
                .Where(c => c.Price >= lowAmount && c.Price <= largeAmount).ToList();
            if (lowAmount == null || largeAmount == null)
            {
                products = _db.Products.Include(c => c.ProductTypes).Include(c => c.TagNames).ToList();
            }
            return View(products);
        }

        //Create GET Action Method
        public IActionResult Create()
        {
            ViewData["ProductType"] = new SelectList(_db.ProductTypes.ToList(),"ID", "ProductType");
            ViewData["TagName"] = new SelectList(_db.TagNames.ToList(), "ID", "TagName");
            return View();
        }

        //Create POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Products products,IFormFile image)
        {
            if (ModelState.IsValid)
            {

                var searchproduct = _db.Products.FirstOrDefault(c=>c.Name==products.Name);
                if(searchproduct!=null)
                {
                    ViewBag.msg = "This Product is already exist.";
                    ViewData["ProductType"] = new SelectList(_db.ProductTypes.ToList(), "ID", "ProductType");
                    ViewData["TagName"] = new SelectList(_db.TagNames.ToList(), "ID", "TagName");
                    return View(products);
                }

                if(image!=null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images" , Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "Images/" + image.FileName;
                }
                if(image==null)
                {
                    products.Image = "Images/No-image-found.jpg";
                }

                _db.Products.Add(products);
                await _db.SaveChangesAsync();
                TempData["Save"] = "Product Type Has been Saved";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(products);
        }

        //Edit GET Action Method
        public IActionResult Edit(int? id)
        {
            ViewData["ProductType"] = new SelectList(_db.ProductTypes.ToList(), "ID", "ProductType");
            ViewData["TagName"] = new SelectList(_db.TagNames.ToList(), "ID", "TagName");
            if (id == null)
            {
                return NotFound();
            }

            var product = _db.Products.Include(c=>c.ProductTypes).Include
                              (c=>c.TagNames).FirstOrDefault(c=>c.ID==id);

            if(product==null)
            {
                return NotFound();
            }
            return View(product);
        }

        //Edit POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Products products, IFormFile image)
        {
            if (ModelState.IsValid)
            {

                var searchproduct = _db.Products.FirstOrDefault(c => c.Name == products.Name);
                if (searchproduct != null)
                {
                    ViewBag.msg = "This Product is already exist.";
                    ViewData["ProductType"] = new SelectList(_db.ProductTypes.ToList(), "ID", "ProductType");
                    ViewData["TagName"] = new SelectList(_db.TagNames.ToList(), "ID", "TagName");
                    return View(products);
                }

                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "Images/" + image.FileName;
                }
                if (image == null)
                {
                    products.Image = "Images/No-image-found.jpg";
                }

                _db.Products.Update(products);
                await _db.SaveChangesAsync();
                TempData["Edit"] = "Product Type Has been Updated";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(products);
        }

        //Details GET Action Method
        public IActionResult Details(int? id)
        {
            ViewData["ProductType"] = new SelectList(_db.ProductTypes.ToList(), "ID", "ProductType");
            ViewData["TagName"] = new SelectList(_db.TagNames.ToList(), "ID", "TagName");
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c => c.ProductTypes).Include
                              (c => c.TagNames).FirstOrDefault(c => c.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //Details POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(Products products)
        {
            return RedirectToAction(actionName: nameof(Index));
        }


        //Delete GET Action Method
        public IActionResult Delete(int? id)
        {
            ViewData["ProductType"] = new SelectList(_db.ProductTypes.ToList(), "ID", "ProductType");
            ViewData["TagName"] = new SelectList(_db.TagNames.ToList(), "ID", "TagName");
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c => c.ProductTypes).Include
                              (c => c.TagNames).FirstOrDefault(c => c.ID == id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //This one also work.....

        ////Delete POST Action Method
        //[HttpPost]
        //[ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirm(int? id)
        //{
        //    ViewData["ProductType"] = new SelectList(_db.ProductTypes.ToList(), "ID", "ProductType");
        //    ViewData["TagName"] = new SelectList(_db.TagNames.ToList(), "ID", "TagName");
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var product = _db.Products.FirstOrDefault(c => c.ID == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    _db.Products.Remove(product);
        //    await _db.SaveChangesAsync();
        //    //TempData["Delete"] = "Product Type Has been Deleted";
        //    return RedirectToAction(actionName: nameof(Index));
        //}

        //Delete POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, Products products)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return NotFound();
                }
                if (id != products.ID)
                {
                    return NotFound();
                }
                var product = _db.Products.Find(id);
                if (product == null)
                {
                    return NotFound();
                }

                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
                TempData["Delete"] = "Product Type Has been Deleted";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(products);
        }

    }
}