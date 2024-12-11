using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace View_Objects
{
    public class Camiones_VO

    {
        //VO = view Object
        //Representación de una tabal a nivel de código de c#


        private int _ID_Camion;
        private string _Matricula;
        private string _Tipo_camion;
        private string _Marca;
        private int _Capacidad;
        private double _Kilometraje;
        private string _UrlFoto;
        private bool _Disponibilidad;
        //private string _Modelo;

        //Encapsulamiento

        public int ID_Camion { get => _ID_Camion; set => _ID_Camion = value; }
        public string Matricula { get => _Matricula; set => _Matricula = value; }
        public string Tipo_camion { get => _Tipo_camion; set => _Tipo_camion = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public int Capacidad { get => _Capacidad; set => _Capacidad = value; }
        public double Kilometraje { get => _Kilometraje; set => _Kilometraje = value; }
        public string UrlFoto { get => _UrlFoto; set => _UrlFoto = value; }
        public bool Disponibilidad { get => _Disponibilidad; set => _Disponibilidad = value; }
        //public string Modelo { get => _Modelo; set => _Modelo = value; }

        //Constructores 

        //Por defecto 
        public Camiones_VO()
        {
            _ID_Camion = 0;
            _Matricula = "";
            _Tipo_camion = string.Empty;
            _Marca = "";
            _Capacidad = 0;
            _Kilometraje = 0;
            _UrlFoto = "";
            _Disponibilidad = true;
            //_Modelo = "";
        }


        // Con Parámetros
        // DataRow => Objeto ADO

        public Camiones_VO(DataRow dr)
        {
            _ID_Camion = int.Parse(dr["ID_Camion"].ToString());
            _Matricula = dr["Matricula"].ToString();
            _Tipo_camion = dr["Tipo_camion"].ToString();
            _Marca = dr["Marca"].ToString();
            _Capacidad = int.Parse(dr["Capacidad"].ToString());
            _Kilometraje = double.Parse(dr["Kilometraje"].ToString());
            _UrlFoto = dr["UrlFoto"].ToString();
            _Disponibilidad = bool.Parse(dr["Disponibilidad"].ToString());
            //_Modelo = dr["Modelo"].ToString();

        }

    }

}

