using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class QuartosModelo
    {
        //atritubos aplicados no bd
        public string nomeq;
        public string capacidadeq;
        public float preçoq;
        public string status_id;
        public int idq;
        //construtor da classe modelo usuario
        public QuartosModelo()
        {
            nomeq = null;
            capacidadeq = null;
            preçoq = 0;
            status_id = null;
            idq = 0;//inicializo com 0
        }
    }
}
