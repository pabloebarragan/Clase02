using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Evento click() del boton Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Limpia los datos cargados en pantalla.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
        }

        /// <summary>
        /// Retorna el resultado de la operacion realizada entre 2 numeros
        /// </summary>
        /// <param name="numero1">numero 1</param>
        /// <param name="numero2">numero 2</param>
        /// <param name="operador">operacion a realizar</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);
            double resultado = Calculadora.Operar(numeroUno, numeroDos, operador);
            return resultado;
        }

        /// <summary>
        /// Evento click() del boton Operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            this.lblResultado.Text = resultado.ToString();
        }

        /// <summary>
        /// Evento click() del boton Convertir a Binario. Convierte un decimal a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero binario = new Numero();
            string anterior = this.lblResultado.Text;
            if (anterior != "Valor invalido" && anterior != string.Empty && lblResultado.Text[0] != '0')
                this.lblResultado.Text = binario.DecimalBinario(this.lblResultado.Text);
        }

        /// <summary>
        /// Evento click() del boton Convertir a Decimal. Convierte un binario a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero binario = new Numero();
            string anterior = this.lblResultado.Text;
            if (anterior != "Valor invalido" && anterior != string.Empty)
            {
                this.lblResultado.Text = binario.BinarioDecimal(this.lblResultado.Text);
            }
        }

        /// <summary>
        /// Load del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Numero binario = new Numero();
            string anterior = this.lblResultado.Text;
            if (anterior != "Valor invalido" && anterior != string.Empty)
            {
                this.lblResultado.Text = binario.BinarioDecimal(this.lblResultado.Text);
            }
        }



    }
}
