using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.UserInterface.Interface
{
    public interface IWriteDataForm
    {
        void SetTitle(string title);
        void SetContent(string content);
        void SetMessageToListBox(string titlecontent);

        void RemoveMessageFromListBox(int index);
    }
}
