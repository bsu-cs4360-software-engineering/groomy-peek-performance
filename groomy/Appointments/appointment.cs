using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groomy.Appointments
{
    [FirestoreData]
    public class appointment
    {
        [FirestoreProperty]
        public bool Deleted { get; set; } = false; // Default value
        [FirestoreProperty]
        public Timestamp EndTime { get; set; }
        [FirestoreProperty]
        public int ForeignKey { get; set; } = 0; // Default value
        [FirestoreProperty]
        public int Id { get; set; } = 0; // Default value
        [FirestoreProperty]
        public string Location { get; set; } = ""; // Default value
        [FirestoreProperty]
        public Timestamp Start { get; set; }
        [FirestoreProperty]
        public string Title { get; set; } = "potato"; // Default value
    }
}