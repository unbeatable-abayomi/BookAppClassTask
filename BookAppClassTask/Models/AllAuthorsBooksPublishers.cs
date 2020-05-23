using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAppClassTask.Models
{
    public class AllAuthorsBooksPublishers
    {
        public List<Author> Authors { get; set; } = new List<Author>()
        {
             new Author {AuthorId = 10,AuthorName="Kenny Mike",Sex="male",City="Lagos",Address="9 mile chisco road",Phone="202-344-32",State="Lagos State"},
              new Author {AuthorId = 11,AuthorName="Tuch Mine",Sex="female",City="Ohis",Address="23 kina view road",Phone="12-232202-344-32",State="Alabama State"},
              new Author {AuthorId = 12,AuthorName="Ifeanyi Homa",Sex="male",City="Lekki",Address="89 crystle estate road",Phone="202-34-092",State="Lagos State"},
              new Author {AuthorId = 13,AuthorName="Seun Anthony",Sex="male",City="Ogun",Address="Jane Milla road off Cannanland road",Phone="202-344-32",State="Ogun State"}
        };

        public List<Book> Books { get; set; } = new List<Book>()
        {
         new Book{BookId = 101,BookTitle="Eze Goes To School",Price = 239,AuthorId="10",PublisherId=111,DateOfPublishing="12-1-2020" },
                 new Book{BookId = 102,BookTitle="Nile Mile",Price = 139,AuthorId="11",PublisherId=112,DateOfPublishing="12-10-2009" },
                  new Book{BookId = 103,BookTitle="Wipe not Kenny",Price = 39,AuthorId="12",PublisherId=113,DateOfPublishing="14-7-1998" },
                   new Book{BookId = 103,BookTitle="Trail Darila",Price = 361,AuthorId="13",PublisherId=114,DateOfPublishing="14-10-1996" }

        };

        public List<Publisher> Publishers { get; set; } = new List<Publisher>()
        {
              new Publisher{PublisherId = 111,PublisherName = "adaku contedm", Address="11 abe road",Phone="2993-829", Country="Nigeria", City="Lagos", State="Lagos State"},
                 new Publisher{PublisherId = 112,PublisherName = "Mike Muna", Address="11 austin house",Phone="20993-829", Country="Nigeria", City="Ota", State="Ogun State"},
                  new Publisher{PublisherId = 113,PublisherName = "Rich Kenny", Address="3rd Avenue",Phone="2993-8009", Country="Usa", City="Ohin Town", State="Ohis State"},
                   new Publisher{PublisherId = 114,PublisherName = "Williams Genk", Address="4th Genk Mile",Phone="193-829-23", Country="Nigeria", City="Abia City", State="Abia State"}
        };

        public string Title { get; set; }
        public string Header { get; set; }
    }
}
