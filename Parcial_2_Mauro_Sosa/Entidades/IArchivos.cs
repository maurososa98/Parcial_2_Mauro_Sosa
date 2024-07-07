using Entidades.Excepciones;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public interface IArchivos
    {
        abstract bool Guardar(string path, Taller taller, out string mensajeError);

        abstract List<Barco> Leer(string path, out string mensajeError);
    }
}
