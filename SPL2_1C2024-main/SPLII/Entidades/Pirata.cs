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
                int retorno = base.tripulacion;
                if (this == null) 
                { 

                }
                return 0; 
            }
        }

        public override void CalcularCosto()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            //string numNormalizado = this is Libro ? $"\nISBN: {this.numNormalizado}" : "";

            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"\nCosto: {this.Costo}");
            texto.AppendLine($"EstadoReparado: {this.EstadoReparado}");
            texto.AppendLine($"Nombre: {this.Nombre}");
            texto.Append($"Operacion: {this.Operacion}");
            texto.Append($"Tripulacion: {this.Tripulacion}");

            return texto.ToString();
        }


    }
}
