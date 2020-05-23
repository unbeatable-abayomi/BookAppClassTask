using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAppClassTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAppClassTask.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Lists()
        {
            List<Author> authors = new List<Author>() 
            {
              new Author {AuthorId = 10,AuthorName="Kenny Mike",Sex="male",City="Lagos",Address="9 mile chisco road",Phone="202-344-32",State="Lagos State"},
              new Author {AuthorId = 11,AuthorName="Tuch Mine",Sex="female",City="Ohis",Address="23 kina view road",Phone="12-232202-344-32",State="Alabama State"},
              new Author {AuthorId = 12,AuthorName="Ifeanyi Homa",Sex="male",City="Lekki",Address="89 crystle estate road",Phone="202-34-092",State="Lagos State"},
              new Author {AuthorId = 13,AuthorName="Seun Anthony",Sex="male",City="Ogun",Address="Jane Milla road off Cannanland road",Phone="202-344-32",State="Ogun State"}

            };
            return View(authors);
        }
        public IActionResult Create()
        {
            Author author = new Author()
            {
                AllState = Enum.GetValues(typeof(State)).Cast<State>().ToList(),
                 AllSex = Enum.GetValues(typeof(Sex)).Cast<Sex>().ToList()

            };
                
            return View(author);
        }
    }
}