using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuandoLlegaXamarin.Modelos
{
    [SQLite.Table("geoposition")]
    public class Geoposition
    {
        public int parada { get; set; }

        public double lat { get; set; }
        public double lng { get; set; }

        public double sin_lat { get; set; }
        public double sin_lng { get; set; }

        public double cos_lat { get; set; }
        public double cos_lng { get; set; }
    }
}
