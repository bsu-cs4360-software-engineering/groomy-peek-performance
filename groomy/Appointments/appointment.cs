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
        public bool deleted { get; set; } = false; // Default value
        [FirestoreProperty]
        public Timestamp endTime { get; set; }
        [FirestoreProperty]
        public string foreignKey { get; set; } // Default value
        [FirestoreProperty]
        public string id { get; set; } // Default value
        [FirestoreProperty]
        public string location { get; set; } // Default value
        [FirestoreProperty]
        public Timestamp start { get; set; }
        [FirestoreProperty]
        public string Title { get; set; } // Default value
        [FirestoreProperty]
        public string desc { get; set; } // Default value
    }
}