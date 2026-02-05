using PersonalNotesDesktopCRUD.UserInterface.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.UserInterface
{
    internal class ReadDataForm : IReadDataForm
    {
        IComponent _component;
        ReadDataForm(IComponent component) 
        { _component = component;
        }
        public string GetContent()
        {
            throw new NotImplementedException();
        }

        public string GetTitle()
        {
            throw new NotImplementedException();
        }
    }
}
