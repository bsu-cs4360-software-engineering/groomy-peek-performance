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
        Task createNotes(string documentID, note addableNote);
        Task<note> getNote(string documentID, string noteID);

        Task<note> deleteNote(string documentID, string noteID);

        Task<note> updateNote(note updatedNote);

        Task<List<note>> getAllNotes();



    }
}
