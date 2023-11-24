using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAssignment.Models
{
    internal class Doctor
    {
            public string Name { get; set; }
            public string Specialization { get; set; }


            public Doctor(string name, string specialization)
            {
                Name = name;
                Specialization = specialization;
            }
 
    }
}
