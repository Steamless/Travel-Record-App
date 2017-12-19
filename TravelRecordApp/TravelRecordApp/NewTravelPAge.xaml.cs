using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPAge : ContentPage
    {
        public NewTravelPAge()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post() //inserting a Table
            {
                Experience = experienceEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>(); //Generics Notation = Type that this method will be using when excecution, and is more secure when creating other elements
                int rows = conn.Insert(post); //is going to get the type for that object and will know then to wich table will be inserted
                
                //USE "conn.Close();" only when not using "using(SQLiteConnection...)", because of the "Dispose()" //we have to close a connection after opening before opening anopther connection

                if (rows > 0)                
                    DisplayAlert("Success", "Experience succesfully inserted", "ok"); //Title, message, cancel button                                
                else                
                    DisplayAlert("Failure", "Experience failed to be inserted", "ok");  
            }
        
        
        }
    }
}