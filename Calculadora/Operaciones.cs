using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    class Operaciones
    {
        static List<string> Historial = new List<string>();
        static string ans = "";

        public string Medio { get; set; }

        public Operaciones(string Medio)
        {

            this.Medio = Medio;
        }
        public void leer_historial()
        {
            string histo = "";
            for(int i = 0; i < Historial.Count; i++)
            {
                histo += Historial[i] + "\n";
            }
            MessageBox.Show(histo);
        }
        public void add_new_ans(string a)
        {
            ans = a;
        }
        public string show_ans()
        {
            return ans;  
        }


        public string operar(string I,string D)
        {
            int Izquierda = Int32.Parse(I);
            int Derecha = Int32.Parse(D);
            int resutl;
            if (Medio == "+")
            {
                resutl = Izquierda + Derecha;
                Historial.Add(resutl.ToString());
                add_new_ans(resutl.ToString());
                return resutl.ToString();
            }
            else if(Medio == "-")
            {
                resutl = Izquierda - Derecha;
                Historial.Add(resutl.ToString());
                add_new_ans(resutl.ToString());
                return resutl.ToString();
            }
            else if(Medio == "/")
            {
                try
                {
                    resutl = Izquierda / Derecha;
                    Historial.Add(resutl.ToString());
                    add_new_ans(resutl.ToString());
                    return resutl.ToString();
                }
                catch
                {
                    return $"Math Error";
                }
                
            }
            else if(Medio == "*")
            {
                try
                {
                    resutl = Izquierda * Derecha;
                    Historial.Add(resutl.ToString());
                    add_new_ans(resutl.ToString());
                    return resutl.ToString();
                }
                catch
                {
                    return $"Math Error";
                }
            }
            return $"Nothing";

        }
    }


}
