using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200389510F.Models
{
    //GIT URL IS https://github.com/MichaelRoussel/Comp2084Final
    //Visual studio was being a pain, could not find the database so I have the view working as it should, however I am not sure if 
    //the seeding or creating of a post actually works, but it should as the code looks correct
    public class ChatMessage
    {

        public virtual int ID { get; set; }
        [Required]

        public virtual string Message { get; set; }
        [Required]
        public virtual string Name { get; set; }
        public virtual DateTime Date { get; set; }



    }
}