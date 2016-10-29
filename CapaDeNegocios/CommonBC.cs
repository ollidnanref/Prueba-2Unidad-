using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDeDatos;

namespace CapaDeNegocios
{
    public class CommonBC
    {
        private static RegistrosBDEntities _modeloRegistroAcceso;
        public static RegistrosBDEntities ModeloRegistroAcceso
        {
            get
            {
                if(_modeloRegistroAcceso == null)
                {
                    _modeloRegistroAcceso = new RegistrosBDEntities();
                }
                return _modeloRegistroAcceso;
            }
        }

        public CommonBC()
        {

        }
    }
}
