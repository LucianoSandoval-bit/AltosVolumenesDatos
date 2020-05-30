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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        public int ID=0;
        public string region = "",
            estado = "",
            caracteristica = "",
            regisradoPor = "";

        private void Modificar_Load(object sender, EventArgs e)
        {
            TXT_Region.Text = region;
            TXT_Estado.Text = estado;
            TXT_Caracteristica.Text = caracteristica;
            TXT_RegistradoPor.Text = regisradoPor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = new EnlaceCassandra();
            string region = TXT_Region.Text;
            string estado = TXT_Estado.Text;
            string caracteristica = TXT_Caracteristica.Text;
            string RegistradoPor = TXT_RegistradoPor.Text;
            Boolean valida = true;
            if (region == "")
            {
                valida = false;
                MessageBox.Show("El campo region esta vacio");
            }
            if (estado == "")
            {
                valida = false;
                MessageBox.Show("El campo estado esta vacio");
            }
            if (caracteristica == "")
            {
                valida = false;
                MessageBox.Show("El campo caracteristica esta vacio");
            }
            if (RegistradoPor == "")
            {
                valida = false;
                MessageBox.Show("El campo de 'registrado por' esta vacio");
            }
            if (valida)
            {
                string []fechaMod = {""};
                DateTime Today = DateTime.Today;
                fechaMod [0]= Today.Year.ToString() + "-" + Today.Month.ToString() + "-" + Today.Day.ToString();                
                conn.UpdateDatos(ID, region, RegistradoPor, estado, caracteristica, fechaMod);
                DialogResult dlg;
                dlg = MessageBox.Show("La region se actualizo correctamente", "Modificar");

                    this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Dlg;
            Dlg = MessageBox.Show("¿Esta seguro de que desea cancelar esta operacion?", "Cancelar", MessageBoxButtons.YesNo);
            if (Dlg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
