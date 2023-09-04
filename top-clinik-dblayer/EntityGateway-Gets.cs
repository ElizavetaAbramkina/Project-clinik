using progect_clinik_models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_clinik_dblayer
{
    public partial class EntityGateway
    {
        public Client[] GetClients(Func<Client, bool> predicate) =>
            Context.Clients.Where(predicate).ToArray();
        public Client[] GetClients() => 
            Context.Clients.ToArray();

        public Doctor[] GetDoctors(Func<Doctor, bool> predicate) =>
           Context.Doctors.Where(predicate).ToArray();
        public Doctor[] GetDoctors() =>
            Context.Doctors.ToArray();

        public Patient[] GetPatients(Func<Patient, bool> predicate) =>
           Context.Patients.Where(predicate).ToArray();
        public Patient[] GetPatients() =>
            Context.Patients.ToArray();

        public Analysis[] GetАnalyzes(Func<Analysis, bool> predicate) =>
           Context.Аnalyzes.Where(predicate).ToArray();
        public Analysis[] GetАnalyzes() =>
            Context.Аnalyzes.ToArray();

        public Appointment[] GetAppointments(Func<Appointment, bool> predicate) =>
          Context.Appointments.Where(predicate).ToArray();
        public Appointment[] GetAppointments() =>
            Context.Appointments.ToArray();

        public AppointmentAddress[] GetAppointment_Address(Func<AppointmentAddress, bool> predicate) =>
          Context.Appointment_Address.Where(predicate).ToArray();
        public AppointmentAddress[] GetAppointment_Address() =>
            Context.Appointment_Address.ToArray();

        public Consultation[] GetConsultations(Func<Consultation, bool> predicate) =>
         Context.Consultations.Where(predicate).ToArray();
        public Consultation[] GetConsultations() =>
            Context.Consultations.ToArray();

        public Department[] GetDepartments(Func<Department, bool> predicate) =>
         Context.Departments.Where(predicate).ToArray();
        public Department[] GetDepartments() =>
            Context.Departments.ToArray();

        public Diagnosis[] GetDiagnoses(Func<Diagnosis, bool> predicate) =>
         Context.Diagnoses.Where(predicate).ToArray();
        public Diagnosis[] GetDiagnoses() =>
            Context.Diagnoses.ToArray();

        public Species_enimals[] GetSpecies_Enimals(Func<Species_enimals, bool> predicate) =>
         Context.Species_Enimals.Where(predicate).ToArray();
        public Species_enimals[] GetSpecies_Enimals() =>
            Context.Species_Enimals.ToArray();

    }
}
