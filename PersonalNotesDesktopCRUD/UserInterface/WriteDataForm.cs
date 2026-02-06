using PersonalNotesDesktopCRUD.UserInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalNotesDesktopCRUD.UserInterface
{
    public class WriteDataForm : IWriteDataForm
    {
        private readonly TextBox _titleTextBox;
        private readonly TextBox _contentTextBox;
        private readonly ListBox _notesListBox;
        public WriteDataForm(TextBox textBox, ListBox notesListBox)
        {
            _titleTextBox = textBox;
       
            _notesListBox = notesListBox;
        }
        public void SetTitle(string title)
        {
            _titleTextBox.Text = title;
        }
        public void SetContent(string content)
        {
            _contentTextBox.Text = content;
        }
        public void SetMessageToListBox(string titlecontent)
        {
            _notesListBox.Items.Add(titlecontent);
        }

        public void RemoveMessageFromListBox(int index)
        {
          _notesListBox.Items.RemoveAt(index);
        }
    }
}
