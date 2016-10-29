using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaDeNegocios;

namespace CapaDePresentaciones
{
    public partial class IngresoDeRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlTipoPersonal.Items.Add("Docente");
                ddlTipoPersonal.Items.Add("Alumno");
            }
        }

        protected void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroAcceso registro = new RegistroAcceso();

                registro.Patente = txtPatente.Text;
                registro.Read();

                if (registro.FechaSalida == null)
                {
                    lblMensaje.Text = "Vehiculo se encuentra en el estacionamiento";
                }
                else
                {
                    registro.Patente = txtPatente.Text;
                    registro.Marca = txtMarca.Text;
                    registro.Color = txtColor.Text;
                    registro.TipoPersonal = ddlTipoPersonal.SelectedValue;
                    registro.NombrePersonal = txtNombrePersonal.Text;
                    registro.FechaIngreso = DateTime.Parse(txtFechaIngreso.Text);

                    registro.Create();
                    lblMensaje.Text = "Registro ingresado correctamente";
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al ingresar el registro (Excepcion: " + ex.Message + ").";
                LimpiarControles();
            }

            
        }

        

        protected void btnConsultarVehiculo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            try
            {
                RegistroAcceso registro = new RegistroAcceso();
                registro.Patente = txtPatente.Text;

                if(!registro.Read())
                {
                    lblMensaje.Text = "Vehiculo no se encuentra en el estacionamiento";
                    LimpiarControles();
                }
                else
                {
                    txtMarca.Text = registro.Marca;
                    txtColor.Text = registro.Color;
                    if(registro.TipoPersonal.Equals("Docente"))
                    {
                        ddlTipoPersonal.SelectedIndex = 0;
                    }
                    else
                    {
                        ddlTipoPersonal.SelectedIndex = 1;
                    }
                    
                    txtNombrePersonal.Text = registro.NombrePersonal;
                    txtFechaIngreso.Text = registro.FechaIngreso.ToString("dd-MM-yyyy HH:MM");
                    if(registro.FechaSalida.ToString("dd-MM-yyyy HH:MM") == "01-01-0001 00:01")
                    {
                        txtFechaSalida.Text = "";
                    }
                    else
                    {
                        txtFechaSalida.Text = registro.FechaSalida.ToString("dd-MM-yyyy HH:MM");
                    }
                }
                
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al consultar el registro (Excepcion: " + ex.Message + ").";
                LimpiarControles();
            }
        }

        protected void btnEditarRegistro_Click(object sender, EventArgs e)
        {

            try
            {
                RegistroAcceso registro = new RegistroAcceso();
                registro.Patente = txtPatente.Text;

                if (!registro.Read())
                {
                    lblMensaje.Text = "Vehiculo no se encuentra en el estacionamiento";
                    LimpiarControles();
                }
                else
                {
                    registro.Marca =  txtMarca.Text;
                    registro.Color = txtColor.Text;
                    registro.TipoPersonal = ddlTipoPersonal.SelectedValue;

                    registro.NombrePersonal = txtNombrePersonal.Text;
                    registro.FechaIngreso = DateTime.Parse(txtFechaIngreso.Text);
                    
                    registro.FechaSalida = DateTime.Parse(txtFechaSalida.Text);
                    

                    registro.Update();

                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al consultar el registro (Excepcion: " + ex.Message + ").";
                LimpiarControles();
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroAcceso registro = new RegistroAcceso();

                registro.Patente = txtPatente.Text;
                registro.Read();
                registro.Delete();
                lblMensaje.Text = "Registro eliminado";


            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al eliminar el registro (Excepcion: " + ex.Message + ").";
                LimpiarControles();
            }
        }



        private void LimpiarControles()
        {
            txtPatente.Text = String.Empty;
            txtMarca.Text = String.Empty;
            txtColor.Text = String.Empty;
            ddlTipoPersonal.SelectedIndex = 0;
            txtNombrePersonal.Text = String.Empty;
            txtFechaIngreso.Text = String.Empty;
            txtFechaSalida.Text = String.Empty;

            txtPatente.Focus();
        }

        protected void btnHoraSalida_Click(object sender, EventArgs e)
        {
            txtFechaSalida.Text = DateTime.Now.ToString("dd-MM-yyyy HH:MM");
        }

        protected void btnHoraIngreso_Click(object sender, EventArgs e)
        {
            txtFechaIngreso.Text = DateTime.Now.ToString("dd-MM-yyyy HH:MM");
        }
    }
}