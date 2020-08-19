using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Compras
{
    public partial class Form1 : Form
    {
        public List<string> Lista = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            lstLista.Items.Add(item);
            
            Lista.Add(item);
            txtItem.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lstLista.SelectedItem != null)
            {
                lstLista.Items.Remove(lstLista.SelectedItem);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Lista salva com sucesso!\n", "Salvo");
            lstLista.Items.Clear();
        }
    }
}


