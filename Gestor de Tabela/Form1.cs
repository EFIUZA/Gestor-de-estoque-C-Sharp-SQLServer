using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Gestor_de_Tabela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botão pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        // Método para validar a pesquisa
        private bool validarPesquisar()
        {
            if (cbxPesquisar.Text == "")
            {
                MessageBox.Show("Selecione qual coluna deseja pesquisar.");
                cbxPesquisar.Focus();
                return false;
            }
            else if (txbPesquisar.Text == "")
            {
                MessageBox.Show("Selecione qual coluna deseja pesquisar.");
                txbPesquisar.Focus();
                return false;
            }
            return true;
        }

        // Método para realizar a pesquisa
        private void Pesquisar()
        {
            // Exibir no Status Strip
            toolStripStatusLabel1.Text = "Conectando...";
            sspConexao.Refresh();
            try
            {
                // Cria uma nova instância de SqlConnection, utilizando a string de conexão fornecida
                using (SqlConnection cn = new SqlConnection(conn.StrCon))
                {
                    // Abre a conexão com o banco de dados
                    cn.Open();

                    // Exibir no Status Strip que a conexão foi bem sucedida
                    toolStripStatusLabel1.Text = "Conectado";

                    // Mostrando dados na tabela
                    // A consulta SQL está sendo atribuída à variável sqlQuery. Essa consulta seleciona dados da tabela "EstoqueCSharp" com base na coluna escolhida (cbxPesquisar) e no valor digitado (txbPesquisar).
                    var sqlQuery = "SELECT * FROM EstoqueCSharp Where ";
                    switch (cbxPesquisar.Text)
                    {
                        case "ID":
                            sqlQuery += "ID LIKE '%" + txbPesquisar.Text + "%' Order by ID";
                            break;
                        case "SN":
                            sqlQuery += "SN LIKE'%" + txbPesquisar.Text + "%' Order by SN";
                            break;
                        case "Modelo":
                            sqlQuery += "Modelo LIKE'%" + txbPesquisar.Text + "%' Order by Modelo";
                            break;
                        case "Patrimonio":
                            sqlQuery += "Patrimonio LIKE '%" + txbPesquisar.Text + "%' Order by Patrimonio";
                            break;
                        case "LocalEquip":
                            sqlQuery += "LocalEquip LIKE '%" + txbPesquisar.Text + "%' Order by LocalEquip";
                            break;
                        case "Observacao":
                            sqlQuery += "Observacao LIKE '%" + txbPesquisar.Text + "%' Order by Observacao";
                            break;
                    }

                    // Cria uma instância do SqlDataAdapter, que permite preencher um DataTable com os resultados da consulta SQL.
                    // A consulta SQL (sqlQuery) e a conexão com o banco de dados (cn) são passadas como parâmetros para o construtor do SqlDataAdapter.
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        // Cria uma instância do DataTable para armazenar os resultados da consulta SQL.
                        using (DataTable dt = new DataTable())
                        {
                            // Executa a consulta SQL e preenche o DataTable (dt) com os resultados.
                            da.Fill(dt);

                            // Define o DataGridView (dataGridView1) como a fonte de dados para exibir os resultados da consulta SQL contidos no DataTable.
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro informando a falha ao tentar conectar e a mensagem de exceção detalhada
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);

                // Exibir no Status Strip que a conexão foi mal sucedida
                toolStripStatusLabel1.Text = "Falha ao conectar ao banco de dados";
            }
        }

        // Carregamento da tela principal
        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostrar nada na linha 
            toolStripStatusLabel1.Text = "";
        }

        // Ação ao clicar no botão adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Chamar o Formulário 2 para adicionar um novo item
            Form2 frm = new Form2(0);
            frm.ShowDialog();
        }

        // Ação ao clicar no botão editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtém o valor da coluna "ID" da linha selecionada no DataGridView
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            // Chama o Formulário 2 para editar o item com o ID selecionado
            Form2 frm = new Form2(id);
            frm.ShowDialog();
        }
    }
}
