using PersonalNotesDesktopCRUD.Services.@interface;
using PersonalNotesDesktopCRUD.Services.Interface;
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
            titleTextBox.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
