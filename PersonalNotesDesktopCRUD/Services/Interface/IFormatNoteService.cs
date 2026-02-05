using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services.Interface
{
    public interface IFormatNoteService
    {
        string FormatNote(string title, string content);
    }
}
