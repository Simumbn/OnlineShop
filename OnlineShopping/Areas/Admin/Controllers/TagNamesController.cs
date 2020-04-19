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
    public class TagNamesController : Controller
    {
        private ApplicationDbContext _db;
        public TagNamesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.TagNames.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        //Create POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TagNames tagNames)
        {
            if (ModelState.IsValid)
            {
                _db.TagNames.Add(tagNames);
                await _db.SaveChangesAsync();
                TempData["Save"] = "Tag Name Has been saved";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(tagNames);
        }

        //Edit GET Action Method
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }
            var tagName = _db.TagNames.Find(id);
            if (tagName == null)
            {
                return NotFound();
            }
            return View(tagName);
        }
        //Edit POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TagNames tagNames)
        {
            if (ModelState.IsValid)
            {
                _db.Update(tagNames);
                await _db.SaveChangesAsync();
                TempData["Edit"] = "Tag Name Has been Updated";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(tagNames);
        }


        //Details GET Action Method
        public IActionResult Details(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }
            var tagName = _db.TagNames.Find(id);
            if (tagName == null)
            {
                return NotFound();
            }
            return View(tagName);
        }
        //Details POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(TagNames tagNames)
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
            var tagName = _db.TagNames.Find(id);
            if (tagName == null)
            {
                return NotFound();
            }
            return View(tagName);
        }
        //Delete POST Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, TagNames tagNames)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return NotFound();
                }
                if (id != tagNames.ID)
                {
                    return NotFound();
                }
                var tagName = _db.TagNames.Find(id);
                if (tagName == null)
                {
                    return NotFound();
                }

                _db.Remove(tagName);
                await _db.SaveChangesAsync();
                TempData["Delete"] = "Tag Name Has been Deleted";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(tagNames);
        }

    }
}