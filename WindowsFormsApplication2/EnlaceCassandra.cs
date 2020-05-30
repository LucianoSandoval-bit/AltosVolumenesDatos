using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class EnlaceCassandra
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        private static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        public void InsertaDatos(int id, string region,string RegistradoPor, string estado,string caracteristica,string fechaReg )
        {
            try
            {
                conectar();
                
                string qry = " INSERT INTO Regiones(ID,REGION,FechaRG,RegistradoPor,Caracteristica,EstadoConEstaRegion)VALUES(";
                qry = qry + id.ToString();
                qry = qry + ",'";
                qry = qry + region;
                qry = qry + ",'";
                qry = qry + fechaReg;
                qry = qry + ",'";
                qry = qry + RegistradoPor;
                qry = qry + ",'";
                qry = qry + caracteristica;
                qry = qry + ",'";
                qry = qry + estado;
                qry = qry + " ');";


                string query = "INSERT INTO Regiones(ID,REGION,FechaRG,RegistradoPor,Caracteristica,EstadoConEstaRegion)VALUES({0}, '{1}', '{2}','{3}','{4}','{5}');";
                qry = string.Format(query, id, region,fechaReg,RegistradoPor,caracteristica,estado);

                _session.Execute(qry);
            }
            catch(Exception e)
            {
                throw e;   
            }
            finally
            {
                // desconectar o cerrar la conexión
            }
        }
        public void UpdateDatos(int id, string region, string RegistradoPor, string estado, string caracteristica, string[] fechaReg)
        {
            try
            {
                conectar();
                string qry = " UPDATE  Regiones SET ";
                qry = qry + "Region='"+region+"'";
                qry = qry + ",";
                qry = qry + "EstadoConEstaRegion='" +estado+"',";
                qry = qry + "Fechamod=Fechamod+";
                qry = qry + "{'";
                qry = qry + fechaReg[0];
                qry = qry + "'},";
                qry = qry + "RegistradoPor='";
                qry = qry + RegistradoPor;
                qry = qry + "',";
                qry = qry + "Caracteristica='";
                qry = qry + caracteristica;
                qry = qry + "'";
                qry = qry + "WHERE ID=";
                qry = qry + id;
                qry = qry + " ;";

                
                //string query = "INSERT INTO Regiones(ID,REGION,FechaMod,RegistradoPor,Caracteristica,EstadoConEstaRegion)VALUES({0}, '{1}', '{2}','<{3}>','{4}','{5}');";
                //qry = string.Format(query, id, region, fechaReg, RegistradoPor, caracteristica, estado);

                _session.Execute(qry);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
            }
        }
        public void DeleteDato(int ID)
        {
            string query = "DELETE FROM Regiones WHERE ID=" + ID + ";";
            conectar();
            _session.Execute(query);
        }
        // Ejemplo d
        public IEnumerable<Ejemplo> Get_One(int dato)
        {
            string query = "SELECT campo1, campo2 FROM ejemplo WHERE campo1 = ?;";
            conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Ejemplo> users = mapper.Fetch<Ejemplo>(query, dato);

            desconectar();
            return users.ToList();
        }

        public List<Region> Get_All()
        {
            string query = "SELECT * FROM Regiones;";
            conectar();
            
            IMapper mapper = new Mapper(_session);
            IEnumerable<Region> users = mapper.Fetch<Region>(query);

            desconectar();
            return users.ToList();
            
        }
        public List<Region> Get_Historial(int ID)
        {
            string query = "SELECT FechaMod FROM Regiones WHERE ID="+ID+";";
            conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<Region> users = mapper.Fetch<Region>(query);

            desconectar();
            return users.ToList();

        }
        // Ejemplo de leer row x row
        public void GetOne()
        {
            conectar();

            string query ="SELECT campo1, campo2 FROM ejemplo;";

            // Execute a query on a connection synchronously 
            var rs = _session.Execute(query);
            
            // Iterate through the RowSet 
            foreach (var row in rs)
            {
                var value = row.GetValue<int>("campo1");
                // Do something with the value 
                var texto = row.GetValue<string>("campo2");
                // Do something with the value 

                MessageBox.Show(texto, value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                /*
                RowSet rsUsers = session.Execute(qry);

                ////////////////////////////////////////////////
                var users = new List<UserModel>();
                foreach (var userRow in rsUsers)
                {
                    //users.Add(ReflectionTools.GetSingleEntryDynamicFromReader<UserModel>(userRow));
                }

                foreach (UserModel user in users)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", user.Id, user.FirstName, user.LastName, user.Country, user.IsActive);
                }
                */

            }
        }

    }
}
