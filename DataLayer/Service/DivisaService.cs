using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ModelViews;
using DataLayer.Repository;

namespace DataLayer.Service
{
    public class DivisaService
    {
        public List<DivisaModelView> getAll()
        {
            return DivisaRepository.Instance.getAll();
        }
        public double getChangeDivisa(DivisiaEntradaModalView divisa)
        {
            int local = 0;
            int Cambio  = 0;

            List<DivisaModelView> divisas = getAll();

            foreach (var item in divisas)
            {
                if (item.Id == divisa.Id_DivisaLocal)
                {
                    local = item.Id;
                }
                if (item.Id == divisa.Id_DivisaCambio)
                {
                    Cambio = item.Id;
                }
            }

            switch(local)
            {
                case 1:
                    {
                        return getMontoDolar(divisa.Monto,Cambio);
                    }
                case 2:
                    {
                        return getMontoEuro(divisa.Monto, Cambio);
                    }
                case 3:
                    {
                        return getMontoPeso(divisa.Monto, Cambio);
                    }

            }

            return 0;
            
        }

        private double getMontoDolar(double monto,int cambio)
        {
            if(cambio == 2 )
            {
                return 0.95 * monto;
            }
            if (cambio == 3 )
            {
                return monto * 55.30;
            }

            return monto;

        }
               
        public double getMontoEuro(double monto, int cambio)
        {

            if (cambio == 1)
            {
                return 1.06 * monto;
            }
            if (cambio == 3)
            {
                return monto * 58.37;
            }

            return monto;
            
        }
        public double getMontoPeso(double monto, int cambio)
        {

            if (cambio == 1)
            {
                return  monto * 0.018;
            }
            if (cambio == 2)
            {
                return monto * 0.017;
            }

            return monto;

        }


    }
}
