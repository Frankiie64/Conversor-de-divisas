using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ModelViews
{
    public class DivisiaEntradaModalView
    {
        public int Id_DivisaCambio { get; set; }
        public int Id_DivisaLocal { get; set; }
        public double Monto { get; set; }
        public double Cambiado { get; set; }
    }
}
