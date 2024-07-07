using Entidades.Excepciones;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    [Serializable]
    public class Taller
    {
        #region Atributos
        List<Barco> barcos;
        #endregion

        #region Propiedades
        public List<Barco> Barcos { get => barcos; set => barcos = value; }
        #endregion

        #region Constructores
        public Taller()
        {
        }
        #endregion

        #region Métodos
        public static bool EncontrarBarco(Taller taller, Barco barcoCuestionado)
        {
            bool retorno = false;
            foreach (Barco barcoTaller in taller.Barcos)
            {
                if (Barco.CompararBarcos(barcoTaller, barcoCuestionado))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool IngresarBarco(Taller taller, Barco barco)
        {
            bool retorno = false;
            if (EncontrarBarco(taller, barco) == false)
            {
                taller.barcos.Add(barco);
                retorno = true;
            }
            return retorno;

        }
        public bool Repapar(object taller)
        {
            bool retorno = false;
            if (taller is Taller)
            {
                foreach (Barco barcoTaller in ((Taller)taller).Barcos)
                {
                    if (barcoTaller.EstadoReparado == false)
                    {
                        barcoTaller.CalcularCosto();

                        AccesoDatos.Guardar(barcoTaller.Nombre, barcoTaller.Costo);

                        barcoTaller.EstadoReparado = true;

                    }
                }
            }
            return retorno;
        }
        #endregion

        #region Sobrecarga de operadores
        /*
         * EJEMPLO
         
        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d);
        }

        public static bool operator ==(Escaner e, Documento d)
        {
            bool retorno = false;
            foreach (Documento documento in e.listaDocumentos)
            {
                if ((documento is Libro libro && d is Libro libroD && libro == libroD) ||
                    (documento is Mapa mapa && d is Mapa mapaD && mapa == mapaD))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        */
        #endregion
    }
}
