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
    public partial class Regiones : Form
    {
        public Regiones()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Regiones_Load(object sender, EventArgs e)
        {
            var conn = new EnlaceCassandra();
            List<Region> lst1 = new List<Region>();
            lst1 = conn.Get_All();
            DG_Data.DataSource = lst1;
            DG_Data.AutoGenerateColumns = false;
        }

        private void fechasDeModificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialMod FRM = new HistorialMod();
            FRM.ID = Convert.ToInt32(DG_Data.SelectedRows[0].Cells[0].Value.ToString());
            FRM.ShowDialog();
            FRM.Dispose();

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conn = new EnlaceCassandra();
            List<Region> lst1 = new List<Region>();
            Alta FRM = new Alta();
            lst1 = conn.Get_All();
            if(lst1.Count==0)
            {
                FRM.ID = 1;
            }
            else
            {
              lst1.Reverse();
             int IDM = lst1[0].ID;
               for(int i=0;i<lst1.Count();i++)
            {
                if(IDM<lst1[i].ID)
                {
                    IDM = lst1[i].ID;
                }
            }    
                FRM.ID = IDM+1;
            }

            FRM.ShowDialog();
            FRM.Dispose();
            lst1 = conn.Get_All();
            DG_Data.DataSource = lst1;
            DG_Data.AutoGenerateColumns = false;
        }

        private void cambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar FRM = new Modificar();
            FRM.ID = Convert.ToInt32(DG_Data.SelectedRows[0].Cells[0].Value.ToString());
            FRM.region =DG_Data.SelectedRows[0].Cells[1].Value.ToString();
            FRM.regisradoPor = DG_Data.SelectedRows[0].Cells[3].Value.ToString();
            FRM.caracteristica = DG_Data.SelectedRows[0].Cells[4].Value.ToString();
            FRM.estado = DG_Data.SelectedRows[0].Cells[5].Value.ToString();
            FRM.ShowDialog();
            FRM.Dispose();
            List<Region> lst1 = new List<Region>();
            var conn = new EnlaceCassandra();
            lst1 = conn.Get_All();
            DG_Data.DataSource = lst1;
            DG_Data.AutoGenerateColumns = false;
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("¿Esta seguro de que quiere eliminar esta region?","Eliminar",MessageBoxButtons.YesNo);
            if(dlg==DialogResult.Yes)
            {
                var conn = new EnlaceCassandra();
                int ID = Convert.ToInt32(DG_Data.SelectedRows[0].Cells[0].Value.ToString());
                conn.DeleteDato(ID);
                List<Region> lst1 = new List<Region>();
                lst1 = conn.Get_All();
                DG_Data.DataSource = lst1;
                DG_Data.AutoGenerateColumns = false;
            }
        }

    }
}
