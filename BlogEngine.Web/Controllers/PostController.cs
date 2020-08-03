using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogEngine.Application.Services;
using BlogEngine.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly PostService _service;

        public PostController(PostService service)
        {
            _service = service;
        }

        // GET: PostController
        public ActionResult Index()
        {
           return BadRequest();
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            var model = _service.GetById(id);
            return BadRequest(model);
        }

        // GET: PostController/Create
        public ActionResult Create()
        {

            return BadRequest();
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, PostViewModel model)
        {
            try
            {
                _service.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {

            return BadRequest();
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return BadRequest();
        }

        // POST: PostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {

                 return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
