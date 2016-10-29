using System;
using System.Linq;

using CapaDeDatos;

namespace CapaDeNegocios
{
    public class RegistroAcceso
    {
        public int Id { get; set; }
        public String Patente { get; set; }
        public String Marca { get; set; }
        public String Color { get; set; }
        public String TipoPersonal { get; set; }
        public String NombrePersonal { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        

        public RegistroAcceso() {
            this.Init();
        }

        private void Init()
        {
            this.Id = 0;
            this.Patente = String.Empty;
            this.Marca = String.Empty;
            this.Color = String.Empty;
            this.TipoPersonal = String.Empty;
            this.NombrePersonal = String.Empty;
            this.FechaIngreso = new DateTime();
        }

        public bool Read()
        {
            try
            {
                int miId = ( from r in CommonBC.ModeloRegistroAcceso.RegistroAcceso
                             where r.Patente == this.Patente
                             orderby r.FechaIngreso ascending
                             select r.Id).Last();

                CapaDeDatos.RegistroAcceso registroAcceso = CommonBC.ModeloRegistroAcceso.RegistroAcceso.First(f => f.Id == miId);


                this.Id = registroAcceso.Id;
                this.Marca = registroAcceso.Marca;
                this.Color = registroAcceso.Color;
                this.TipoPersonal = registroAcceso.TipoPersonal;
                this.NombrePersonal = registroAcceso.NombrePersonal;
                this.FechaIngreso = registroAcceso.FechaIngreso;
                //if (registroAcceso.FechaSalida != null) {
                    this.FechaSalida = (DateTime)registroAcceso.FechaSalida;
                //}

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Create()
        {
            try
            {

                    CapaDeDatos.RegistroAcceso registroAcceso = new CapaDeDatos.RegistroAcceso();

                    registroAcceso.Patente = this.Patente;
                    registroAcceso.Marca = this.Marca;
                    registroAcceso.Color = this.Color;
                    registroAcceso.TipoPersonal = this.TipoPersonal;
                    registroAcceso.NombrePersonal = this.NombrePersonal;
                    registroAcceso.FechaIngreso = this.FechaIngreso;

                    CommonBC.ModeloRegistroAcceso.RegistroAcceso.Add(registroAcceso);
                    CommonBC.ModeloRegistroAcceso.SaveChanges();
                
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                CapaDeDatos.RegistroAcceso registro = CommonBC.ModeloRegistroAcceso.RegistroAcceso.Find(this.Id);

                CommonBC.ModeloRegistroAcceso.RegistroAcceso.Remove(registro);
                CommonBC.ModeloRegistroAcceso.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                int miId = (from r in CommonBC.ModeloRegistroAcceso.RegistroAcceso
                            where r.Patente == this.Patente
                            orderby r.FechaIngreso
                            select r.Id).Last();

                CapaDeDatos.RegistroAcceso registroAcceso = CommonBC.ModeloRegistroAcceso.RegistroAcceso.First(f => f.Id == miId);

                registroAcceso.Marca = this.Marca;
                registroAcceso.Color = this.Color;
                registroAcceso.TipoPersonal = this.TipoPersonal;
                registroAcceso.NombrePersonal = this.NombrePersonal;
                registroAcceso.FechaIngreso = this.FechaIngreso;
                registroAcceso.FechaSalida = this.FechaSalida;

                CommonBC.ModeloRegistroAcceso.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
