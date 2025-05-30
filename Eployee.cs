using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoProj
{
    public class Eployee
    {
        private int Id { get; set; }
        public string FullName { get; set; }

        public int Age { get; set; }


        public string Gender { get; set; }


        public Eployee(string fullName, int age, string gender)
        {
            FullName = fullName;
            Age = age;
            Gender = gender;
        }

    }

   
}
