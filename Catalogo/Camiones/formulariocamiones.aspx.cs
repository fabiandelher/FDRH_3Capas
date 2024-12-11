using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussines_Logic_Layer;
using View_Objects;

namespace FDRH_3Capas.Catalogo.Camiones
{
    public partial class formulariocamiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //valido si es Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    //Voy a insertar
                    Titulo.Text = "Agregar Camión";
                    subTitulo.Text = "Registro de un nuevo camión";
                    lbldisponibilidad.Visible = false;
                    chkdisponibilidad.Visible = false;
                    imgfoto.Visible = false;
                    //lblurlfoto.Visible = false;
                }
                else
                {
                    //voy a actualizar 
                    //recupero el ID que proviene de la URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    Camiones_VO _camion_original = BLL_Camiones.Get_Camiones("@ID_Camion", _id)[0];

                    if (_camion_original.ID_Camion != 0)
                    {
                        Titulo.Text = "Actualizar Camión";
                        subTitulo.Text = $"Modificar los datos del camión #{_id}";
                        txtmatricula.Text = _camion_original.Matricula;
                        txtcapacidad.Text = _camion_original.Capacidad.ToString();
                        txtkilometraje.Text = _camion_original.Kilometraje.ToString();
                        txttipo.Text = _camion_original.Tipo_camion.ToString();
                        txtmarca.Text = _camion_original.Marca;
                        //txtmodelo.Text = _camion_original.Modelo;
                        chkdisponibilidad.Checked = _camion_original.Disponibilidad;
                        imgfoto.ImageUrl = _camion_original.UrlFoto;

                    }
                    else
                    {
                        Response.Redirect("listado_camiones.aspx");
                    }

                }
            }
        }

        protected void btnsubeimagen_Click(object sender, EventArgs e)
        {
            if (subeimagen.Value != "")
            {
                string fileName = Path.GetFileName(subeimagen.Value);
                string fileExt = Path.GetExtension(fileName).ToLower();
                if ((fileExt != ".jpg") && (fileExt != ".png"))
                {
                    //Sweet Alert 
                }
                else
                {
                    string pathdir = Server.MapPath("~/Imagenes/Camiones/");
                    if (!Directory.Exists(pathdir))
                    {
                        Directory.CreateDirectory(pathdir);
                    }
                    subeimagen.PostedFile.SaveAs(pathdir + fileName);

                    string urlfoto = "/Imagenes/Camiones/" + fileName;
                    this.urlfoto.Text = urlfoto;
                    imgcamion.ImageUrl = urlfoto;

                }


            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            string titulo = "", respuesta = "", tipo = "", salida = "";
            try
            {
                Camiones_VO _camion_aux = new Camiones_VO();
                _camion_aux.Matricula = txtmatricula.Text;
                _camion_aux.Marca = txtmarca.Text;
                _camion_aux.Tipo_camion = txttipo.Text;
                _camion_aux.Capacidad = Convert.ToInt32(txtcapacidad.Text);
                _camion_aux.Kilometraje = Convert.ToDouble(txtkilometraje.Text);
                _camion_aux.Disponibilidad = chkdisponibilidad.Checked;
                _camion_aux.UrlFoto = imgcamion.ImageUrl;

                // forma 2 (durante la propia inserción o actualización)
                Camiones_VO _camion_aux_2 = new Camiones_VO()
                {
                    Matricula = txtmatricula.Text,
                    Marca = txtmarca.Text,
                    Tipo_camion = txttipo.Text,
                    //Modelo = txtmodelo.Text,
                    Capacidad = Convert.ToInt32(txtcapacidad.Text),
                    Kilometraje = Convert.ToDouble(txtkilometraje.Text),
                    UrlFoto = imgcamion.ImageUrl
                };

                // decido si voy a insertar o actualizar
                if (Request.QueryString["Id"] == null)
                {
                    // Voy a insertar
                    _camion_aux.Disponibilidad = true;
                    salida = BLL_Camiones.insert_Camion(_camion_aux);
                }
                else
                {
                    // Actualizar
                    _camion_aux.ID_Camion = int.Parse(Request.QueryString["Id"]);
                    salida = BLL_Camiones.actualizar_Camion(_camion_aux);
                }
                //preparamos la salida para cachar un error y mostrar el sweetalert
                if (salida.ToUpper().Contains("ERROR"))
                {

                }
                else
                {

                }
            }
            catch (Exception ex)
            {


            }

        }
    }
}