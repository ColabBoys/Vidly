using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        // go to customer object in models and copy all attributes
        // exclude membershiptype (not id) because this is a domain class and this property is creating a dependency between our dto and domain model
        // so a hacker or some api request could change it and fuck up our code
        // in dtos we only use simple data types like byte int etc
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool isSubscribedToNewsLetter { get; set; }
        
        public byte MembershipTypeId { get; set; }

        // for the api membership type thing
        public MembershipTypeDto MembershipType { get; set; }

        //below is to display it as something else
        // but this way, each time you have to recompile the code
        // alternate way is to do it in the view itself using html <label for="Birthdate"...
        // but the above way if the below name is changed then you would have to change it manually 

        // have to comment this out because if this applies to a dto property we will get an exception
        // because we changed the dto api controller thing to return a 201 for api convention and doesnt just return a dto customer object
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}