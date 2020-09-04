using APIPets.Context;
using APIPets.Domains;
using APIPets.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIPets.Repositories
{
    public class TipoDePetRepository : ITipoDePet
    {

        ClinicaContext conexao = new ClinicaContext();

        SqlCommand cmd = new SqlCommand();

        public TipoDePet Alterar(int id, TipoDePet t)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "UPDATE TipoDePet SET " +
                "Descricao = @descricao WHERE IdTipoPet = @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Parameters.AddWithValue("@descricao", t.Descricao);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
            return t;
        }

        public TipoDePet BuscarID(int id)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "SELECT * FROM TipoDePet WHERE IdTipoPet = @id";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dados = cmd.ExecuteReader();

            TipoDePet t = new TipoDePet();

            while (dados.Read())
            {
                t.IdTipoPet = Convert.ToInt32(dados.GetValue(0));
                t.Descricao= dados.GetValue(1).ToString();
            }

            conexao.Desconectar();

            return t;
        }

        public TipoDePet Cadastrar(TipoDePet t)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText =
                "INSERT INTO TipoDePet(Descricao) " +
                "VALUES " +
                "(@descricao)";

            cmd.Parameters.AddWithValue("@descricao", t.Descricao);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();

            return t;
        }

        public void Excluir(int id)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "DELETE FROM TipoDePet WHERE IdTipoPet = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
        }

        public List<TipoDePet> ListarTodos()
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "SELECT * FROM TipoDePet";

            SqlDataReader dados = cmd.ExecuteReader();

            List<TipoDePet> tipos = new List<TipoDePet>();

            while (dados.Read())
            {
                tipos.Add(
                    new TipoDePet
                    {
                        IdTipoPet = Convert.ToInt32(dados.GetValue(0)),
                        Descricao = dados.GetValue(1).ToString()
                    }
                );
            }

            conexao.Desconectar();

            return tipos;
        }
    }
}
