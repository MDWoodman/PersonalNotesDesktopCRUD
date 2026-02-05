using PersonalNotesDesktopCRUD.Repositories.Interfaces;
using PersonalNotesDesktopCRUD.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services
{
    public class FormatingStyleMessage : IFormatNoteService
    {
       IFormatingStyleMessage _formatingStyleMessage;

        public FormatingStyleMessage(IFormatingStyleMessage formatingStyleMessage)
        {
            _formatingStyleMessage = formatingStyleMessage;
        }
        public string FormatNote(string title, string content)
        {
            var titlecontent = title + "---" + content;
            return _formatingStyleMessage.FormatingStyleMessage(titlecontent);
         
        }
    }
}
