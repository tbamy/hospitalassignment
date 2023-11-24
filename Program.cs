using System;
using System.Collections.Generic;
using HospitalAssignment.Models;
class Program
{
    static void Main()
    {
        
        Hospital hospital = new Hospital("Purple Academy Hospital", "123 Main St");

        Doctor doctor1 = new Doctor("Dr. Feranmi", "Cardiologist");
        Doctor doctor2 = new Doctor("Dr. Alonge", "Gynaecologist");
        Doctor doctor3 = new Doctor("Dr. Afolaranmi", "Pediatrician");
        Doctor doctor4 = new Doctor("Dr. Suleiman", "Dentist");

        Patient patient1 = new Patient("Paul Pogba", 35);
        Patient patient2 = new Patient("Bruno Fernandes", 30);
        Patient patient3 = new Patient("Erling Haaland", 24);
        Patient patient4 = new Patient("Kylian Mbappe", 28);
        Patient patient5 = new Patient("Cristiano Ronaldo", 32);
        Patient patient6 = new Patient("Lionel Messi", 27);
        Patient patient7 = new Patient("Luka Modric", 28);
        Patient patient8 = new Patient("Marcus Rashford", 25);
        Patient patient9 = new Patient("Neymar Jnr", 24);
        Patient patient10 = new Patient("Antoine Griezman", 25);
        Patient patient11 = new Patient("Aaron Wan-Bissaka", 28);
        Patient patient12 = new Patient("Gabriel Jesus", 25);
        Patient patient13 = new Patient("Gabriel Martinelli", 24);
        Patient patient14 = new Patient("Carlos Casemiro", 25);
        Patient patient15 = new Patient("Romelu Lukaku", 29);
        Patient patient16 = new Patient("David De Gea", 26);
        Patient patient17 = new Patient("Anthony Martial", 28);
        Patient patient18 = new Patient("Mesut Ozil", 29);
        Patient patient19 = new Patient("Kevin De Bruyne", 27);
        Patient patient20 = new Patient("Rasmus Hojlund", 29);



        hospital.Doctors.Add(doctor1);
        hospital.Doctors.Add(doctor2);

        hospital.AdmitPatient(patient1);
        hospital.AdmitPatient(patient2);

        hospital.AssignDoctor(doctor1, patient1);
        hospital.AssignDoctor(doctor2, patient2);
    }
}
