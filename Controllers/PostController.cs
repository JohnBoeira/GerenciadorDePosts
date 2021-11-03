using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Post.WebApplication.Data;
using Post.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.WebApplication.Controllers
{
    public class PostController : Controller
    {
        // GET: PostController
        public ActionResult Index()
        {
            var posts = PostRepository.SelecionarTodos();

            return View(posts);
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            var post = PostRepository.SelecionarPorId(id);

            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        // GET: PostController/Create
        public ActionResult Create()
        {
            var post = new Posts();

            return View(post);
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Posts post)
        {
            try
            {

                PostRepository.Adicionar(post);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            var post = PostRepository.SelecionarPorId(id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Posts post)
        {
            try
            {
                PostRepository.Editar(id, post);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            var post = PostRepository.SelecionarPorId(id);

            if (post == null)
            {
                return NotFound();
            }
            return View();
        }

        // POST: PostController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                PostRepository.Excluir(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
