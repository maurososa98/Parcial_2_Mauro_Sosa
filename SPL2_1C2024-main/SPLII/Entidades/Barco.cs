using System.Text;

namespace Entidades
{
    public abstract class Barco
    {
        protected float costo;
        protected bool estadoReparado;
        protected string nombre;
        protected EOperacion operacion;
        protected int tripulacion;

        public enum EOperacion { }

        public float Costo { get => costo; set => costo = value; }
        public bool EstadoReparado { get => estadoReparado; set => estadoReparado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EOperacion Operacion { get => operacion; set => operacion = value; }
        public abstract int Tripulacion { get; }

        public Barco(float costo, bool estadoReparado, string nombre, EOperacion operacion, int tripulacion)
        {
            this.costo = costo;
            this.estadoReparado = estadoReparado;
            this.nombre = nombre;
            this.operacion = operacion;
            this.tripulacion = tripulacion;
        }
        public Barco()
        {
        }

        public abstract void CalcularCosto();

        public bool CompararBarcos(Barco barcoUno, Barco barcoDos)
        {
            return barcoUno == barcoDos;
        }

        public static bool operator ==(Barco barcoUno, Barco barcoDos)
        {
            bool retorno = false;
            if (barcoUno.Nombre == barcoDos.Nombre)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Barco barcoUno, Barco barcoDos)
        {
            return !(barcoUno == barcoDos);
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
