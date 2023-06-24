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

        // Bot�o pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        // M�todo para validar a pesquisa
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

        // M�todo para realizar a pesquisa
        private void Pesquisar()
        {
            // Exibir no Status Strip
            toolStripStatusLabel1.Text = "Conectando...";
            sspConexao.Refresh();
            try
            {
                // Cria uma nova inst�ncia de SqlConnection, utilizando a string de conex�o fornecida
                using (SqlConnection cn = new SqlConnection(conn.StrCon))
                {
                    // Abre a conex�o com o banco de dados
                    cn.Open();

                    // Exibir no Status Strip que a conex�o foi bem sucedida
                    toolStripStatusLabel1.Text = "Conectado";

                    // Mostrando dados na tabela
                    // A consulta SQL est� sendo atribu�da � vari�vel sqlQuery. Essa consulta seleciona dados da tabela "EstoqueCSharp" com base na coluna escolhida (cbxPesquisar) e no valor digitado (txbPesquisar).
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

                    // Cria uma inst�ncia do SqlDataAdapter, que permite preencher um DataTable com os resultados da consulta SQL.
                    // A consulta SQL (sqlQuery) e a conex�o com o banco de dados (cn) s�o passadas como par�metros para o construtor do SqlDataAdapter.
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        // Cria uma inst�ncia do DataTable para armazenar os resultados da consulta SQL.
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
                // Exibe uma mensagem de erro informando a falha ao tentar conectar e a mensagem de exce��o detalhada
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);

                // Exibir no Status Strip que a conex�o foi mal sucedida
                toolStripStatusLabel1.Text = "Falha ao conectar ao banco de dados";
            }
        }

        // Carregamento da tela principal
        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostrar nada na linha 
            toolStripStatusLabel1.Text = "";
        }

        // A��o ao clicar no bot�o adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Chamar o Formul�rio 2 para adicionar um novo item
            Form2 frm = new Form2(0);
            frm.ShowDialog();
        }

        // A��o ao clicar no bot�o editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obt�m o valor da coluna "ID" da linha selecionada no DataGridView
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            // Chama o Formul�rio 2 para editar o item com o ID selecionado
            Form2 frm = new Form2(id);
            frm.ShowDialog();
        }
    }
}
