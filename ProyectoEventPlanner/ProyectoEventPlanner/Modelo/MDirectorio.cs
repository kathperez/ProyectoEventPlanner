using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEventPlanner.Modelo
{
    public class MDirectorio
    {
        
        public string nombreEmpresa { get; set; }
        public string nombre { get; set; }
        public string PrimerApellido { set; get; }
        public string SegundoApellido { set; get; }
        public string telPrincipal { set; get; }
        public string telOpcional { set; get; }
        public string direccion { set; get; }
        public string paginaWeb { set; get; }
        public string area { set; get; }
        public string comentarios { set; get; }

        public MDirectorio()
        { }

        public MDirectorio(string nombreempresa,string nombre1, string primerApellido, string segundoApellido, string telprincipal,
            string telopcional, string direccion1, string paginaweb, string area1, string comentarios1)
        {
            nombreEmpresa = nombreempresa;
            nombre = nombre1;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            telOpcional = telopcional;
            telPrincipal = telprincipal;
            direccion = direccion1;
            paginaWeb = paginaweb;
            area = area1;
            comentarios = comentarios1;
        }



    }
}
