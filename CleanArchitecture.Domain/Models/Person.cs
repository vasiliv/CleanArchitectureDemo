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
        [Display(Name = "სახელი ქართულად")]
        public string FirstNameGeorgian { get; set; }
        [Display(Name = "First Name")]
        public string FirstNameLatin { get; set; }
        [Display(Name = "სახელი ქართულად")]
        public string SecondNameGeorgian { get; set; }
        [Display(Name = "Last Name")]
        public string SecondNameLatin { get; set; }
        [Display(Name = "პირადი ნომერი")]
        public int IdentityNumber { get; set; }
        public DateTime BornDate { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        // one-to-many relationship
        [Range(0, 10, ErrorMessage = "შეიყვანეთ რიცხვი 0-დან 10-მდე")]
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
