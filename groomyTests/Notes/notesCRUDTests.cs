using Microsoft.VisualStudio.TestTools.UnitTesting;
using groomy.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groomy.services;
using Google.Cloud.Firestore.V1;
using Google.Cloud.Firestore;

namespace groomy.Notes.Tests
{
    [TestClass()]
    public class notesCRUDTests
    {
        [TestMethod()]
        public async Task createNoteTest()
        {
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD createNotes = new notesCRUD(db, "Appointments");
            note addNote = new note() {title = "testtitle", desc = "hi"};
            await createNotes.createNote("011Gdx3GvZ9vs0Bsatdg",addNote);
        }
    }
}