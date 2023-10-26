using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ReservasModelo
    {
        //atritubos aplicados no bd
        public int idh;
        public int idq;
        public DateTime datainr;
        public DateTime dataoutr;
        public int nhospedesr;
        public string preçor;
        public string statusr;
        public int idr;
        //construtor da classe modelo reservas
        public ReservasModelo()
        {
            idh = 0;
            idq = 0;
            nhospedesr = 0;
            preçor = null;
            statusr = null;
            idr = 0;
        }
    }
}
