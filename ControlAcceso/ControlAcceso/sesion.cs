using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAcceso
{
    class sesion
    {
        static String usuario;

        public void setUsuario(String usu)
        {
            usuario = usu;
        }

        public String getUsuario()
        {
            return usuario;
        }


    }
}
