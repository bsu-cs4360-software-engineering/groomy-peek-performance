using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groomy.Notes
{
    [FirestoreData]
    public class note
    {
        [FirestoreProperty("title")]
        public string title { get; set; }

        [FirestoreProperty("dateCreated")]
        public Timestamp dateCreated { get; set; }

        [FirestoreProperty("desc")]
        public string desc { get; set; }

        [FirestoreProperty("id")]
        public string id { get; set; }

    }
}
