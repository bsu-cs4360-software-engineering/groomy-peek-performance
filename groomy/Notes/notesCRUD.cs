using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using groomy.services;

namespace groomy.Notes
{
    public class notesCRUD
    {
        private FirestoreDb __db;
        private string __collectionName;
        public notesCRUD(FirestoreDb db, string collectionName)
        {
            __db = db;
        }
        public async Task createNote(string documentId, note addableNote)
        {
            CollectionReference collectionDoc = __db.Collection(__collectionName).Document(documentId).Collection("notes");
            DocumentReference docRef = collectionDoc.Document();
            addableNote.id = docRef.Id;
            addableNote.dateCreated = Timestamp.FromDateTime(DateTime.UtcNow);
            await docRef.SetAsync(addableNote);
        }
    }
}
