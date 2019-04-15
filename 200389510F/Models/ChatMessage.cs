using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _200389510F.Models
{
    //GIT URL IS https://github.com/MichaelRoussel/Comp2084Final
    public class ChatMessage
    {

        public virtual int ID { get; set; }
        [Required]

        public virtual string Message { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Date { get; set; }



    }
}