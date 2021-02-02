using ClothesBAZAR.Entities;
using ClothesBAZAR.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothesBAZAR.Web.Controllers
{
    public class CategoryController : Controller

    {
        CategoriesService categoyService = new CategoriesService();

        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoyService.GetCategory();
            
            return View(categories);
        }
        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    categoyService.SaveCategory(category);
                }
            }
            catch (Exception ex)
            {

                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoyService.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    categoyService.UpdateCategory(category);
                }
            }
            catch (Exception ex)
            {

                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int ID)
        {
            var category = categoyService.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    categoyService.DeleteCategory(category.ID);

                }
            }
            catch (Exception ex)
            {

                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }
    }
}