using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public EnlaceDB conexion;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var x = new EnlaceCassandra();
            List<Region> lst1 = new List<Region>();
            lst1 = x.Get_All();

            dataGridView1.DataSource = lst1;
            conexion = null;    
        }

        private void unoPorUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conexion = new EnlaceDB();
            DataTable data = new DataTable();

            data = conexion.get_Users();

            foreach (DataRow renglon in data.Rows)
            {
                MessageBox.Show(renglon["Nombre"].ToString(), "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexion = null;
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGet_Click(sender, e);
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.ShowDialog();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
