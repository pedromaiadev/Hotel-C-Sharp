using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //objeto usuário
    public class UsuarioModelo
    {
        //atritubos aplicados no bd
        public int idusuario;
        public string nome;
        public string senha;
        public int idperfil;//inclui o perfil usuario
        public string email;
        public string fotousu;
        //construtor da classe modelo usuario
        public UsuarioModelo() {
            nome = null;
            senha= null;
            idperfil = 0;//inicializo com 0
            email = null;
            fotousu = null;
    }
    }
}
