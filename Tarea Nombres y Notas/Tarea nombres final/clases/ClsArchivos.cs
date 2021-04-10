using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplos_case8__arreglos.clases
{
    class ClsArchivos
    {
        public string[] LeerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo, Encoding.Default);
            return lineas;
        }
        public string LeerTodoArchivo(string archivo)
        {
            string ContenidoArchivo;
            using (StreamReader reader= new StreamReader(archivo, Encoding.UTF7))
            {
                ContenidoArchivo = reader.ReadToEnd(); //se guarda en la variable contenido archivo todo lo leido 
            }
            return ContenidoArchivo;
        }
            }
}
