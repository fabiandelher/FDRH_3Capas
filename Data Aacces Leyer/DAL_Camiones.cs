using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using View_Objects;

namespace Data_Aacces_Leyer
{
    public class DAL_Camiones
    {
        //Create 
        public static string insertar_Camion(Camiones_VO camion)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_CreateCamion",
                    "@Matricula", camion.Matricula,
                    "@Tipo_camion", camion.Tipo_camion,
                    "@Marca", camion.Marca,
                    "@Capacidad", camion.Capacidad,
                    "@Kilometraje", camion.Kilometraje,
                    "@UrlFoto", camion.UrlFoto,
                    "@Disponibilidad", camion.Disponibilidad
                    );
                if(respuesta !=0)
                {
                    salida = "Camión registrado con éxito!!!!!";
                }
                else
                {
                    salida = "Ha ocurrudo un Pedo :O";
                }


            }
            catch (Exception e)
            {
                //salida = "Error: " + e.Messege;
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        //Read 
        public static List<Camiones_VO> Get_Camniones(params object [] parametros)
        {
            List<Camiones_VO> list = new List<Camiones_VO>();
            try
            {
                //Creo un dataset el cual recibira lo que devuelva la ejecuciòn del mètodo 

                DataSet ds_camiones = metodos_datos.execute_DataSet("SP_ReadCamiones", parametros);

                foreach (DataRow dr in ds_camiones.Tables[0].Rows)
                {
                    list.Add(new Camiones_VO(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Update 
        public static string actualizar_Camion(Camiones_VO camion)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_UpdateCamion",
                    "@ID_Camion", camion.ID_Camion,
                    "@Matricula", camion.Matricula,
                    "@Tipo_camion", camion.Tipo_camion,
                    "@Marca", camion.Marca,
                    "@Capacidad", camion.Capacidad,
                    "@Kilometraje", camion.Kilometraje,
                    "@UrlFoto", camion.UrlFoto,
                    "@Disponibilidad", camion.Disponibilidad
                    );
                if (respuesta != 0)
                {
                    salida = "Camión actualizado con éxito!!!!!";
                }
                else
                {
                    salida = "Ha ocurrudo un Pedo :O";
                }

                return salida;
            }
            catch (Exception e)
            {
                
               //salida = "Error: " + e.Messege;
  
                return salida = $"Error: {e.Message}";
            }
        }
        //Delete 
        public static string eliminar_Camion(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_DeleteCamion",
                    "@Id_camion", id
                    );
                if(respuesta != 0)
                {
                    salida = "Camión eliminado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un pedo :O";
                }
            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
    }
        
        
            
}

