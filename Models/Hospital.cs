using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAssignment.Models
{
    internal class Hospital
    {

            public string Name { get; set; }
            public string Location { get; set; }
            public List<Doctor> Doctors { get; set; }
            public List<Patient> Patients { get; set; }


            public Hospital(string name, string location)
            {
                Name = name;
                Location = location;
                Doctors = new List<Doctor>();
                Patients = new List<Patient>();
            }

        public void AdmitPatient(Patient patient)
        {
            Patients.Add(patient);
            Console.WriteLine($"{patient.Name} has been admitted to {Name}.");
        }

        public void AssignDoctor(Doctor doctor, Patient patient)
        {
            if (Doctors.Contains(doctor) && Patients.Contains(patient))
            {
                patient.AssignedDoctor = doctor;
                Console.WriteLine($"{doctor.Name} has been assigned to {patient.Name}.");
            }
            else
            {
                Console.WriteLine("Invalid assignment. Doctor or patient not found.");
            }
        }

    }
}
