using PersonalNotesDesktopCRUD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services
{
    public class NoteWriteService : @interface.INoteWriteService
    {
        IWriteRepositoryService _writeRepositoryService;
        public NoteWriteService(IWriteRepositoryService writeRepositoryService) 
        { 
            _writeRepositoryService = writeRepositoryService;
        }
        public void AddNote(string title, string content)
        {
            _writeRepositoryService.AddNote(title, content);

        }

        public void DeleteNote(int id)
        {
          _writeRepositoryService.DeleteNote(id);
        }
    }
}
