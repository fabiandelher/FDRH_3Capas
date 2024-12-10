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

        }

        protected void GVCamiones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GVCamiones_RowCommand(object sender, GridViewCommandEventArgs e)
        {

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