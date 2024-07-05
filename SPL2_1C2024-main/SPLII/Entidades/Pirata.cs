using System.Text;

namespace Entidades
{
    public class Pirata : Barco
    {

        public Pirata(float costo, bool estadoReparado, string nombre, EOperacion operacion, int tripulacion)
            :base(costo, estadoReparado, nombre, operacion, tripulacion)
        {
        }
        public Pirata()
        {
            
        }

        public override int Tripulacion 
        {
            get 
            {
                Random random = new Random();

                int retorno = base.tripulacion;
                if (base.tripulacion == 0) 
                {
                    base.tripulacion = random.Next(10,30);
                }
                return 0; 
            }
        }

        public override void CalcularCosto()
        {
            Random random = new Random();
            base.costo = random.Next(2000, 12000);

        }



    }
}
