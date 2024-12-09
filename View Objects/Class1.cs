using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_Objects
{
    public class configuracion
    {
        static string _cadenaConexion = @"Data Source = LAPTOP-D5HK5OAT\SQLEXPRESS;
                                        initial Catalog = Transportes;
                                        Ingtegrated Securyty = true;";
        //encapsulamiento 
        public static string CadenaConexion
        {
            get

            {
                return _cadenaConexion;

            }

        }
    }

}

