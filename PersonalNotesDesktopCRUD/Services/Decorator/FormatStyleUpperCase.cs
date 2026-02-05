using PersonalNotesDesktopCRUD.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services.Decorator
{
    public class FormatStyleUpperCase : FormatStyleMessage
    {
        public FormatStyleUpperCase(IFormatingStyleMessage formatingStyleMessage) : base(formatingStyleMessage)
        {
        }

        public override string FormatingStyleMessage(string titlecontent)
        {
            return base.FormatingStyleMessage(titlecontent).ToUpper();
           
        }
    }
}
