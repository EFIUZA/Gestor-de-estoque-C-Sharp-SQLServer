using System.Data.SqlClient;

namespace Gestor_de_Tabela
{
    public partial class Form2 : Form
    {
        int id = 0;
        public Form2(int id)
        {
            // Inicializa o formulário e seus componentes
            InitializeComponent();
            this.id = id;

            // Se o ID for maior que 0, significa que estamos editando um registro existente, então obtemos os dados desse registro
            if (this.id > 0) GetPesquisa(id);
        }

        // Obtém os dados do registro com o ID fornecido
        private void GetPesquisa(int id)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn.StrCon))
                {
                    cn.Open();
                    var sql = "Select * from EstoqueCSharp Where id =" + id;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    // Preenche os campos do formulário com os dados do registro
                                    txbID.Text = dr["ID"].ToString();
                                    txbSN.Text = dr["SN"].ToString();
                                    txbModelo.Text = dr["Modelo"].ToString();
                                    txbPatrimonio.Text = dr["Patrimonio"].ToString();
                                    txbLocalEquip.Text = dr["LocalEquip"].ToString();
                                    txbObservacao.Text = dr["Observacao"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Ação ao clicar no botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Tenta executar o código dentro do bloco try
            try
            {
                // Cria uma nova instância de SqlConnection utilizando a string de conexão fornecida
                using (SqlConnection cn = new SqlConnection(conn.StrCon))
                {
                    // Abre a conexão com o banco de dados
                    cn.Open();
                    var sql = "";

                    // Verifica se o ID é igual a 0. Se for, estamos adicionando um novo registro. Caso contrário, estamos atualizando um registro existente.
                    if (this.id == 0) sql = "INSERT INTO EstoqueCSharp (ID, SN, Modelo, Patrimonio, LocalEquip, Observacao) VALUES (@ID, @SN, @Modelo, @Patrimonio, @LocalEquip, @Observacao)";
                    else sql = "UPDATE EstoqueCSharp Set ID=@ID, SN=@SN, Modelo=@Modelo, Patrimonio=@Patrimonio, LocalEquip=@LocalEquip, Observacao=@Observacao WHERE id=" + this.id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        // Adiciona parâmetros com valores para a consulta SQL
                        cmd.Parameters.AddWithValue("@ID", txbID.Text);
                        cmd.Parameters.AddWithValue("@SN", txbSN.Text);
                        cmd.Parameters.AddWithValue("@Modelo", txbModelo.Text);
                        cmd.Parameters.AddWithValue("@Patrimonio", txbPatrimonio.Text);
                        cmd.Parameters.AddWithValue("@LocalEquip", txbLocalEquip.Text);
                        cmd.Parameters.AddWithValue("@Observacao", txbObservacao.Text);

                        // Executa a consulta SQL para inserir ou atualizar os dados na tabela
                        cmd.ExecuteNonQuery();
                    }

                    // Exibe uma mensagem informando que os dados foram salvos com sucesso
                    MessageBox.Show("Dados salvos!");
                }
            }
            // Captura qualquer exceção lançada no bloco try e trata no bloco catch
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro informando o problema ao salvar os dados e a mensagem de exceção detalhada
                MessageBox.Show("Erro ao salvar no banco de dados\n\n" + ex.Message);
            }

            // Fecha o formulário após salvar os dados
            Close();
        }

        // Ação ao clicar no botão Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn.StrCon))
                {
                    cn.Open();
                    var sql = "DELETE FROM EstoqueCSharp WHERE ID=@ID";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@ID", txbID.Text);
                        cmd.ExecuteNonQuery();
                    }

                    // Exibe uma mensagem informando que os dados foram excluídos com sucesso
                    MessageBox.Show("Dados Excluídos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados do banco\n\n" + ex.Message);
            }

            // Fecha o formulário após excluir os dados
            Close();
        }
    }
}
