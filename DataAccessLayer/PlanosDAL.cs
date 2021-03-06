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
    public class PlanosDAL : IPlanosService
    {
        public Response Delete(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM PLANOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            Response resposta = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Plano excluído com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                if (ex.Message.Contains("FK__PLANO_PROFESSOR_CLIENTE__PLANO"))
                {
                    resposta.Message = "Plano não pode ser excluída, pois existem atividades vinculadas a ela!";
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

        public DataResponse<Planos> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PLANOS ORDER BY ID";

            DataResponse<Planos> resposta = new DataResponse<Planos>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Planos> planos = new List<Planos>();

                while (reader.Read())
                {
                    Planos plano = new Planos();
                    plano.ID = Convert.ToInt32(reader["ID"]);
                    plano.Duracao = Convert.ToInt32(reader["DURACAO"]);
                    plano.QtdVezes = Convert.ToInt32(reader["QTDVEZES"]);
                    plano.Valor = Convert.ToInt32(reader["VALOR"]);
                    plano.Modalidade.ID = Convert.ToInt32(reader["MODALIDADE"]);
                    planos.Add(plano);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = planos;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Planos>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Insert(Planos p)
        {
            throw new NotImplementedException();
        }

        public Response Update(Planos p)
        {
            throw new NotImplementedException();
        }
    }
}
