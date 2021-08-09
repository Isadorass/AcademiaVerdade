using Entites;
using Entites.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class FuncionarioDAL : IFuncionarioService
    {

        public bool Logar(string email, string senha)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from FUNCIONARIO where EMAIL = @EMAIL AND SENHA = @SENHA";

            command.Parameters.AddWithValue("@EMAIL", email);
            command.Parameters.AddWithValue("@SENHA", senha);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    NivelAcesso.Papel = Convert.ToString(reader["PAPEL"]);
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Erro no banco de dados, contate o administrador.");
                return false;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response Delete(string cpf)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "update FUNCIONARIO" +
                "set ATIVO = false " +
                "WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cpf);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Funcionário excluído com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                if (ex.Message.Contains("FK__MODALIDADE__FUNCIONARIO"))
                {
                    resposta.Message = "Funcionário não pode ser excluído," +
                        " pois existem atividades vinculadas a ele!";
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

        public DataResponse<Funcionario> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM FUNCIONARIO" +
                "ORDER BY NOME";

            DataResponse<Funcionario> resposta = new DataResponse<Funcionario>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();

                while (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Nome = Convert.ToString(reader["NOME"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.RG = Convert.ToString(reader["RG"]);
                    funcionario.Cidade = Convert.ToString(reader["CIDADE"]);
                    funcionario.Bairro = Convert.ToString(reader["BAIRRO"]);
                    funcionario.Rua = Convert.ToString(reader["RUA"]);
                    funcionario.Complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    funcionario.Numero = Convert.ToString(reader["NUMERO"]);
                    funcionario.Salario = Convert.ToDouble(reader["SALARIO"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.Senha = Convert.ToString(reader["SENHA"]);
                    funcionario.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    funcionario.Papeis = Convert.ToString(reader["PAPEL"]);
                    funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);

                    funcionarios.Add(funcionario);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = funcionarios;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Funcionario>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Insert(Funcionario p)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO FUNCIONARIO" +
                "(NOME, CPF, RG, ENDERECO, SALARIO," +
                "COMISSAO, EMAIL, SENHA, ATIVO, PAPEL," +
                "TELEFONE, CIDADE, BAIRRO, RUA, NUMERO, COMPLEMENTO) " +
                "VALUES " +
                "(@NOME, @CPF, @RG, @ENDERECO, @SALARIO," +
                "@COMISSAO, @EMAIL, @SENHA, @ATIVO, @PAPEL," +
                "@TELEFONE, @CIDADE, @BAIRRO, @RUA, @NUMERO, @COMPLEMENTO)";
            command.Parameters.AddWithValue("@NOME", p.Nome);
            command.Parameters.AddWithValue("@CPF", p.CPF);
            command.Parameters.AddWithValue("@RG", p.RG);
            command.Parameters.AddWithValue("@CIDADE", p.Cidade);
            command.Parameters.AddWithValue("@BAIRRO", p.Bairro);
            command.Parameters.AddWithValue("@RUA", p.Rua);
            command.Parameters.AddWithValue("@NUMERO", p.Numero);
            command.Parameters.AddWithValue("@TELEFONE", p.Telefone);
            command.Parameters.AddWithValue("@SALARIO", p.Salario);
            command.Parameters.AddWithValue("@COMISSAO", p.Comissao);
            command.Parameters.AddWithValue("@EMAIL", p.Email);
            command.Parameters.AddWithValue("@SENHA", p.Senha);
            command.Parameters.AddWithValue("@PAPEL", p.Papeis);
            command.Parameters.AddWithValue("@ATIVO", p.Ativo);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Funcionário cadastrado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UQ__FUNCIONARIO"))
                {
                    resposta.Message = "Funcionário já cadastrado!";
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

        public Response Update(Funcionario p)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE FUNCIONARIO SET " +
                "NOME = @NOME," +
                "ENDERECO = @ENDERECO, SALARIO = @SALARIO," +
                "COMISSAO = @COMISSAO, EMAIL = @EMAIL," +
                "SENHA = @SENHA, ATIVO = @ATIVO, PAPEL = @PAPEL," +
                "TELEFONE = @TELEFONE, CIDADE = @CIDADE, " +
                "BAIRRO = @BAIRRO, RUA = @RUA, NUMERO = @NUMERO," +
                "COMPLEMENTO = @COMPLEMENTO" +
                "WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@NOME", p.Nome);
            command.Parameters.AddWithValue("@CPF", p.CPF);
            command.Parameters.AddWithValue("@CIDADE", p.Cidade);
            command.Parameters.AddWithValue("@RUA", p.Rua);
            command.Parameters.AddWithValue("@BAIRRO", p.Bairro);
            command.Parameters.AddWithValue("@NUMERO", p.Numero);
            command.Parameters.AddWithValue("@COMPLEMENTO", p.Complemento);
            command.Parameters.AddWithValue("@TELEFONE", p.Telefone);
            command.Parameters.AddWithValue("@SALARIO", p.Salario);
            command.Parameters.AddWithValue("@COMISSAO", p.Comissao);
            command.Parameters.AddWithValue("@EMAIL", p.Email);
            command.Parameters.AddWithValue("@SENHA", p.Senha);
            command.Parameters.AddWithValue("@PAPEL", p.Papeis);
            command.Parameters.AddWithValue("@ATIVO", p.Ativo);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Funcionário editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UQ__FUNCIONARIO"))
                {
                    resposta.Message = "Funcionário já cadastrado!";
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
