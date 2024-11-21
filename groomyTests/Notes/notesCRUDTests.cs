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

        [TestMethod()]
        public async Task getNoteTest()
        {
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD createNotes = new notesCRUD(db, "Appointments");
            note zbele = await createNotes.getNote("011Gdx3GvZ9vs0Bsatdg", "1Au7pC2WIHiAg9AAUjrd");
            Console.WriteLine(zbele.id);
            Assert.IsNotNull(zbele);
        }

        [TestMethod()]
        public async Task deleteNoteTest()
        {
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD createNotes = new notesCRUD(db, "Appointments");
            createNotes.deleteNote("011Gdx3GvZ9vs0Bsatdg", "qMQQIxI2ADo9MayxIhBk");
            note zbele = await createNotes.getNote("011Gdx3GvZ9vs0Bsatdg", "qMQQIxI2ADo9MayxIhBk");
            Assert.IsNull(zbele);
        }
        [TestMethod()]
        public async Task updateNoteTest()
        {
            note newNote = new note

            { 
                title = "Sample Title",
                desc = "This is a sample description.",
            };
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD createNotes = new notesCRUD(db, "Appointments");
            createNotes.updateNote(newNote, "EUtWD6YGRnktSVGBUi5b", "011Gdx3GvZ9vs0Bsatdg");
            note zbele = await createNotes.getNote("011Gdx3GvZ9vs0Bsatdg", "EUtWD6YGRnktSVGBUi5b");
            Console.WriteLine(zbele.title == newNote.title);
            Console.WriteLine(zbele.desc == newNote.desc);
            Assert.IsTrue(zbele.title == newNote.title && zbele.desc == newNote.desc);
        }
        [TestMethod()]
        public async Task getAllTest()
        {
            // Arrange
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD createNotes = new notesCRUD(db, "Appointments");

            // Create and add some sample notes to the Firestore for testing
            note note1 = new note { title = "First Note", desc = "This is the first note." };
            note note2 = new note { title = "Second Note", desc = "This is the second note." };

            await createNotes.createNote("tILzmrwvQQHarAoVs6jo", note1);
            await createNotes.createNote("tILzmrwvQQHarAoVs6jo", note2);

            // Act
            List<note> allNotes = await createNotes.getAllNotes("tILzmrwvQQHarAoVs6jo");

            // Assert
            Assert.IsNotNull(allNotes);
            Assert.IsTrue(allNotes.Any(n => n.title == note1.title && n.desc == note1.desc));
            Assert.IsTrue(allNotes.Any(n => n.title == note2.title && n.desc == note2.desc));
        }

    }
}