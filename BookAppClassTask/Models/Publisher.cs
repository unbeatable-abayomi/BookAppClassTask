using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAppClassTask.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public IEnumerable<State> AllState { get; set; }
        public string Country { get; set; }
        public IEnumerable<Countries> AllCountires { get; set; }


    }
}
