using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services.@interface
{
    public interface INoteReadService
    {
        List<Domain.Note> GetAllNotes();
        Domain.Note GetNoteById(int id);

    }
}
