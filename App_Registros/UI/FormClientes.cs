using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Registros.DAO;

namespace App_Registros.UI
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            VerRegistros("");
        }

        private void VerRegistros(string Condicion) { 
            ClienteDAO DAO = new ClienteDAO();
            dataGridView1.DataSource = DAO.VerRegistros(Condicion);
        }

    }
}
