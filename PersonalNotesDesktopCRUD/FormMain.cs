using PersonalNotesDesktopCRUD.Repositories.Interfaces;
using PersonalNotesDesktopCRUD.Services;
using PersonalNotesDesktopCRUD.Services.Decorator;
using PersonalNotesDesktopCRUD.Services.@interface;
using PersonalNotesDesktopCRUD.Services.Interface;
using PersonalNotesDesktopCRUD.UserInterface;
using PersonalNotesDesktopCRUD.UserInterface.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalNotesDesktopCRUD
{
    public partial class FormMain : Form
    {
        private readonly Repositories.IReadRepositoriesService readRepositoriesService;
        private readonly Repositories.IWriteRepositoryService writeRepositoryService;
        private readonly IFormatNoteService formatNoteService;
        private readonly INoteReadService noteReadService;
        private readonly INoteWriteService noteWriteService;
        public FormMain()
        {
            InitializeComponent();
        }





        private void addButton_Click(object sender, EventArgs e)
        {
            IReadDataForm readDataForm = new ReadDataForm(titleTextBox);
            var title = readDataForm.GetTitle();

            readDataForm = new ReadDataForm(contentTextBox);
            var content = readDataForm.GetContent();
           
            noteWriteService.AddNote(title,content);

            IWriteDataForm writeDataForm = new WriteDataForm(titleTextBox, contentTextBox, notesListBox);
            writeDataForm.SetMessageToListBox(formatNoteService.FormatNoteForListBox(title, content));

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            IReadDataForm readDataForm = new ReadDataForm(notesListBox);
            INoteWriteService noteWriteService = new NoteWriteService(writeRepositoryService);

            var id = readDataForm.GetSelectedNoteId();
            if(id < 0) return;

            noteWriteService.DeleteNote(id);

        }
    }
}
