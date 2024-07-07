using Entidades.Excepciones;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    [Serializable]
    public class Marina : Barco
    {
        #region Atributos
        #endregion

        #region Propiedades
        
        public override int Tripulacion
        {
            get => tripulacion;
            set
            {
                tripulacion = value == 0 ? tripulacion = GenerarRandom.EnteroAleatorio(30, 60) : value;
            }
        }
        #endregion

        #region Constructores
        public Marina(string nombre)
            : base(nombre)
        {
        }

        public Marina(int id, string nombre, int tripulacion)
            : base(id, nombre, tripulacion)
        {
        }
        public Marina()
        {
            
        }

        #endregion

        #region Métodos
        public override void CalcularCosto()
        {
            Costo = (float)GenerarRandom.DoubleAleatorio(5000, 25000);
        }
        
        #endregion

    }
}
