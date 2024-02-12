using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presupuesto_hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            double presupuesto, Emergencia, Cirugía, Suministros, Administración, Laboratorio, Imágenes;

            presupuesto=double.Parse(txt_presupuesto.Text);

            Emergencia = (presupuesto * 30) / 100;
            Cirugía = (presupuesto * 15)/ 100;
            Suministros= (presupuesto * 25)/100;
            Administración = (presupuesto * 18) / 100;
            Laboratorio = (presupuesto * 5) / 100;
            Imágenes = (presupuesto * 7) / 100; 

            txt_Emergencia.Text = Emergencia.ToString();
            txt_Cirugía.Text = Cirugía.ToString();
            txt_Suministros.Text = Suministros.ToString();
            txt_Administracion.Text = Administración.ToString();
            txt_Laboratorio.Text = Laboratorio.ToString();
            txt_Imágenes_Diagnosticas.Text = Imágenes.ToString();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_presupuesto.Clear();
            txt_Emergencia.Clear();
            txt_Cirugía.Clear();
            txt_Suministros.Clear();
            txt_Administracion.Clear();
            txt_Laboratorio.Clear();
            txt_Imágenes_Diagnosticas.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
