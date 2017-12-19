using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelRecordApp.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement] //Defining SQLite atributes  - Autoincrement adds 1 to the Id
        public int Id { get; set; }

        [MaxLength(250)] //Maximum length of characters
        public string Experience { get; set; }
    }
}
