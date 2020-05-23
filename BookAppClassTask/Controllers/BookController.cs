using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAppClassTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAppClassTask.Controllers
{
    public class BookController : Controller
    {
        public IActionResult List()
        {
            List<Book> books = new List<Book>()
            {
                new Book{BookId = 101,BookTitle="Eze Goes To School",Price = 239,AuthorId="10",PublisherId=111,DateOfPublishing="12-1-2020" },
                 new Book{BookId = 102,BookTitle="Nile Mile",Price = 139,AuthorId="11",PublisherId=112,DateOfPublishing="12-10-2009" },
                  new Book{BookId = 103,BookTitle="Wipe not Kenny",Price = 39,AuthorId="12",PublisherId=113,DateOfPublishing="14-7-1998" },
                   new Book{BookId = 103,BookTitle="Trail Darila",Price = 361,AuthorId="13",PublisherId=114,DateOfPublishing="14-10-1996" }

            };
            return View(books);
        }
        public IActionResult Create()
        {
            Book books = new Book()
            {

            };
            return View(books);
        }
    }
}