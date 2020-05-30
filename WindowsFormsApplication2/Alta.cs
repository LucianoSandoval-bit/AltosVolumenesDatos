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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }
        public int ID;
        private void Alta_Load(object sender, EventArgs e)
        {

        }
        private void TXT_NoNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Dlg;
            Dlg = MessageBox.Show("¿Esta seguro de que desea cancelar esta operacion?","Cancelar",MessageBoxButtons.YesNo);
            if(Dlg==DialogResult.Yes)
            {
             this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string region = TXT_Region.Text;
            string estado = TXT_Estado.Text;
            string caracteristica = TXT_Caracteristica.Text;
            string RegistradoPor = TXT_RegistradoPor.Text;
            Boolean valida = true;
            if (region== "")
            {
                valida = false;
                MessageBox.Show("El campo region esta vacio");
            }
            if (estado== "")
            {
                valida = false;
                MessageBox.Show("El campo estado esta vacio");
            }
            if (caracteristica== "")
            {
                valida = false;
                MessageBox.Show("El campo caracteristica esta vacio");
            }
            if (RegistradoPor== "")
            {
                valida = false;
                MessageBox.Show("El campo de 'registrado por' esta vacio");
            }
            if(valida)
            {
            string fechaRg="";
            DateTime Today=DateTime.Today;
            fechaRg = Today.Year.ToString() +"-"+Today.Month.ToString()+"-"+Today.Day.ToString();

                var conn = new EnlaceCassandra();
                conn.InsertaDatos(ID,region,RegistradoPor,estado,caracteristica,fechaRg);
                DialogResult dlg;
               dlg = MessageBox.Show("La region se agrego correctamente. ¿Desea agregar otra?","Agregar",MessageBoxButtons.YesNo);
                if(dlg== DialogResult.Yes)
                {
                    List<Region> lst1 = new List<Region>();
                    lst1 = conn.Get_All();
                    int IDM = lst1[0].ID;
                    for (int i = 0; i < lst1.Count(); i++)
                    {
                        if (IDM < lst1[i].ID)
                        {
                            IDM = lst1[i].ID;
                        }
                    }
                    ID =  IDM+1;
                    TXT_Region.Text = "";
                    TXT_Estado.Text = "";
                    TXT_Caracteristica.Text = "";
                    TXT_RegistradoPor.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
