using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversiones
{
    public partial class Form1 : Form
    {
        Conversores conversor = new Conversores();

        public object MessageBoxbuttons { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbotipos.Items.AddRange(conversor.Tipo);
            cbotipos.SelectedIndex = 0;

        }

        private void btnconversor_Click(object sender, EventArgs e)
        {
            try
            {
           

                lblResultado.Text = txtcantidades.Text+" "+conversor.Etiquetas[cbotipos.SelectedIndex][cbotengo.SelectedIndex]+" Equivalen a: " + conversor.convertir(cbotengo.SelectedIndex, cboquiero.SelectedIndex, double.Parse(txtcantidades.Text), cbotipos.SelectedIndex)+""+conversor.Etiquetas[cbotipos.SelectedIndex][cboquiero.SelectedIndex];
            }
            catch (Exception error)
            {
                MessageBox.Show("No puede dejar la canitidad en 0", "conversor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void cbotipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbotengo .Items.Clear();
            cboquiero.Items.Clear();
            cbotengo .Items.AddRange(conversor .Etiquetas [cbotipos .SelectedIndex]);
            cboquiero .Items.AddRange(conversor .Etiquetas [cbotipos .SelectedIndex]);
            lbltipodeconversor .Text = "Convertidor de " + conversor .Tipo[cbotipos .SelectedIndex];
            cbotengo .SelectedIndex = 0;
            cboquiero .SelectedIndex = 1;
            lblResultado .Text = "";
            txtcantidades .Text = "Ingrese cantidad";
        }

        private void txtcantidades_Click(object sender, EventArgs e)
        {
            txtcantidades.Text = "";
        }
    }
    }

