using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }



        #region Operadores

        private void x_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
        }
        private void Div_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
        }
        private void Mas_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        }
        private void Menos_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }
        private void Ans_Click(object sender, EventArgs e)
        {
            Operaciones opu = new Operaciones("");
            InsertTextValue(opu.show_ans());
        }
        private void Igual_Click(object sender, EventArgs e)
        {

            Calular_Ecuacion();
            //this.UserInput.Text = string.Empty;
        }


        #endregion

        #region Clear
        /// <summary>
        /// Clear User Input uwu
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        private void AC_Click(object sender, EventArgs e)
        {
            //Clear text
            this.UserInput.Text = string.Empty;
        }
        private void DEL_Click(object sender, EventArgs e)
        {
            //Borra el numero que se encuentra a lo mas a la derecha
            try
            {
                this.UserInput.Text = this.UserInput.Text.Remove(this.UserInput.TextLength - 1, 1);

            }
            catch
            {

            }
        }
        #endregion

        #region Numeros
        private void Punto_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }
        private void B7_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
        }
        private void B8_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }
        private void B9_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
        }
        private void B4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
        }
        private void B5_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }
        private void B6_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        private void B1_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        private void B2_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        private void B3_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }

        private void B0_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
        }
        #endregion

        /// <summary>
        /// Hace un focus donde se escriben los datos y así no queda seleccionado el boton que se apreto
        /// </summary>
        private void focusInput()
        {
            this.UserInput.Focus();
        }
        /// <summary>
        /// Inserta el valor en el texto
        /// </summary>
        /// <param name="num">el valor que se inserta</param>
        private void InsertTextValue(string num)
        {
            //coloca el numero dentro de la posicion donde se encuentra el cursor del texto
            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.TextLength , num);
        }

        /// <summary>
        /// Calcula la ecuacion
        /// </summary>
        private void Calular_Ecuacion()
        {
            //this.UserInput.Text = ParseEc();
            string a = ParseEc();
            this.Resultado_Calculadora.Text = a;
            this.UserInput.Text = a.Replace(',', '.');
            for (int i = 0;i < a.Length; i++)
            {
                if(a[i] == ',')
                {
                    //a[i] = '.';
                    //MessageBox.Show(double.Parse(a, System.Globalization.CultureInfo.InvariantCulture).ToString());
                    //a.Replace(',','.');
                    //MessageBox.Show(a + " " + a.Replace(',', '.'));
                    this.UserInput.Refresh();
                    //this.UserInput.Text = "hola";
                    //this.UserInput.Text = a.Replace(',', '.');
                }
            }
        }

        private string ParseEc()
        {
            try
            {
                string input = this.UserInput.Text;
                var util = true;
                string izq = "";
                string der = "";
                string med = "";

                for (int i = 0; i < input.Length; i++)
                {
                    var num = "0123456789.,";
                    if (num.Any(c => input[i] == c))
                    {
                        if (util)
                        {
                            izq = add(izq, input[i]);

                        }
                        else
                        {
                            der = add(der, input[i]);
                        }
                    }
                    else
                    {
                        if (util == false)
                        {
                            throw new InvalidOperationException($"");
                        }

                        med = add(med, input[i]);
                        util = false;

                    }
                }
                Operaciones op = new Operaciones(med);



                return op.operar(izq, der);

            }
            catch (Exception ex)
            {
                return $"Syntax Error {ex.Message}";
            }
        }

        public string add(string numero, char extra)
        {
            if(extra == '.' && numero.Contains(".") )
            {
                throw new InvalidOperationException($"");
            }
            return numero + extra;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Operaciones opi = new Operaciones("");
            this.Histo.Text = opi.leer_historial();
            this.Show_Historial.Visible = true;
        }

        private void Show_Historial_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void Show_Historial_Click(object sender, EventArgs e)
        {
            this.Show_Historial.Visible = false;
        }

        private void Borrar_Histo_Click(object sender, EventArgs e)
        {
            Operaciones opi2 = new Operaciones("");
            opi2.borrar_histo();
            this.Histo.Text = "Historial: \n"+opi2.leer_historial();
        }

        private void Histo_Click(object sender, EventArgs e)
        {

        }
    }
}
