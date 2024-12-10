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
            //Delete 
        }
        
        
            
}

