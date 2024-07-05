using System.Text;

namespace Entidades
{
    public class Taller
    {
        List<Barco> barcos;

        public List<Barco> Barcos { get => barcos; set => barcos = value; }

        public Taller()
        {
            barcos = new List<Barco>();
        }

        public static bool EncontrarBarco(Taller taller, Barco barcoCuestionado)
        {
            bool retorno = false;
            foreach (Barco barcoTaller in taller.barcos)
            {
                if (barcoTaller == barcoCuestionado)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static Taller IngresarBarco(Taller taller, Barco barco)
        {
            if (!EncontrarBarco(taller, barco))
            {
                taller.barcos.Add(barco);
            }
            return taller;

        }
        public bool Repapar(Taller taller)
        {
            bool retorno = false;
            if (taller is Taller)
            {
                foreach (Barco barcoTaller in taller.barcos)
                {
                    if (barcoTaller.EstadoReparado == false)
                    {
                        barcoTaller.CalcularCosto();

                        // Guardar la reparación en la BD

                        barcoTaller.EstadoReparado = true;

                    }
                }
            }
            return retorno;
        }
    }
}
