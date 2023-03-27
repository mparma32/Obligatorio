using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class TipoCabana: IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set;}
        public double CostoPersona { get; set;}

        public TipoCabana () { 
        }

        public TipoCabana(string nombre, string descripcion, double costopersona)
        {
            Nombre = nombre;
            Descripcion = descripcion; 
            CostoPersona = costopersona;
        }

        public void EsValido()
        {
            // FALTA IMPLEMENTAR
            throw new NotImplementedException();
        }
    }
}
