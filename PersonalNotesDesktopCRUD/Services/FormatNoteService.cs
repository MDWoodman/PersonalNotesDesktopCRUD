using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services
{
    public class FormatNoteService : IFormatNoteService
    {
        public string FormatNoteForListBox(string title, string content)
        {
            return $"{title}: {content}";
        }
    }
}
