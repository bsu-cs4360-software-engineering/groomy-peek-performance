using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace groomy.Appointments
{
    public interface iAppointmentInterface
    {
        Task addAppointmentAsync(appointment appointment, string customerid);
        Task<appointment> getAppointmentById(int appointmentId);
        Task<List<appointment>> getAllAppointments();
        Task updateAppointment(appointment appointment);
        Task deleteAppointmentById(int appointmentId);
    }
}