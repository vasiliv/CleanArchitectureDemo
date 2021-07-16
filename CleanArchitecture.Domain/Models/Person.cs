using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstNameGeorgian { get; set; }
        public string FirstNameLatin { get; set; }
        public string SecondNameGeorgian { get; set; }
        public string SecondNameLatin { get; set; }
        public int IdentityNumber { get; set; }
        public DateTime BornDate { get; set; }
        public string Address { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        // one-to-many relationship
        public int ContactInformationId { get; set; }
        public ContactInformation ContactInformation { get; set; }
        //Todo Photo        
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        //Todo Relations
    }
}
