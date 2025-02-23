using LibraryManagementSystem.Models.ViewModels;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController:Controller
    {
        
        public static List<Author> Authors = new List<Author>
        {
            new Author { Id = 1, FirstName = "Ahmet", LastName = "Yılmaz", DateOfBirth = new System.DateTime(1975, 5, 20) },
            new Author { Id = 2, FirstName = "Ayşe", LastName = "Kara", DateOfBirth = new System.DateTime(1980, 8, 15) },
            new Author { Id = 3, FirstName = "Mehmet", LastName = "Öztürk", DateOfBirth = new System.DateTime(1990, 3, 10) }
        };

        [HttpGet]
        public IActionResult List()
        {
            var viewModel = Authors.Select(a => new AuthorListViewModel
            {
                Id = a.Id,
                FullName = a.FirstName + " " + a.LastName,
                DateOfBirth = a.DateOfBirth
            }).ToList();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var author = Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();

            return View(author);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AuthorAddViewModel formData)
        {
            int newId = Authors.Any() ? Authors.Max(a => a.Id) + 1 : 1;
            var newAuthor = new Author
            {
                Id = newId,
                FirstName = formData.FirstName,
                LastName = formData.LastName,
                DateOfBirth = formData.DateOfBirth
            };
            Authors.Add(newAuthor);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var author = Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();

            var viewModel = new AuthorUpdateViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Update(AuthorUpdateViewModel formData)
        {
            var author = Authors.FirstOrDefault(a => a.Id == formData.Id);
            if (author == null)
                return NotFound();

            author.FirstName = formData.FirstName;
            author.LastName = formData.LastName;
            author.DateOfBirth = formData.DateOfBirth;
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var author = Authors.FirstOrDefault(a => a.Id == id);
            if (author != null)
                Authors.Remove(author);
            return RedirectToAction("List");
        }
    }
}
