using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaDeNegocios;

namespace CapaDePresentaciones
{
    public partial class Estadistica : System.Web.UI.Page
    {
        private RegistroAccesoCollection _registroCollection = new RegistroAccesoCollection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlTipo.Items.Add("Docente");
                ddlTipo.Items.Add("Alumno");
            }
        }

        protected void btnDia_Click(object sender, EventArgs e)
        {
            
            lblPorDia.Text = _registroCollection.RegistrosPorDia(int.Parse(txtAno.Text), int.Parse(txtMes.Text), int.Parse(txtDia.Text)).ToString();
        }

        protected void btnTotalAlumnosDocentes_Click(object sender, EventArgs e)
        {
            lblTotalAlumnos.Text = _registroCollection.TotalAlumnos().ToString();
            lblTotalDocentes.Text = _registroCollection.TotalDocentes().ToString();
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            lblTotalPorHoras.Text = _registroCollection.RegistrosRangoHoras(int.Parse(txtMayor.Text), int.Parse(txtMenor.Text)).ToString();
        }

        protected void btnSegunTipo_Click(object sender, EventArgs e)
        {
            lblSegunTipo.Text = _registroCollection.ListaSegunTipo(ddlTipo.SelectedValue.ToString()).ToString();
        }
    }
}