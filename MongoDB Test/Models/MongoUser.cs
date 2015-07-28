using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDB_Test.Models
{
    public class MongoUser
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public List<string> Address { get; set; }
        
    }
    
}