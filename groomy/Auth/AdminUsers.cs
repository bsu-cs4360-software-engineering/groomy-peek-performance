using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groomy.Auth
{
    [FirestoreData]
    public class AdminUser
    {
        [FirestoreProperty("email")]
        public string email { get; set; }
        [FirestoreProperty("fName")]
        public string fName { get; set; }
        [FirestoreProperty("lName")]
        public string lName { get; set; }
        [FirestoreProperty("password")]
        public string password { get; set; }
    }
}
