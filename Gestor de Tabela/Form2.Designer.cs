namespace Gestor_de_Tabela
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbID = new TextBox();
            txbSN = new TextBox();
            txbModelo = new TextBox();
            txbPatrimonio = new TextBox();
            txbLocalEquip = new TextBox();
            txbObservacao = new TextBox();
            lblId = new Label();
            lblSN = new Label();
            lblModelo = new Label();
            lblPatrimonio = new Label();
            lblLocalEquip = new Label();
            lblObservacao = new Label();
            btnSalvar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // txbID
            // 
            txbID.Location = new Point(46, 12);
            txbID.Name = "txbID";
            txbID.Size = new Size(100, 23);
            txbID.TabIndex = 0;
            // 
            // txbSN
            // 
            txbSN.Location = new Point(194, 12);
            txbSN.Name = "txbSN";
            txbSN.Size = new Size(100, 23);
            txbSN.TabIndex = 1;
            // 
            // txbModelo
            // 
            txbModelo.Location = new Point(76, 41);
            txbModelo.Name = "txbModelo";
            txbModelo.Size = new Size(218, 23);
            txbModelo.TabIndex = 2;
            // 
            // txbPatrimonio
            // 
            txbPatrimonio.Location = new Point(94, 70);
            txbPatrimonio.Name = "txbPatrimonio";
            txbPatrimonio.Size = new Size(200, 23);
            txbPatrimonio.TabIndex = 3;
            // 
            // txbLocalEquip
            // 
            txbLocalEquip.Location = new Point(142, 99);
            txbLocalEquip.Name = "txbLocalEquip";
            txbLocalEquip.Size = new Size(152, 23);
            txbLocalEquip.TabIndex = 4;
            // 
            // txbObservacao
            // 
            txbObservacao.Location = new Point(94, 128);
            txbObservacao.Name = "txbObservacao";
            txbObservacao.Size = new Size(200, 23);
            txbObservacao.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(19, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 6;
            lblId.Text = "ID:";
            // 
            // lblSN
            // 
            lblSN.AutoSize = true;
            lblSN.Location = new Point(158, 15);
            lblSN.Name = "lblSN";
            lblSN.Size = new Size(30, 15);
            lblSN.TabIndex = 7;
            lblSN.Text = "S/N:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(19, 44);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 8;
            lblModelo.Text = "Modelo:";
            // 
            // lblPatrimonio
            // 
            lblPatrimonio.AutoSize = true;
            lblPatrimonio.Location = new Point(19, 73);
            lblPatrimonio.Name = "lblPatrimonio";
            lblPatrimonio.Size = new Size(69, 15);
            lblPatrimonio.TabIndex = 9;
            lblPatrimonio.Text = "Patrimonio:";
            // 
            // lblLocalEquip
            // 
            lblLocalEquip.AutoSize = true;
            lblLocalEquip.Location = new Point(19, 102);
            lblLocalEquip.Name = "lblLocalEquip";
            lblLocalEquip.Size = new Size(117, 15);
            lblLocalEquip.TabIndex = 10;
            lblLocalEquip.Text = "Local/Equipamento: ";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(19, 131);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(75, 15);
            lblObservacao.TabIndex = 11;
            lblObservacao.Text = "Observação: ";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(19, 157);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(163, 157);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(131, 23);
            btnDeletar.TabIndex = 13;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 195);
            Controls.Add(btnDeletar);
            Controls.Add(btnSalvar);
            Controls.Add(lblObservacao);
            Controls.Add(lblLocalEquip);
            Controls.Add(lblPatrimonio);
            Controls.Add(lblModelo);
            Controls.Add(lblSN);
            Controls.Add(lblId);
            Controls.Add(txbObservacao);
            Controls.Add(txbLocalEquip);
            Controls.Add(txbPatrimonio);
            Controls.Add(txbModelo);
            Controls.Add(txbSN);
            Controls.Add(txbID);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbID;
        private TextBox txbSN;
        private TextBox txbModelo;
        private TextBox txbPatrimonio;
        private TextBox txbLocalEquip;
        private TextBox txbObservacao;
        private Label lblId;
        private Label lblSN;
        private Label lblModelo;
        private Label lblPatrimonio;
        private Label lblLocalEquip;
        private Label lblObservacao;
        private Button btnSalvar;
        private Button btnDeletar;
    }
}