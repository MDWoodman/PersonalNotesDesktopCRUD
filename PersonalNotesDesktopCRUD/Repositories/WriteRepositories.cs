using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Repositories
{
    public class WriteRepositories : IWriteRepositoryService
    {
        private readonly  NoteDbContext _context;
        public WriteRepositories(NoteDbContext noteDbContext) 
        {
            _context = noteDbContext;
        }
        async public void AddNote(string title, string content)
        {
           _context.Notes.Add(new Domain.Note
            {
                Title = title,
                Content = content,
                CreatedAt = DateTime.Now
            });
            await _context.SaveChangesAsync();
        }

        async public void DeleteNote(int id)
        {
           _context.Notes.Remove(_context.Notes.FirstOrDefault(n => n.Id == id));
           await _context.SaveChangesAsync();
        }
    }
}
