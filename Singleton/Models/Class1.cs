using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Models
{
    internal class Class1
       
    {
        [Key]
        public int _id { get; set; }
        public string _name { get; set; }
        public DBContext _context {  get; set; }
        public Class1(string name)
        {   
           /* _id = id;*/
            _name = name;
           /* _context = context;*/
        }

    }
}
