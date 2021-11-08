using System.Data;
using System.Data.SqlClient;
using EstoqueGrafica.Model;
using System.Windows.Forms;

namespace EstoqueGrafica.Controller
{
    class GraficaController
    {
        public void cadastrarProduto()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirEstoque", conexao);
            comando.CommandType = CommandType.StoredProcedure;
            try
            {

                comando.Parameters.AddWithValue("@produto", Grafica.Nome_produto);
                comando.Parameters.AddWithValue("@descricao", Grafica.Descricao_produto);
                comando.Parameters.AddWithValue("@quantidade", Grafica.Quantidade_produto);
                comando.Parameters.AddWithValue("@valor", Grafica.Valor_produto);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Produto cadastrado com sucesso! \n" +
                    "Deseja cadastrar outro produto?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Grafica.Retorno = "False";
                    return;
                }
                else
                {
                    Grafica.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Produto não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }

        public void visuCodigoProduto()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pBuscaCodigoEstoque", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {

                comando.Parameters.AddWithValue("@codigo", Grafica.Id);
                conexao.Open();

                var tabelaDados = comando.ExecuteReader();

                if (tabelaDados.Read())
                {
                    Grafica.Nome_produto = tabelaDados["produto"].ToString();
                    Grafica.Descricao_produto = tabelaDados["descricao"].ToString();
                    Grafica.Quantidade_produto = tabelaDados["quantidade"].ToString();
                    Grafica.Valor_produto = tabelaDados["valor"].ToString();
                    Grafica.Retorno = "True";
                }
                else
                {
                    MessageBox.Show("Produto não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Grafica.Retorno = "False";
                }

            }
            catch
            {
                MessageBox.Show("Não conseguimos localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }
        public static BindingSource visuNomeProduto()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaNomeEstoque", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            comandos.Parameters.AddWithValue("@nome",  "%"+Grafica.Nome_produto+"%");
            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }


        public void alterarProduto()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pAlterarEstoque", conexao);
            comando.CommandType = CommandType.StoredProcedure;
      

            try
            {
                comando.Parameters.AddWithValue("@codigo", Grafica.Id);
                comando.Parameters.AddWithValue("@nome", Grafica.Nome_produto);
                comando.Parameters.AddWithValue("@descricao", Grafica.Descricao_produto);
                comando.Parameters.AddWithValue("@quantidade", Grafica.Quantidade_produto);
                comando.Parameters.AddWithValue("@valor", Grafica.Valor_produto);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto alterado com sucesso!");
                Grafica.Retorno = "True";
            }
            catch
            {
                MessageBox.Show("Não foi possível alterar o produto.");
                Grafica.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void deletarProduto()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pDeletarEstoque", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@codigo", Grafica.Id);
                conexao.Open();
                comando.ExecuteNonQuery();
                Grafica.Retorno = "True";
                MessageBox.Show("Produto excluído com sucesso!");

            }
            catch
            {
                MessageBox.Show("Atenção! Produto não foi deletado.");
                Grafica.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

    }
}