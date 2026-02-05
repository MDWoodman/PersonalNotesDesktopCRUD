using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Repositories
{
    public interface IWriteRepositoryService
    {
        void AddNote(string title, string content);
        void DeleteNote(int id);
    }
}
