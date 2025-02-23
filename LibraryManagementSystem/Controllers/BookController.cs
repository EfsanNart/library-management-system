using LibraryManagementSystem.Models.ViewModels;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class BookController:Controller
    {
        // In-memory book list
        public static List<Book> Books = new List<Book>();

        public static List<Author> Authors = AuthorController.Authors;

        [HttpGet]
        public IActionResult List()
        {
            var viewModel = Books.Select(b => new BookListViewModel
            {
                Id = b.Id,
                Title = b.Title,
                AuthorFullName = Authors.FirstOrDefault(a => a.Id == b.AuthorId)?.FirstName + " " +
                                 Authors.FirstOrDefault(a => a.Id == b.AuthorId)?.LastName,
                Genre = b.Genre,
                PublishDate = b.PublishDate
            }).ToList();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            return View(book);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Authors = Authors;
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookAddViewModel formData)
        {
            int newId = Books.Any() ? Books.Max(b => b.Id) + 1 : 1;
            var newBook = new Book
            {
                Id = newId,
                Title = formData.Title,
                AuthorId = formData.AuthorId,
                Genre = formData.Genre,
                PublishDate = formData.PublishDate,
                ISBN = formData.ISBN,
                CopiesAvailable = formData.CopiesAvailable
            };
            Books.Add(newBook);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            var viewModel = new BookUpdateViewModel
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable
            };
            ViewBag.Authors = Authors;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Update(BookUpdateViewModel formData)
        {
            var book = Books.FirstOrDefault(b => b.Id == formData.Id);
            if (book == null)
                return NotFound();

            book.Title = formData.Title;
            book.AuthorId = formData.AuthorId;
            book.Genre = formData.Genre;
            book.PublishDate = formData.PublishDate;
            book.ISBN = formData.ISBN;
            book.CopiesAvailable = formData.CopiesAvailable;

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
                Books.Remove(book);

            return RedirectToAction("List");
        }
    }
}
