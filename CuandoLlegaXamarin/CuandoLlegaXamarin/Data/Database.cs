using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CuandoLlegaXamarin.Modelos;

namespace CuandoLlegaXamarin
{
    public class Database
    { 
        static object locker = new object();
        SQLiteConnection database;

        public Database()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables
            database.CreateTable<Colectivo>();
        }

        public IEnumerable<Colectivo> GetItems()
        {
            return (from i in database.Table<Colectivo>() select i).ToList();
        }

    }
}
