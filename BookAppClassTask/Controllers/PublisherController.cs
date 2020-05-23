using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAppClassTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAppClassTask.Controllers
{
    public class PublisherController : Controller
    {
        public IActionResult Index()
        {
            List<Publisher> publishers = new List<Publisher>()
            {
                new Publisher{PublisherId = 111,PublisherName = "adaku contedm", Address="11 abe road",Phone="2993-829", Country="Nigeria", City="Lagos", State="Lagos State"},
                 new Publisher{PublisherId = 112,PublisherName = "Mike Muna", Address="11 austin house",Phone="20993-829", Country="Nigeria", City="Ota", State="Ogun State"},
                  new Publisher{PublisherId = 113,PublisherName = "Rich Kenny", Address="3rd Avenue",Phone="2993-8009", Country="Usa", City="Ohin Town", State="Ohis State"},
                   new Publisher{PublisherId = 114,PublisherName = "Williams Genk", Address="4th Genk Mile",Phone="193-829-23", Country="Nigeria", City="Abia City", State="Abia State"}

            };
            return View(publishers);
        }
        public IActionResult Create()
        {
            Publisher publisher = new Publisher() {
                AllState = Enum.GetValues(typeof(State)).Cast<State>().ToList(),
                 AllCountires = Enum.GetValues(typeof(Countries)).Cast<Countries>().ToList()

            };
            return View(publisher);
        }
    }
}