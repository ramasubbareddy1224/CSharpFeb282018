using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
   public class StudentTest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string Phone { get; set; }

        public int Marks { get; set; }



        public int GetStudentMarks()
        {
            return Marks;
        }
    }
}
