using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace pryValinottiTP240524
{
    internal class clsUsuario
    {
        
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS;

        string rutaArchivo;
        public string estadoConexion;

        public string Nombre { get; set; }
        public string Perfil { get; set; }
        public string Password { get; set; }

        public clsUsuario()
        {
            try
            {
                rutaArchivo = @"../../../Archivos/BDusuarios.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
                conexionBD.Open();

                objDS = new DataSet();

                estadoConexion = "Conectado";
                conexionBD.Close();
            }
            catch (Exception error)
            {
                conexionBD.Close();
                estadoConexion = error.Message;
            }
        }

        public void RegistroLogInicioSesion()
        {
            try
            {
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = "Logs";
                conexionBD.Open();

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();
                nuevoRegistro["Categoria"] = "Inicio Sesión";
                DateTime fecha = DateTime.Now;
                nuevoRegistro["FechaHora"] = fecha.ToString("dd/MM/aaaa");
                nuevoRegistro["Descripcion"] = "Inicio exitoso";

                objTabla.Rows.Add(nuevoRegistro);
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");
                conexionBD.Close();
                estadoConexion = "Registro exitoso de log";
                MessageBox.Show(estadoConexion);
            }
            catch (Exception error)
            {
                conexionBD.Close();
                estadoConexion = error.Message;
                MessageBox.Show(estadoConexion);
            }

        }

        public bool ValidarUsuario(string nombreUser, string passUser)
        {
            try
            {
                comandoBD = new OleDbCommand();

                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuario";

                lectorBD = comandoBD.ExecuteReader();

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[1].ToString() == nombreUser && lectorBD[2].ToString() == passUser)
                        {
                            estadoConexion = "Usuario EXISTE";
                            return true;
                        }
                    }
                }
                MessageBox.Show("Usuario NO EXISTE");
                conexionBD.Close();
                return false;

            }
            catch (Exception error)
            {
                conexionBD.Close();
                estadoConexion = error.Message;
                return false;
            }
        }

        public bool registrarUsuario(clsUsuario usuario)
        {
            try
            {
                comandoBD = new OleDbCommand();
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuario";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Usuario");

                DataTable objTabla = objDS.Tables["Usuario"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Nombre"] = usuario.Nombre;
                nuevoRegistro["Contraseña"] = usuario.Password;
                nuevoRegistro["Perfil"] = usuario.Perfil;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Usuario");

                conexionBD.Close();
                return true;
            }
            catch (Exception error)
            {
                conexionBD.Close();
                MessageBox.Show(error.Message);
                return false;
            }
        }


    }
}
