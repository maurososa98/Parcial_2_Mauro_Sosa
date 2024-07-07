using Entidades.Excepciones;
using System.Text;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Pirata))]
    [XmlInclude(typeof(Marina))]
    public abstract class Barco
    {
        #region Atributos
        protected int id;
        protected float costo;
        protected bool estadoReparado;
        protected string nombre;
        protected EOperacion operacion;
        protected int tripulacion;

        #endregion

        #region Propiedades
        public float Costo { get => costo; set => costo = value; }
        public bool EstadoReparado { get => estadoReparado; set => estadoReparado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EOperacion Operacion { get => operacion; set => operacion = value; }
        public abstract int Tripulacion { get; set; }
        public int Id { get => id; set => id = value; }
        #endregion

        #region Constructores
        public Barco(string nombre)
        {
            Nombre = nombre;
        }
        public Barco(int id, string nombre, int tripulacion)
            : this(nombre)
        {
            Id = id;
            Tripulacion = tripulacion;
        }
        protected Barco()
        {
            
        }


        #endregion

        #region Métodos
        public abstract void CalcularCosto();

        public static bool CompararBarcos(Barco barcoUno, Barco barcoDos)
        {
            return barcoUno.Nombre == barcoDos.Nombre;
        }

        public override string ToString()
        {
            ETipoBarco tipo = this is Pirata ? ETipoBarco.Pirata : ETipoBarco.Marina;

            StringBuilder texto = new StringBuilder();
            texto.Append($"{this.Id,-10}\t");
            texto.Append($"{this.Nombre,-30}\t");
            texto.Append($"{tipo.ToString(),-20}\t");
            texto.Append($"{this.Tripulacion,-10}\t");

            return texto.ToString();
        }

        #endregion

    }
}
