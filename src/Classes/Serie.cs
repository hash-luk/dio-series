using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_series.src.Classes
{
    public class Serie : BaseEntity
    {
        private Genre Genre;
        private string Title;
        private string Description;
        private int Year;
        private bool Deleted;

        public Serie(int id, Genre genre,string title, string description, int year) {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }

        public override string ToString() {
            return $"ID: {this.Id} \nGenre: {this.Genre} \nTitle: {this.title} \nDescription: {this.Description} \nYear: {this.Year}";
        }

        public string ReturnTitle() {
            return this.Title;
        }

        public int ReturnID() {
            return this.Id;
        }

        public void Delete() {
            this.Deleted = true;
        }
    }
}