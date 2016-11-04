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
            database.CreateTable<Calle>();
            database.CreateTable<Parada>();
        }

        /*
         * 
         * COLECTIVOS QUERYS
         * 
         */

        public Colectivo GetColectivo(int id)
        {
            lock (locker)
            {
                return database.Table<Colectivo>().FirstOrDefault(colectivo => colectivo.id == id);
            }
        }

        public IEnumerable<Colectivo> GetColectivos()
        {
            lock (locker)
            {
                return (from i in database.Table<Colectivo>() select i).ToList();
            }
        }

        public IEnumerable<Colectivo> GetColectivos(int calle, int intereccion)
        {
            lock (locker)
            {
                return database.Query<Colectivo>(
                        @"select colectivos.* from paradas 
                          inner join colectivos on colectivos.id = paradas.idColectivo
                          where paradas.idCalle = ? and paradas.idInter = ?
                          group by paradas.idColectivo 
                          order by colectivos.name", calle ,intereccion);
            }
        }

        /*
         * 
         * CALLES QUERYS
         * 
         */

        public Calle GetCalle(int id)
        {
            lock (locker)
            {
                return database.Table<Calle>().FirstOrDefault(calle => calle.id == id);
            }
        }
        
        public IEnumerable<Calle> GetCalles(int ? colectivo = null, string name = "")
        {
            lock (locker)
            {
                if (colectivo != null)
                {
                    return database.Query<Calle>(
                        @"select calles.* from paradas 
                          inner join calles on calles.id = paradas.idCalle 
                          where calles.desc like ? and paradas.idColectivo = ?  
                          group by paradas.idCalle 
                          order by calles.desc", '%' + name + '%', colectivo.Value);
                }
                else
                {
                    return database.Query<Calle>(
                        @"select calles.* from paradas 
                          inner join calles on calles.id = paradas.idCalle 
                          where calles.desc like ?   
                          group by paradas.idCalle 
                          order by calles.desc", '%' + name + '%');
                }
            }
        }

        public IEnumerable<Calle> GetIntersecciones(int ? colectivo = null, int ? calle = null, string name = "")
        {
            lock (locker)
            {
                if (colectivo != null)
                {
                    return database.Query<Calle>(
                        @"select calles.* from paradas 
                      inner join calles on calles.id = paradas.idInter 
                      where calles.desc like ? and paradas.idColectivo = ?  and paradas.idCalle = ?
                      group by paradas.idInter 
                      order by calles.desc", '%' + name + '%', colectivo, calle);
                } else
                {
                    return database.Query<Calle>(
                        @"select calles.* from paradas 
                      inner join calles on calles.id = paradas.idInter 
                      where calles.desc like ? and paradas.idCalle = ?
                      group by paradas.idInter 
                      order by calles.desc", '%' + name + '%', calle);
                }
            }
        }
 
        /*
         * 
         * PARADAS QUERYS
         * 
         */

        public IEnumerable<Parada> GetParadas()
        {
            lock (locker)
            {
                return (from i in database.Table<Parada>() select i).ToList();
            }
        }

    }
}
