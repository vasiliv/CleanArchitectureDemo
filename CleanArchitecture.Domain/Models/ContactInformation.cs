using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ContactInformation
    {
        public int Id { get; set; }
        public string ContactType { get; set; }
        // one-to-many relationship
        public IEnumerable<Person> Persons { get; set; }
    }
}
