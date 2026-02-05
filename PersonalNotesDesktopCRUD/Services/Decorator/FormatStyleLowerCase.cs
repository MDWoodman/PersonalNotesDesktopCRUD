using PersonalNotesDesktopCRUD.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services.Decorator
{
    public class FormatStyleLowerCase : FormatStyleMessage
    {
        IFormatingStyleMessage _formatingStyleMessage;
        public FormatStyleLowerCase( IFormatingStyleMessage formatingStyleMessage) : base(formatingStyleMessage)
        {
            _formatingStyleMessage = formatingStyleMessage;
        }
       

        public override string FormatingStyleMessage(string titlecontent)
        {
            return base.FormatingStyleMessage(titlecontent).ToLower();
        }
    }
}
