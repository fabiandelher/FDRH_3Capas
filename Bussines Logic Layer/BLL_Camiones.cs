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
    {
        public static List<Camiones_VO> Get_Camiones(params object[] parametros)
        {
            return DAL_Camiones.Get_Camniones(parametros);
        }
    }
}
