using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
    }

    public class Ejemplo
    {
        public int campo1 { get; set; }
        public string campo2 { get; set; }
    }
    public class Region
    {
        public int  ID { get; set; }
        public string REGION { get; set; }
        public Cassandra.LocalDate Fecharg { get; set; }
        public  string[] Fechamod { get; set; }
        public string RegistradoPor { get; set; }
        public string Caracteristica { get; set; }
        public string EstadoConEstaRegion { get; set; }
    }
    public class Historial
    {
        public string[] Fechamod { get; set; }
    }
}
