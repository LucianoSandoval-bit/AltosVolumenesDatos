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
    public partial class HistorialMod : Form
    {
        public HistorialMod()
        {
            InitializeComponent();
        }
        public int ID =0;
        private void HistorialMod_Load(object sender, EventArgs e)
        {
            var conn = new EnlaceCassandra();
            List<Region> lst1 = new List<Region>();
            lst1 = conn.Get_Historial(ID);
            DG_Historial.Columns.Add("Fechamod","Fechas de modificacion");
            for(int i =0;i<lst1[0].Fechamod.Length;i++)
            {
                DG_Historial.Rows.Add(lst1[0].Fechamod[i]);
            }
           
            DG_Historial.AutoGenerateColumns = false;
        }

        private void DG_Historial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
