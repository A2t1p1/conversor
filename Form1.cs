using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor_mundial
{ 
    public partial class Form1 : Form
    {
        Conversor objconversion = new Conversor();
        public Form1()
        {
            InitializeComponent();
        }           
        private void Form1_Load(object sender, EventArgs e)
        {
            Cbtipo.Items.AddRange(objconversion.tipo);
            Cbtipo.SelectedIndex = 0;
        }
        private void Btnconvertir_Click(object sender, EventArgs e)
        {
            
            lblres.Text = "Valor: " + objconversion.Conver(CboDe.SelectedIndex, CboA.SelectedIndex, double.Parse(txtcantidad.Text), Cbtipo.SelectedIndex)+" "+ objconversion.Viñetas[Cbtipo.SelectedIndex][CboA.SelectedIndex];
            
        }
        private void Cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboDe.Items.Clear();
            CboA.Items.Clear();
            CboDe.Items.AddRange(objconversion.Viñetas[Cbtipo.SelectedIndex]);
            CboA.Items.AddRange(objconversion.Viñetas[Cbtipo.SelectedIndex]);
            lbltipoconver.Text = "Conversor " + objconversion.tipo[Cbtipo.SelectedIndex];
            CboDe.SelectedIndex = 0;
            CboA.SelectedIndex = 1;
            lblres.Text = "";
            Convert.ToString(txtcantidad.Text = "");
        }
    }
}
