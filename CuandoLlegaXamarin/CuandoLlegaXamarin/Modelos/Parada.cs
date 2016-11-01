using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuandoLlegaXamarin.Modelos
{
    [SQLite.Table("paradas")]
    public class Parada
    {
        [SQLite.Column("idColectivo")]
        public int colectivo { get; set; }

        [SQLite.Column("idCalle")]
        public int calle { get; set; }

        [SQLite.Column("idInter")]
        public int interseccion { get; set; }

        public int parada { get; set; }

        [SQLite.Column("desc")]
        public string destino { get; set; }
    }
}
