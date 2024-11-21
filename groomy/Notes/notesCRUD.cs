using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using groomy.services;

namespace groomy.Notes
{
    public class notesCRUD : notesInterface
    {
        private FirestoreDb __db;
        private string __collectionName;
        public notesCRUD(FirestoreDb db, string collectionName)
        {
            __collectionName = collectionName;
            __db = db;
        }
        public async Task createNote(string documentId, note addableNote)
        {
            CollectionReference collectionDoc = __db.Collection(__collectionName).Document(documentId).Collection("notes");
            DocumentReference docRef = collectionDoc.Document();
            addableNote.id = docRef.Id;
            addableNote.dateCreated = Timestamp.FromDateTime(DateTime.UtcNow);
            addableNote.deleted = false;
            await docRef.SetAsync(addableNote);
        }
        public async Task<note> getNote(string documentID, string noteID)
        {
            CollectionReference collectionReference = __db.Collection(__collectionName).Document(documentID).Collection("notes");
            DocumentReference docRef = collectionReference.Document(noteID);
            var noteSnapshot = await docRef.GetSnapshotAsync();
            var noteToReturn = noteSnapshot.ConvertTo<note>();
            return noteToReturn;
        }
        public async void deleteNote(string documentID, string noteID)
        {
            CollectionReference collectionReference = __db.Collection(__collectionName).Document(documentID).Collection("notes");
            DocumentReference docRef = collectionReference.Document(noteID);
            var noteSnapshot = await docRef.GetSnapshotAsync();
            if (noteSnapshot.Exists)
            {
                var note = noteSnapshot.ConvertTo<note>();
                note.deleted = true;
                await docRef.SetAsync(note, SetOptions.MergeAll);
            }
        }
        public async void updateNote(note updatedNote, string noteID, string docID)
        {
            CollectionReference collectionDoc = __db.Collection(__collectionName).Document(docID).Collection("notes");
            DocumentReference docRef = collectionDoc.Document(noteID);

            // First, retrieve the existing note to preserve the original dateCreated
            var existingNoteSnapshot = await docRef.GetSnapshotAsync();
            var existingNote = existingNoteSnapshot.ConvertTo<note>();

            // Preserve the original dateCreated
            updatedNote.dateCreated = existingNote.dateCreated;

            updatedNote.id = docRef.Id;
            await docRef.SetAsync(updatedNote, SetOptions.MergeAll);
        }
        public async Task<List<note>> getAllNotes(string docID)
        {
            CollectionReference collectionDoc = __db.Collection(__collectionName).Document(docID).Collection("notes");
            List<note> notes = new List<note>();
            var snapshots = await collectionDoc
                .OrderByDescending("dateCreated")
                .GetSnapshotAsync();

            foreach (var snapshot in snapshots)
            {
                var note = snapshot.ConvertTo<note>();
                // Convert UTC Firestore timestamp to local DateTime
                notes.Add(note);
            }
            return notes;
        }

    }
}
