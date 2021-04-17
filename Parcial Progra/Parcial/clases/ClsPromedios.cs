using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplos_case8__arreglos.clases
{
    class ClsPromedios : InterfacePromedios
    {


        public int promedio_por_parcial(string[,] matriz, int columna_parcial)
        {
            int ac = 0;
            int pr;
            int tf = matriz.GetLength(0);
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                ac = ac + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            pr = ac / (matriz.GetLength(0) - 1);
            return pr;
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {

            int acum = 0;
            double prom;
            int totalfilas = matriz.GetLength(0);
            int contador = 0;
            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                if (matriz[fila, 5].Trim().Equals(seccion))
                {
                    acum = acum + Convert.ToInt32(matriz[fila, columna_parcial]);
                    contador++;
                }


            }
            prom = acum / contador;
            return Convert.ToInt32(prom);


        }




        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            double s = 0;
            int contador = 0;
            int tf = matriz.GetLength(0);
            
            string[,] su = new string[matriz.GetLength(0), 2];

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {

                s = Convert.ToInt32(matriz[fila, 2]) + Convert.ToInt32(matriz[fila, 3]) + Convert.ToInt32(matriz[fila, 4]);
                su[contador, 0] = matriz[fila, 1];
                su[contador, 1] = Convert.ToString(s);
                contador++;
            }

            return su;

        }
        string[,] InterfacePromedios.Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }

        int InterfacePromedios.promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();
        }

        int InterfacePromedios.promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            throw new NotImplementedException();
        }

        int InterfacePromedios.promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();
        }

        string[,] InterfacePromedios.sumatoria_general_por_alumno(string[,] matriz)
        {
            throw new NotImplementedException();
        }
    }
     
}
