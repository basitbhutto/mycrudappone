using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Information.Models
{
    public class Student
    {
        public string? Id { get; set; } // firebase unique id
        public string? Student_id { get; set; }
        public string? fullname { get; set; }
        public string? degree_title { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
    }
}
