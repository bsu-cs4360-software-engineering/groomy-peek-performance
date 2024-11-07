using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groomy.Appointments;
using Google.Cloud.Firestore;

namespace groomy.Appointments
{
    public class appointmentCRUD : iAppointmentInterface
    {
        private FirestoreDb __db;

        public appointmentCRUD(FirestoreDb db)
        {
            __db = db;
        }

        public async Task<List<appointment>> getAllAppointments()
        {
            var appointments = new List<appointment>();
            Query query = __db.Collection("Appointment");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                if (document.Exists)
                {
                    var appointmentData = document.ConvertTo<appointment>();
                    appointments.Add(appointmentData);
                }
            }
            return appointments;
        }


        public async Task addAppointmentAsync(appointment appointment, string customerId)
        {
            // Set the foreign key to the customer ID
            appointment.foreignKey = customerId;

            DocumentReference docRef = __db.Collection("Appointments").Document();
            await docRef.SetAsync(appointment);
            Console.WriteLine($"Added appointment with ID: {docRef.Id}");
        }

        public async Task<appointment> getAppointmentById(int appointmentId)
        {
            DocumentReference docRef = __db.Collection("Appointments").Document(appointmentId.ToString());
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return snapshot.ConvertTo<appointment>();
            }

            return null;
        }

        public async Task updateAppointment(appointment appointment)
        {
            DocumentReference docRef = __db.Collection("Appointments").Document(appointment.id.ToString());
            await docRef.SetAsync(appointment, SetOptions.MergeAll);
            Console.WriteLine($"Updated appointment with ID: {appointment.id}");
        }

        public async Task deleteAppointmentById(int appointmentId)
        {
            DocumentReference docRef = __db.Collection("Appointments").Document(appointmentId.ToString());
            var newData = new
            {
                deleted = true
            };
            await docRef.SetAsync(newData);
            Console.WriteLine($"Marked appointment with ID: {appointmentId} as deleted.");
        }
    }
}