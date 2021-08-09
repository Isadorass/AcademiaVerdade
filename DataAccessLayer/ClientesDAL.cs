﻿using Entites;
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
    public class ClientesDAL : IClientesService
    {
        public int BuscarPeloId(string cpf)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM CLIENTES ORDER BY NOME";

            DataResponse<Clientes> resposta = new DataResponse<Clientes>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Clientes> clientes = new List<Clientes>();

                while (reader.Read())
                {
                    Clientes cliente = new Clientes();
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.TelefonePrincipal = Convert.ToString(reader["TELEFONE_1"]);
                    cliente.TelefoneSecundario = Convert.ToString(reader["TELEFONE_2"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    cliente.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    cliente.DataMatricula = Convert.ToDateTime(reader["DATA_MATRICULA"]);
                    cliente.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    cliente.Genero = Convert.ToString(reader["GENERO"]);

                    clientes.Add(cliente);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = clientes;
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Clientes>();
                return resposta;
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
            command.CommandText = "update CLIENTE set ATIVO = false" +
                "WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cpf);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Cliente desativado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK__MODALIDADE__CLIENTE"))
                {
                    resposta.Message = "Cliente não pode ser excluída, pois existem atividades vinculadas a ele!";
                    return resposta;
                }
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Clientes> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM CLIENTES ORDER BY NOME";

            DataResponse<Clientes> resposta = new DataResponse<Clientes>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Clientes> clientes = new List<Clientes>();

                while (reader.Read())
                {
                    Clientes cliente = new Clientes();
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.TelefonePrincipal = Convert.ToString(reader["TELEFONE_1"]);
                    cliente.TelefoneSecundario = Convert.ToString(reader["TELEFONE_2"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    cliente.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    cliente.DataMatricula = Convert.ToDateTime(reader["DATA_MATRICULA"]);
                    cliente.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    cliente.Genero = Convert.ToString(reader["GENERO"]);

                    clientes.Add(cliente);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = clientes;
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Clientes>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Insert(Clientes c)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO CLIENTES (NOME, CPF, RG, TELEFONE_1," +
                "TELEFONE_2, GENERO, EMAIL, DATA_NASCIMENTO, DATA_MATRICULA, ATIVO) " +
                "VALUES " +
                "(@NOME, @CPF, @RG, @TELEFONE_1" +
                ", @TELEFONE_2, @GENERO, @EMAIL, @DATA_NASCIMENTO," +
                "@DATA_MATRICULA, @ATIVO)";

            command.Parameters.AddWithValue("@NOME", c.Nome);
            command.Parameters.AddWithValue("@CPF", c.CPF);
            command.Parameters.AddWithValue("@RG", c.RG);
            command.Parameters.AddWithValue("@TELEFONE_1", c.TelefonePrincipal);
            command.Parameters.AddWithValue("@TELEFONE_2", c.TelefoneSecundario);
            command.Parameters.AddWithValue("@GENERO", c.Genero);
            command.Parameters.AddWithValue("@EMAIL", c.Email);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", c.DataNascimento);
            command.Parameters.AddWithValue("@DATA_MATRICULA", c.DataMatricula);
            command.Parameters.AddWithValue("@ATIVO", c.Ativo);            

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Cliente cadastrado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UQ__CLIENTES"))
                {
                    resposta.Message = "Cliente já cadastrado!";
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

        public Response Update(Clientes c)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE CLIENTE SET NOME = @NOME," +
                "TELEFONE_1 = @TELEFONE_1, TELEFONE_2 = @TELEFONE_2," +
                "EMAIL = @EMAIL, DATA_MATRICULA = @DATA_MATRICULA," +
                "ATIVO = @ATIVO, GENERO = @GENERO" +
                "WHERE CPF = @CPF";

            command.Parameters.AddWithValue("@NOME", c.Nome);
            command.Parameters.AddWithValue("@TELEFONE_1", c.TelefonePrincipal);
            command.Parameters.AddWithValue("@TELEFONE_2", c.TelefoneSecundario);
            command.Parameters.AddWithValue("@EMAIL", c.Email);
            command.Parameters.AddWithValue("@DATA_MATRICULA", c.DataMatricula);
            command.Parameters.AddWithValue("@ATIVO", c.Ativo);
            command.Parameters.AddWithValue("@GENERO", c.Genero);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Cliente editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UQ__CLIENTES"))
                {
                    resposta.Message = "Cliente já cadastrado!";
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
