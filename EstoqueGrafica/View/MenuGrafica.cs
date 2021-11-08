using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EstoqueGrafica.Model;
using EstoqueGrafica.Controller;


namespace EstoqueGrafica.View
{
    public partial class MenuGrafica : Form
    {
        public MenuGrafica()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirEstoque", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@nome", textBoxProduto.Text);
                comando.Parameters.AddWithValue("@descricao", textBoxDescricao.Text);
                comando.Parameters.AddWithValue("@quantidade", textBoxQtd.Text);
                comando.Parameters.AddWithValue("@valor", textBoxValor.Text);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Produto cadastrado com sucesso! Deseja cadastrar outro livro ou sair?", "Novo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    textBoxProduto.Clear();
                    textBoxDescricao.Clear();
                    textBoxQtd.Clear();
                    textBoxValor.Clear();
                }
                else
                {
                    this.Close();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca", "Atenção");
                textBoxBuscar.Focus();

                return;
            }

            Grafica.Nome_produto = textBoxBuscar.Text;
            GraficaController grafica = new();    
            dataGridViewMenu.DataSource = GraficaController.visuNomeProduto();


            dataGridViewMenu.Columns[0].Visible = false;
            dataGridViewMenu.Columns[1].Visible = false;
            dataGridViewMenu.Columns[2].Visible = false;
            dataGridViewMenu.Columns[3].Visible = false;
            dataGridViewMenu.Columns[4].Visible = false;

            if (dataGridViewMenu.Rows.Count == 1)
            {
                MessageBox.Show("Não existe este Nome", "Atenção");
            }


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (tbCodigo.Text == "")
            {
                MessageBox.Show("Digite um código para a busca", "Atenção");
                tbCodigo.Focus();
                tbCodigo.Clear();
                tbProduto.Clear();
                tbDescricao.Clear();
                tbQtd.Clear();
                tbValor.Clear();

                return;
            }
            else
            {
                Grafica.Id = Convert.ToInt32(tbCodigo.Text);
                GraficaController grafica = new GraficaController();
                grafica.visuCodigoProduto();
                tbProduto.Text = Grafica.Nome_produto;
                tbDescricao.Text = Grafica.Descricao_produto;
                tbQtd.Text = Grafica.Quantidade_produto;
                tbValor.Text = Grafica.Valor_produto;
                tbCodigo.Text = Grafica.Id.ToString();
                btnAlterar.Enabled = true;
                btnDeletar.Enabled = true;
            }

            if (Grafica.Retorno == "False")
            {

                limpaTudo();
            }
        }

        private void limpaTudo()
        {

            Grafica.Id = 0;
            Grafica.Nome_produto = "";
            Grafica.Descricao_produto = "";
            Grafica.Quantidade_produto = "";
            Grafica.Valor_produto = "";
            tbCodigo.Clear();
            tbProduto.Clear();
            tbDescricao.Clear();
            tbQtd.Clear();
            tbValor.Clear();

            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            GraficaController graficaController = new GraficaController();

            Grafica.Id = Convert.ToInt32(tbCodigo.Text);
            graficaController.alterarProduto();
            Grafica.Nome_produto = tbProduto.Text;
            Grafica.Descricao_produto = tbDescricao.Text;
            Grafica.Quantidade_produto = tbQtd.Text;
            Grafica.Valor_produto = tbValor.Text;

      

            limpaTudo();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Grafica.Id = Convert.ToInt32(tbCodigo.Text);

            GraficaController graficaController = new GraficaController();
            graficaController.deletarProduto();

            limpaTudo();
        }

    }
}

    
