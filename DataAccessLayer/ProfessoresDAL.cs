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
    public class ProfessoresDAL : IProfessoresService
    {
        public Response Delete(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM PROFESSORES WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Professor excluído com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                if (ex.Message.Contains("FK__PLANO_PROFESSOR_CLIENTE__PROFESSORES"))
                {
                    resposta.Message = "Modalidade não pode ser excluída, pois existem atividades vinculadas a ela!";
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

        public DataResponse<Professores> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PROFESSORES ORDER BY ID";

            DataResponse<Professores> resposta = new DataResponse<Professores>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Professores> professores = new List<Professores>();

                while (reader.Read())
                {
                    Professores professor = new Professores();
                    professor.ID = Convert.ToInt32(reader["ID"]);
                    professor.Nome = Convert.ToString(reader["NOME"]);
                    professores.Add(professor);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = professores;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Professores>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Insert(Professores p)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO PROFESSORES VALUES (@NOME, @CPF," +
                                                                   "@RG, @ENDERECO," +
                                                                   "@TELEFONE, @SALARIO," +
                                                                   "@COMISSAO, @EMAIL," +
                                                                   "@SENHA, @USUSARIO)";
            command.Parameters.AddWithValue("@NOME", p.Nome);
            command.Parameters.AddWithValue("@CPF", p.CPF);
            command.Parameters.AddWithValue("@RG", p.RG);
            command.Parameters.AddWithValue("@ENDERECO", p.Endereco);
            command.Parameters.AddWithValue("@TELEFONE", p.Telefone);
            command.Parameters.AddWithValue("@SALARIO", p.Salario);
            command.Parameters.AddWithValue("@COMISSAO", p.Comissao);
            command.Parameters.AddWithValue("@EMAIL", p.Email);
            command.Parameters.AddWithValue("@SENHA", p.Senha);
            command.Parameters.AddWithValue("@USUARIO", p.Usuarios);


            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Professor cadastrado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UQ__PROFESSORES"))
                {
                    resposta.Message = "Professor já cadastrada!";
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

        public Response Update(Professores p)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE PROFESSORES SET NOME = @NOME WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", p.Nome);
            command.Parameters.AddWithValue("@ID", p.ID);


            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Professor editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UQ__PROFESSORES"))
                {
                    resposta.Message = "Professor já cadastrado!";
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
