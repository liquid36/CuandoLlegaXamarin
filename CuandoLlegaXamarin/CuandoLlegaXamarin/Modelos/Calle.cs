using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuandoLlegaXamarin.Modelos
{
    [SQLite.Table("calles")]
    public class Calle
    {
        public int id { get; set; }

        [SQLite.Column("desc")]
        public string nombre { get; set; } 

    }
}
