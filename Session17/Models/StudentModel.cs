using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session17.Models
{
    public class StudentModel
    {
        public int  Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string StudentNumber { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
