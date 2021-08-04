using Entites;
using Entites.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UsuariosDAL : IUsuariosService
    {
        public Response Delete(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM USUARIO WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);


            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Usuario excluído com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                if (ex.Message.Contains("FK__PROFESSOR__USUAR"))
                {
                    resposta.Message = "Usuario não pode ser excluído, pois existem vinculos a ele!";
                    return resposta;
                }
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Usuarios> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM USUARIOS ORDER BY ID";

            DataResponse<Usuarios> resposta = new DataResponse<Usuarios>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Usuarios> usuarios = new List<Usuarios>();

                while (reader.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.ID = Convert.ToInt32(reader["ID"]);
                    usuario.Nome = Convert.ToString(reader["NOME"]);
                    usuario.Email = Convert.ToString(reader["EMAIL"]);
                    usuario.Nome = Convert.ToString(reader["SENHA"]);
                    usuario.Nome = Convert.ToString(reader["PAPEL"]);
                    usuarios.Add(usuario);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = usuarios;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Usuarios>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Insert(Usuarios u)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO USUARIO VALUES (@NOME, @EMAIL, @SENHA, @PAPEL)";
            command.Parameters.AddWithValue("@NOME", u.Nome);
            command.Parameters.AddWithValue("@EMAIL", u.Email);
            command.Parameters.AddWithValue("@SENHA", u.Senha);
            command.Parameters.AddWithValue("@PAPEL", u.Papel);



            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Usuario cadastrado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UQ__USUARIO"))
                {
                    resposta.Message = "Usuario já cadastrado!";
                    return resposta;
                }

                resposta.Message = "Erro no banco de dados, contate o administrador.";
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Update(Usuarios u)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE USUARIOS SET NOME = @NOME WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", u.Nome);
            command.Parameters.AddWithValue("@ID", u.ID);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Usuario editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UQ__USUARIOS"))
                {
                    resposta.Message = "Usuario já cadastrado!";
                    return resposta;
                }

                resposta.Message = "Erro no banco de dados, contate o administrador.";
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
