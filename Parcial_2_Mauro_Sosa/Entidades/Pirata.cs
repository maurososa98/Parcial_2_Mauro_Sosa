using Entidades.Excepciones;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    [Serializable]
    public class Pirata : Barco
    {
        #region Atributos
        #endregion

        #region Propiedades
        public override int Tripulacion
        {
            get => tripulacion;
            set
            {
                tripulacion = value == 0 ? tripulacion = GenerarRandom.EnteroAleatorio(10, 30) : value;
            }
        }

        #endregion

        #region Constructores
        public Pirata(string nombre)
            : base(nombre)
        {
        }
        public Pirata(int id, string nombre, int tripulacion)
            : base(id, nombre, tripulacion)
        {
        }
        public Pirata()
        {
            
        }

        #endregion

        #region Métodos
        public override void CalcularCosto()
        {
            Costo = (float)GenerarRandom.DoubleAleatorio(2000, 12000);
        }
        #endregion

    }
}
