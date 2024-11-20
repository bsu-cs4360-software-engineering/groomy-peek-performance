using Google.Cloud.Firestore;

namespace groomy.Pricing
{
    [FirestoreData]
    public class Service
    {
        [FirestoreProperty("name")]
        public string Name { get; set; }

        [FirestoreProperty("desc")]
        public string Desc { get; set; }

        [FirestoreProperty("price")]
        public double Price { get; set; }

        [FirestoreProperty("id")]
        public string Id { get; set; }

        [FirestoreProperty("deleted")]
        public bool Deleted { get; set; }
    }
}