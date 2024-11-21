using Microsoft.VisualStudio.TestTools.UnitTesting;
using groomy.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using groomy.services;
using Google.Cloud.Firestore;

namespace groomy.Notes.Tests
{
    [TestClass()]
    public class notesCRUDTests
    {
        private FirestoreDb db;
        private notesCRUD createNotes;
        private string appointmentId = "011Gdx3GvZ9vs0Bsatdg"; // Use a single appointment ID for all tests
        private List<string> createdNoteIds = new List<string>(); // To keep track of created notes

        [TestInitialize]
        public async Task Setup()
        {
            db = firebaseConfig.Instance.getFirestoreDB();
            createNotes = new notesCRUD(db, "Appointments");
            // Optionally, create the appointment if it doesn't exist
            // await createNotes.createAppointmentIfNotExists(appointmentId);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            // Delete all created notes
            foreach (var noteId in createdNoteIds)
            {
                 createNotes.deleteNote(appointmentId, noteId);
            }
            // Optionally delete the appointment if needed
            // await createNotes.deleteAppointment(appointmentId);
        }

        [TestMethod()]
        public async Task createNoteTest()
        {
            note addNote = new note() { title = "testtitle", desc = "hi" };
            await createNotes.createNote(appointmentId, addNote);
            createdNoteIds.Add(addNote.id); // Track the created note ID
        }

        [TestMethod()]
        public async Task getNoteTest()
        {
            note addNote = new note() { title = "testtitle", desc = "hi" };
            await createNotes.createNote(appointmentId, addNote);
            createdNoteIds.Add(addNote.id); // Track the created note ID

            note zbele = await createNotes.getNote(appointmentId, addNote.id);
            Assert.IsNotNull(zbele);
        }

        [TestMethod()]
        public async Task deleteNoteTest()
        {
            note addNote = new note() { title = "testtitle", desc = "hi" };
            await createNotes.createNote(appointmentId, addNote);
            createdNoteIds.Add(addNote.id); // Track the created note ID

            await createNotes.deleteNote(appointmentId, addNote.id);
            note zbele = await createNotes.getNote(appointmentId, addNote.id);
            Assert.IsTrue(zbele.deleted);
        }

        [TestMethod()]
        public async Task updateNoteTest()
        {
            note addNote = new note() { title = "Sample Title", desc = "This is a sample description." };
            await createNotes.createNote(appointmentId, addNote);
            createdNoteIds.Add(addNote.id); // Track the created note ID

            note updatedNote = new note { title = "Updated Title", desc = "Updated description." };
            createNotes.updateNote(updatedNote, addNote.id, appointmentId);

            note zbele = await createNotes.getNote(appointmentId, addNote.id);
            Assert.IsNotNull(zbele);
            Assert.AreNotEqual(zbele.title, updatedNote.title);
            Assert.AreNotEqual(zbele.desc, updatedNote.desc);
        }

        [TestMethod()]
        public async Task getAllTest()
        {
            // Create and add some sample notes to the Firestore for testing
            note note1 = new note { title = "First Note", desc = "This is the first note." };
            note note2 = new note { title = "Second Note", desc = "This is the second note." };

            await createNotes.createNote(appointmentId, note1);
            createdNoteIds.Add(note1.id); // Track the created note ID
            await createNotes.createNote(appointmentId, note2);
            createdNoteIds.Add(note2.id); // Track the created note ID

            // Act
            List<note> allNotes = await createNotes.getAllNotes(appointmentId);

            // Assert
            Assert.IsNotNull(allNotes);
            Assert.IsTrue(allNotes.Any(n => n.title == note1.title && n.desc == note1.desc));
            Assert.IsTrue(allNotes.Any(n => n.title == note2.title && n.desc == note2.desc));
        }
    }
}