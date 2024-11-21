using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groomy.Notes
{
    public interface notesInterface
    {
        Task createNote(string documentID, note addableNote);
        Task<note> getNote(string documentID, string noteID);

        Task deleteNote(string documentID, string noteID);

        void updateNote(note updatedNote, string noteID, string docID);

        Task<List<note>> getAllNotes(string docID);



    }
}
