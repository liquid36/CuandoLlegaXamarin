using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuandoLlegaXamarin.Modelos
{
    [SQLite.Table("colectivos")]
    public class Colectivo
    {
        public int id { get; set; }

        [SQLite.Column("name")]
        public string nombre { get; set; }

        public string bandera { get; set; }

        public string linea { get; set; }

        public int cl { get; set; }

    }
}
