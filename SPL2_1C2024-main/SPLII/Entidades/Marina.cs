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

        public override int Tripulacion { get => tripulacion; }

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
