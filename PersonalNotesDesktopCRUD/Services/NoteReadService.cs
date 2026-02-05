using PersonalNotesDesktopCRUD.Domain;
using PersonalNotesDesktopCRUD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services
{
    public class NoteReadService : @interface.INoteReadService
    {
        IReadRepositoriesService _readRepositoriesService;
        public NoteReadService(IReadRepositoriesService readRepositoriesService)
        {
            _readRepositoriesService = readRepositoriesService;
        }
        public List<Note> GetAllNotes()
        {
           return _readRepositoriesService.GetAllNotes();
        }

        public Note GetNoteById(int id)
        {
           return _readRepositoriesService.GetNoteById(id);
        }
    }
}
