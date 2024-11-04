using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groomy.Customers
{
    [FirestoreData]
    public class customer
    {
        [FirestoreProperty("email")]
        public string email { get; set; }
        [FirestoreProperty("fName")]
        public string fName { get; set; }
        [FirestoreProperty("lName")]
        public string lName { get; set; }
        [FirestoreProperty("id")]
        public int id { get; set; }
        [FirestoreProperty("deleted")]
        public bool deleted { get; set; }
        [FirestoreProperty("phoneNumber")]
        public string phoneNumber { get; set; }
        [FirestoreProperty("address")]
        public string address { get; set; }
    }
}
