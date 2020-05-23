using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAppClassTask.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public double Price { get; set; }
   

        public string AuthorId { get; set; }
        public int PublisherId { get; set; }

        public string DateOfPublishing { get; set; }
       
    }
}
