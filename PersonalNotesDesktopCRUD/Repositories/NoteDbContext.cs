using PersonalNotesDesktopCRUD.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesDesktopCRUD.Repositories
{
    public class NoteDbContext : DbContext
    {
        public NoteDbContext() : base("name=NoteDbContext")
        {



        }
        public virtual DbSet<Note> Notes { get; set; }

        protected override  void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().ToTable("Notes");
            modelBuilder.Entity<Note>().HasKey(n => n.Id);
            modelBuilder.Entity<Note>().Property(n => n.Title).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Note>().Property(n => n.Content).IsRequired();
            modelBuilder.Entity<Note>().Property(n => n.CreatedAt).IsRequired();
        }

        
         

       
    }
}
