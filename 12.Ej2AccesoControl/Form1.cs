using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _12.Ej2AccesoControl.models;

namespace _12.Ej2AccesoControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Controlador Nachito = new Controlador();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string patente,tipov;
            int model, tipo = 0;
            bool electric;
            patente = tbxPatente.Text;
            model = Convert.ToInt16(tbxModelo.Text);
            tipov = cbxTipo.Text;

            switch (tipov)
            {
                case "Automovil":
                    {
                        tipo = 1;
                    }break;
                case "Motocicleta":
                    {
                        tipo = 2;
                    }break;
                case "Camioneta":
                    {
                        tipo = 3;
                    }break;
                case "Camion":
                    {
                        tipo = 4;
                    }break;
            }

            if (checkBox1.Checked)
            {
                electric = true;
            }
            else
            {
                electric = false;
            }
            Nachito.RegistrarVehiculo(patente,model,tipo, electric);
            tbxModelo.Clear();
            tbxPatente.Clear();
            
        }

        private void btnVerEstadia_Click(object sender, EventArgs e)
        {
            FormVerList nachita = new FormVerList();
            Nachito.ListarElectricos();
            nachita.lbxLista.Items.Add($"La cantidad de vehiculos registrados es : {Nachito.ContTotal}");
            for (int i = 0; i < Nachito.ContElectric; i++)
            {
                string paten = Nachito.PatenElectric[i];
                int model = Nachito.ModelElectric[i];
                int tip = Nachito.TiposE[i];
                nachita.lbxLista.Items.Add($"{paten}--{model}--{tip}");
            }

            if (nachita.ShowDialog() == DialogResult.Cancel)
            {
                nachita.Close();
                nachita.Dispose();
                
            }
            
            
        }
    }
}
