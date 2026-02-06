using PersonalNotesDesktopCRUD.UserInterface.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalNotesDesktopCRUD.UserInterface
{
    internal class ReadDataForm : IReadDataForm
    {
        TextBox _componentTextBox;
        ListBox _componentListBox;
        public ReadDataForm(TextBox textBox, ListBox notesListBox) 
        { 
            _componentTextBox = textBox;
            _componentListBox = notesListBox;
            
        }
        public ReadDataForm(ListBox listBoxComponent)
        {
            _componentListBox = listBoxComponent;
        }
        public string GetContent()
        {

            return _componentTextBox.Text;
        }

        public int GetSelectedNoteId()
        {

            var id = _componentListBox.SelectedIndex;

            return id;

        }

        public string GetTitle()
        {
            return _componentTextBox.Text;
        }
    }
}
