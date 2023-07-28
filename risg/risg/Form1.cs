using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risg
{
    public partial class Form1 : Form
    {

        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int n = dtgRiegos.Rows.Add();
            //info
            dtgRiegos.Rows[n].Cells[0].Value = txtId.Text;
            dtgRiegos.Rows[n].Cells[1].Value = txtActivo.Text;
            dtgRiegos.Rows[n].Cells[2].Value = txtAnalista.Text;
            dtgRiegos.Rows[n].Cells[3].Value = txtRiesgo.Text;
            dtgRiegos.Rows[n].Cells[4].Value = txtDaño.Text;
            dtgRiegos.Rows[n].Cells[5].Value = txtFecha.Text;
            //-----------
            dtgRiegos1.Rows[n].Cells[0].Value = txtId.Text;
            dtgRiegos1.Rows[n].Cells[1].Value = txtActivo.Text;
            dtgRiegos1.Rows[n].Cells[2].Value = txtAnalista.Text;
            dtgRiegos1.Rows[n].Cells[3].Value = txtRiesgo.Text;
            dtgRiegos1.Rows[n].Cells[4].Value = txtDaño.Text;
            dtgRiegos1.Rows[n].Cells[5].Value = txtFecha.Text;
            //limpiar txts
            txtId.Text = "";
            txtActivo.Text = "";
            txtAnalista.Text = "";
            txtRiesgo.Text = "";
            txtDaño.Text = "";
            txtFecha.Text = "";
        }

        private void btnBorar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgRiegos.Rows.RemoveAt(n);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
