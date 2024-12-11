using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Aacces_Leyer;
using View_Objects;

namespace Bussines_Logic_Layer
{
    public class BLL_Camiones
    { //create 
        public static string insert_Camion(Camiones_VO camion)
        {
            return DAL_Camiones.insertar_Camion(camion);
        }
        //read 
        public static List<Camiones_VO> Get_Camiones(params object[] parametros)
        {
            return DAL_Camiones.Get_Camniones(parametros);
        }
        //update
        public static string actualizar_Camion(Camiones_VO camion)
        {
            return DAL_Camiones.actualizar_Camion(camion);
        }
        //delete
        public static string eliminar_Camion(int id)
        {
            return DAL_Camiones.eliminar_Camion(id);
        }
    }
}
