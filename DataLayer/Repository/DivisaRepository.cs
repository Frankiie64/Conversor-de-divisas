using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ModelViews;

namespace DataLayer.Repository
{
    public sealed class DivisaRepository
    {
        public static DivisaRepository Instance { get; } = new();

        private List<DivisaModelView> divisasList = new();

        private DivisaRepository()
        {

        }

        public List<DivisaModelView> getAll()
        {
            divisasList.Clear();

            DivisaModelView dolar = new()
            {
                Id = 1 ,
                 Moneda = "Dolar estadounidense"

            };
            DivisaModelView euro = new()
            {
                Id = 2,
                Moneda = "Euro"

            };
            DivisaModelView peso = new()
            {
                Id = 3,
                Moneda = "Peso dominicano"

            };

            divisasList.Add(dolar);
            divisasList.Add(euro);
            divisasList.Add(peso);

            return divisasList;
        }


    }
}
