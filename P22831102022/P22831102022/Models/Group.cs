using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22831102022.Models
{
    //One
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte  Limit { get; set; }

        public List<Student> Students { get; set; }
    }
}
