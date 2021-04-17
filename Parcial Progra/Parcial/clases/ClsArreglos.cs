using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplos_case8__arreglos.clases
{
    class ClsArreglos
    {
        //odenamiento burbuja
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datoTemporal;
        private int tamanoArreglo=0;

        public int GetTamañoArreglo()
        {
            return datos.Length;
        }

        public ClsArreglos (int[] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length;//numero de datos
        }

        /// <summary>
        /// burbuja
        /// intercambiar cada pareja consecutiva no ordenada
        /// </summary>
        /// <returns></returns>
        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;

            for(i=0; i < tamanoArreglo - 1; i++)
            {
                for(j=i+1;j<tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i] > ArregloTemporal[j])
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;

                    }
                }
            }
            return ArregloTemporal;
        }

        //ORDENAR NOMBRES
        private string[] ArregloTemporall;
        private string[] datosi;
        private string datoTemporall;


        public ClsArreglos(string[] arreglo)
        {
            datosi = arreglo;
            tamanoArreglo = datosi.Length;//numero de datos
        }

        
        public string[] MetodoBurbujaNombres()
        {
            ArregloTemporall = datosi;

            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                { 
                    if (ArregloTemporall[i].CompareTo(ArregloTemporall[j])>0)
                    {
                        datoTemporall = ArregloTemporall[i];
                        ArregloTemporall[i] = ArregloTemporall[j];
                        ArregloTemporall[j] = datoTemporall;
                    }
                }
            }
            return ArregloTemporall;
        }


      
    }
}
