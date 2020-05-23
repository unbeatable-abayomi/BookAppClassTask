using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAppClassTask.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public string Phone { get; set; }

        public string Sex { get; set; }
        public IEnumerable<Sex> AllSex { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public IEnumerable<State> AllState { get; set; }
        public string Address { get; set; }
    }
}
