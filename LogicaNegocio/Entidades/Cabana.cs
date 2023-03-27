using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Cabana: IValidable
    {
        public int Id { get; set; }
        public int NumHabitacion { get; set; }
        public TipoCabana Tipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool TieneJacuzzi { get; set; }
        public bool ReservasHabilitadas { get; set; }
        public int MaxPersonas { get; set; }
        public string Imagen { get; set; }

        /*
        public Cabana () { }

        public Cabana(int numeroHab, TipoCabana tipo, string nombre, string descripcion, bool jacuzzi,bool habilitada, int maxpersonas, string imagen)
        {
            NumHabitacion = numeroHab;
            Tipo = tipo;
            Nombre = nombre;
            Descripcion = descripcion;
            TieneJacuzzi = jacuzzi;
            ReservasHabilitadas = habilitada;
            MaxPersonas = maxpersonas;
            Imagen = imagen;
        }
        */

        public void EsValido()
        {
            //FALTA IMPLEMENTAR
            throw new NotImplementedException();
        }
    }
}
