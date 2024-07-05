using System.Text;

namespace Entidades
{
    public class Marina : Barco
    {

        public Marina(float costo, bool estadoReparado, string nombre, EOperacion operacion, int tripulacion)
            : base(costo, estadoReparado, nombre, operacion, tripulacion)
        {
        }
        public Marina()
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
                    base.tripulacion = random.Next(30, 60);
                }
                return 0;
            }
        }

        public override void CalcularCosto()
        {
            Random random = new Random();
            base.costo = random.Next(5000, 25000);
        }



    }
}
