using Entidades.Excepciones;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class XmlManager : IArchivos
    {
        //public List<Barco> lista;
        //public XmlManager(List<Barco> lista)
        //{
        //    this.lista = lista;
        //}
        //public XmlManager()
        //{

        //}

        public bool Guardar(string path, Taller taller, out string mensajeError)
        {
            bool retorno = true;
            mensajeError = "";
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Taller));
                    serializer.Serialize(streamWriter, taller);
                }
            }
            catch (Exception ex)
            {
                retorno = false;
                mensajeError = ex.Message;
            }
            return retorno;
        }

        public List<Barco> Leer(string path, out string mensajeError)
        {
            List<Barco> retorno ;
            mensajeError = "";
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Taller));
                    Taller tallerArchivo = (Taller)deserializer.Deserialize(streamReader);
                    retorno = tallerArchivo.Barcos;    
                }
            }
            catch (Exception ex)
            {
                retorno = new List<Barco>();
                mensajeError = ex.Message;
            }
            return retorno;

        }

    }
}
