using ejemplos_case8__arreglos.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplos_case8__arreglos
{
    public partial class Form1 : Form
    {

        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5]; //creando el arreglo
            arreglo[0] = 10;//asignando valor a la posicion 0 del arreglo
            arreglo[1] = 8;
            arreglo[2] = 16;
            arreglo[3] = 36;
            arreglo[4] = 1;

            ClsArreglos ObjArreglo = new ClsArreglos(arreglo);
            int[] resultado = ObjArreglo.MetodoBurbuja();

            for(int indice=0;indice<resultado.Length; indice++)//esta diciendo que vaya de 0 hasta la ultima posicion del arreglo o vector
            {
                //  listBoxResultado.Items.Add(arreglo[indice]);
                listBoxResultado.Items.Add($"valor= {resultado[indice]} posicion={indice} ");

 }

            //podemos usar un for o un foreach y es lo mismo

           // foreach(int r in arreglo)//estamos diciendo que interactue r en arreglo que es el nombre del vector y el int es porque el vector es tipo int
            //{
             //   listBoxResultado.Items.Add(arreglo[indice]);
            //}

                    }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivos ar = new ClsArchivos();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo plano ";
            ofd.InitialDirectory = @"C:\Users\TECNOLOGIA\Downloads\archivoplano2.csv";
            ofd.Filter = "archivoplanos(*.csv)|*.csv";

            if (ofd.ShowDialog()== DialogResult.OK)
            {
                var archivo = ofd.FileName; //devuelve el nombre y el lugar del archivo
                string resultado = ar.LeerTodoArchivo(archivo);

               ArregloNotas = ar.LeerArchivo(archivo); //retorna arreglo

                textBoxContenido.Text = resultado;
            }

        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string[] nombres= new string[ArregloNotas.Length - 1];
            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';'); //devuelve una posicion arreglo por cada punto y cma que divida los nombres
                    nombres[contador - 1] = datos[1];
                }       
            
                contador++;
        }
            ClsArreglos arreglonombres = new ClsArreglos(nombres);
            string[] resultados = arreglonombres.MetodoBurbujaNombres();
            for (int indice = 0; indice < resultados.Length; indice++)//esta diciendo que vaya de 0 hasta la ultima posicion del arreglo o vector
            {
                listBoxNombres.Items.Add(resultados[indice]); //devuelve la posicion uno del arreglo datos que es el nombre
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach( string linea in ArregloNotas)
            {
                String[] datos = linea.Split(';');
                parcial1.Items.Add(datos[2]);
                parcial2.Items.Add(datos[3]);
                parcial3.Items.Add(datos[4]); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = parcial1.Items.Cast<string>().Max(x => Convert.ToInt32(x)).ToString();
            textBox2.Text = parcial1.Items.Cast<string>().Min(x => Convert.ToInt32(x)).ToString();
            textBox3.Text = parcial1.Items.Cast<string>().Average(x => Convert.ToInt32(x)).ToString();
            textBox4.Text = parcial2.Items.Cast<string>().Max(x => Convert.ToInt32(x)).ToString();
            textBox5.Text = parcial2.Items.Cast<string>().Min(x => Convert.ToInt32(x)).ToString();
            textBox6.Text = parcial2.Items.Cast<string>().Average(x => Convert.ToInt32(x)).ToString();
            textBox7.Text = parcial3.Items.Cast<string>().Max(x => Convert.ToInt32(x)).ToString();
            textBox8.Text = parcial3.Items.Cast<string>().Min(x => Convert.ToInt32(x)).ToString();
            textBox9.Text = parcial3.Items.Cast<string>().Average(x => Convert.ToInt32(x)).ToString();

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string[,] Arreglodosdimensiones = new string[ArregloNotas.Length - 0, 6];
            foreach (string line in ArregloNotas)
            {
                string[] datos = line.Split(';');
                Arreglodosdimensiones[contador, 0] = datos[0];
                Arreglodosdimensiones[contador, 1] = datos[1];
                Arreglodosdimensiones[contador, 2] = datos[2];
                Arreglodosdimensiones[contador, 3] = datos[3];
                Arreglodosdimensiones[contador, 4] = datos[4];
                Arreglodosdimensiones[contador, 5] = datos[5];

                contador++;
            }

            ClsPromedios PromedioP = new ClsPromedios();
            double prom = PromedioP.promedio_por_parcial(Arreglodosdimensiones, 3);
            double pro = PromedioP.promedio_por_parcial(Arreglodosdimensiones, 2);
            double pr = PromedioP.promedio_por_parcial(Arreglodosdimensiones, 4);
            textBox10.Text = Convert.ToString(prom);
            textBox11.Text = Convert.ToString(pro);
            textBox12.Text = Convert.ToString(pr);
            ClsPromedios Pre = new ClsPromedios();
            string[,] suma = Pre.sumatoria_general_por_alumno(Arreglodosdimensiones);
            for (int i = 0; i < ArregloNotas.Length - 1; i++)
            {
                listBox1.Items.Add(" " + suma[i, 0] + " " + suma[i, 1]);
            }

            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
