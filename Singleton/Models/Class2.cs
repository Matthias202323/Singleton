using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Models
{
    internal class Class2
    {
        [Key] 
        public int _id { get; set; }
        public string _name { get; set; }
        private readonly DatabaseSingleton _singleton;
        public Class2(string name)
        {
            
            _name = name;
            
        }
    }
}
