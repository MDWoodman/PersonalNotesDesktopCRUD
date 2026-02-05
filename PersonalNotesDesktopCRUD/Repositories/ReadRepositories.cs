using PersonalNotesDesktopCRUD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Repositories
{
    public class ReadRepositories : IReadRepositoriesService
    {
        private readonly NoteDbContext noteDbContext;
        public ReadRepositories(NoteDbContext _context)
        {
            noteDbContext = _context;
        }
        public List<Note> GetAllNotes()
        {
            return noteDbContext.Notes.ToList();
        }

        public Note GetNoteById(int id)
        {
            var note = noteDbContext.Notes.FirstOrDefault(n => n.Id == id);
            return note;
        }
    }
}
