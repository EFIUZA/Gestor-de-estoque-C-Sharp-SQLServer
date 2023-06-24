namespace Gestor_de_Tabela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPesquisar = new Button();
            dataGridView1 = new DataGridView();
            btnAdicionar = new Button();
            txbPesquisar = new TextBox();
            btnEditar = new Button();
            cbxPesquisar = new ComboBox();
            sspConexao = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sspConexao.SuspendLayout();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(139, 29);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 53);
            btnPesquisar.TabIndex = 0;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 336);
            dataGridView1.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(239, 29);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 53);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txbPesquisar
            // 
            txbPesquisar.Location = new Point(12, 59);
            txbPesquisar.Name = "txbPesquisar";
            txbPesquisar.Size = new Size(121, 23);
            txbPesquisar.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(320, 29);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 53);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // cbxPesquisar
            // 
            cbxPesquisar.FormattingEnabled = true;
            cbxPesquisar.Items.AddRange(new object[] { "ID", "SN", "Modelo", "Patrimonio", "LocalEquip", "Observacao" });
            cbxPesquisar.Location = new Point(12, 29);
            cbxPesquisar.Name = "cbxPesquisar";
            cbxPesquisar.Size = new Size(121, 23);
            cbxPesquisar.TabIndex = 5;
            // 
            // sspConexao
            // 
            sspConexao.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            sspConexao.Location = new Point(0, 428);
            sspConexao.Name = "sspConexao";
            sspConexao.Size = new Size(800, 22);
            sspConexao.TabIndex = 6;
            sspConexao.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sspConexao);
            Controls.Add(cbxPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(txbPesquisar);
            Controls.Add(btnAdicionar);
            Controls.Add(dataGridView1);
            Controls.Add(btnPesquisar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            sspConexao.ResumeLayout(false);
            sspConexao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView dataGridView1;
        private Button btnAdicionar;
        private TextBox txbPesquisar;
        private Button btnEditar;
        private ComboBox cbxPesquisar;
        private StatusStrip sspConexao;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}