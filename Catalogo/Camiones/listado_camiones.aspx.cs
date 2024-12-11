using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussines_Logic_Layer;
using Data_Aacces_Leyer;

namespace FDRH_3Capas.Catalogo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //utilizamos la variable "IsPostBack" para controlar la primera vez qeu se carga la pagina 
            if(!IsPostBack)
            {
                cargarGrid();
            }
        }
        public void cargarGrid()
        {     //cargar la información desde la bLL al GV
            GVCamiones.DataSource = BLL_Camiones.Get_Camiones();
            //mostrar los resultados renderizando la información
            GVCamiones.DataBind();
        }

        protected void Insertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formulariocamiones.aspx");
        }

        protected void GVCamiones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //redupero el id del renglon afectado 
            int id_camion = int.Parse(GVCamiones.DataKeys[e.RowIndex].Values["ID_Camion"].ToString());
            //invoco mi metodo para eliminar mi camion
            string respuesta = BLL_Camiones.eliminar_Camion(id_camion);
            //preparamos el sweet alert
            string titulo, msg, tipo;
            if(respuesta.ToUpper().Contains("ERROR"))
            {
                titulo = "Error";
                msg = respuesta;
                tipo = "error";
            }
            else
            {
                titulo = "Correcto!";
                msg = respuesta;
                tipo = "succes";
            }
            //sweet alert 
            //recargamos la página
            cargarGrid();
        }

        protected void GVCamiones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Defino si el comando (el click que se detecta) tiene la propiedad "Select"
            if(e.CommandName == "Select")
            {
                //recupero el indice en funcion de aquel elemento que haya detonado el evento
                int varIndex = int.Parse(e.CommandArgument.ToString());
                //recupero el id en funcion del indice que recuperamos anteriormente
                string id = GVCamiones.DataKeys[varIndex].Values["ID_Camion"].ToString();
                //redirecciono al formulario de edicion pasando como parametro el ID
                Response.Redirect($"formulariocamiones.aspx?Id={id}");
            }
        }

        protected void GVCamiones_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GVCamiones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GVCamiones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}