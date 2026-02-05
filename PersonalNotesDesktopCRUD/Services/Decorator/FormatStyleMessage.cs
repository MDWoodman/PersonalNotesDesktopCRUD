using PersonalNotesDesktopCRUD.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services.Decorator
{
    public abstract class FormatStyleMessage  : IFormatingStyleMessage
    {
        IFormatingStyleMessage _formatingStyleMessage;
        protected FormatStyleMessage(IFormatingStyleMessage formatingStyleMessage)
        {
            _formatingStyleMessage = formatingStyleMessage;

        }
            
        public virtual string FormatingStyleMessage(string titlecontent)
        {
            return _formatingStyleMessage.FormatingStyleMessage(titlecontent);
        }
       
    }
}
