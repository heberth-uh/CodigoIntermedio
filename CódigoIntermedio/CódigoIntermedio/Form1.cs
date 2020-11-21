using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CódigoIntermedio
{
    public partial class codIntermedio : Form
    {
        public codIntermedio()
        {
            InitializeComponent();
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            string entrada = txt_entrada.Text;
            string[] ENTRADA = new string[50];
            List<string> list_salida = new List<string>();
            List<string> list_pila = new List<string>();
            string front_E, front_P, x;

            string[] operando = { "a","b","c","d","e","f","g","h","i","j","k","l","m","n","ñ","o","p","q","r","s","t","u","v","w","x","y","z",
                                  "A","B","C","D","E","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
            string[] operador = {"^","/","*","+","-"};
                //prioridad de operadores
              
            
            int tam = entrada.Length;

            //Array para ENTRADA
            for (int i = 0; i < tam; i++)
            {
                ENTRADA[i] += entrada[i];
            }


            //Conversión a POLACA
            while(ENTRADA != null)
            {
                for (int j = 0; j < tam; j++) //modificar el límite
                {
                    front_E = ENTRADA[j];                               //caracter actual
                    ENTRADA[j] = "";                                    //pop de ENTRADA
                    if(Array.Exists(operando, element => element == front_E))
                    {                        
                        list_salida.Add(front_E);                       //push e en ENTRADA   
                    }
                    else if(front_E == "(")
                    {
                        list_pila.Add(front_E);
                    }
                    else if(front_E == ")")
                    {
                        front_P = list_pila.Last();                     //Guarda el ultimo elemento metido
                        while(front_P != "(")
                        {
                            //Comprobación
                            string[] PILA = list_pila.ToArray();
                            string pila = String.Join("", PILA);
                            MessageBox.Show(pila);

                            x = front_P;                         //x guarda temporalmente en Pila
                            int rm = list_pila.Count;
                            list_pila.RemoveAt(rm);                     //Se saca el utlimo elemento de Pila
                            list_salida.Add(x);                         //Meter x en SALIDA
                            
                            MessageBox.Show(pila);
                        }       
                        list_pila.Remove("(");
                    }
                    else if (Array.Exists(operador, element => element == front_E))
                    {
                        front_P = list_pila.Last();
                        //Prioridad frente de Entrada
                        int prioridad_e;
                        if(front_E == "^")
                        {
                            prioridad_e = 1;
                        }
                        else if(front_E == "*" || front_E == "/")
                        {
                            prioridad_e = 2;
                        }
                        else
                        {
                            prioridad_e = 3;
                        }

                        //Prioridad frente de Pila
                        int prioridad_p;
                        if(front_P == "^")
                        {
                            prioridad_p = 1;
                        }
                        else if(front_P == "*" || front_P == "/"){
                            prioridad_p = 2;
                        }
                        else
                        {
                            prioridad_p = 3;
                        }
                        while(list_pila != null && front_P != "(" && prioridad_p >= prioridad_e )
                        {
                            x = front_P;                         //x guarda temporalmente en Pila
                            int rm = list_pila.Count - 1;
                            list_pila.RemoveAt(rm);                     //Se saca el utlimo elemento de Pila
                            list_salida.Add(x);
                        }
                        list_pila.Add(front_E);
                    }
                    else
                    {
                        txt_result.Text = "No juncionó";
                    }
                    

                }
                
            }

            while(list_pila != null)
            {
                x = list_pila.Last();                       //x guarda temporalmente en Pila
                int rm = list_pila.Count - 1;
                list_pila.RemoveAt(rm);                     //Se saca el utlimo elemento de Pila
                list_salida.Add(x);
            }



            string[] SALIDA = list_salida.ToArray();
            string salida = String.Join("", SALIDA);
            txt_result.Text = salida;
        
        }

    }
}
