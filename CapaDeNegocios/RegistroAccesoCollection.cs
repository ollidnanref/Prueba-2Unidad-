using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class RegistroAccesoCollection
    {
        private List<RegistroAcceso> GenerarListado(List<CapaDeDatos.RegistroAcceso> listaRegistroAcceso)
        {
            List<CapaDeNegocios.RegistroAcceso> registroAccesos = new List<RegistroAcceso>();

            foreach (CapaDeDatos.RegistroAcceso registro in listaRegistroAcceso )
            {
                CapaDeNegocios.RegistroAcceso reg = new RegistroAcceso();

                if(registro.FechaSalida == null)
                {
                    reg.Patente = registro.Patente;
                    reg.Marca = registro.Marca;
                    reg.Color = registro.Color;
                    reg.TipoPersonal = registro.TipoPersonal;
                    reg.NombrePersonal = registro.NombrePersonal;
                    reg.FechaIngreso = registro.FechaIngreso;

                    registroAccesos.Add(reg);
                }
            }

            return registroAccesos;
        }

        public List<RegistroAcceso> ReadAll()
        {
            var accesos = CommonBC.ModeloRegistroAcceso.RegistroAcceso;
            return GenerarListado(accesos.ToList());
        }


        public int RegistrosPorDia(int ano, int mes, int dia)
        {
            return CommonBC.ModeloRegistroAcceso.RegistroAcceso.Count(b => b.FechaIngreso.Day == dia && b.FechaIngreso.Month == mes && b.FechaIngreso.Year == ano);
        }

        public int TotalDocentes()
        {
            return CommonBC.ModeloRegistroAcceso.RegistroAcceso.Count(r => r.TipoPersonal == "Docente");
        }

        public int TotalAlumnos()
        {
            return CommonBC.ModeloRegistroAcceso.RegistroAcceso.Count(r => r.TipoPersonal == "Alumno");
        }

        public int RegistrosRangoHoras(int mayor, int menor)
        {
            return CommonBC.ModeloRegistroAcceso.RegistroAcceso.Count(r => r.FechaIngreso.Hour >= menor && r.FechaIngreso.Hour <= mayor);
        }

        public int ListaSegunTipo(String tipo)
        {
            return CommonBC.ModeloRegistroAcceso.RegistroAcceso.Count( r => r.FechaSalida == null && r.TipoPersonal == tipo );

        }
    }
}
