using PersonalNotesDesktopCRUD.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Services.Decorator
{
    public class FormatStyleAddTags : FormatStyleMessage
    {
      
        public FormatStyleAddTags(IFormatingStyleMessage formatingStyleMessage) : base(formatingStyleMessage)
        {
           
        }

        public override string FormatingStyleMessage(string titlecontent)
        {
            var t = base.FormatingStyleMessage(titlecontent).Split(new string[] { "---" } , StringSplitOptions.RemoveEmptyEntries)[0];
            var c = base.FormatingStyleMessage(titlecontent).Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries)[1];
            return "<title>" + t + "</title>" + "---" + "<content>" + c + "</content>";
        }
    }
}
