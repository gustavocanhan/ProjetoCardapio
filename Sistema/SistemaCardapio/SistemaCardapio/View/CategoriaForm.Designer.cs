namespace SistemaCardapio.View
{
    partial class CategoriaForm
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
            lblNome = new Label();
            txtNome = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dgvCategorias = new DataGridView();
            btnVoltar = new Button();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(9, 58);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(9, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(168, 23);
            txtNome.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(501, 76);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(582, 76);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(9, 121);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(648, 228);
            dgvCategorias.TabIndex = 6;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(195, 58);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(195, 76);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(279, 23);
            txtDescricao.TabIndex = 9;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 361);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(btnVoltar);
            Controls.Add(dgvCategorias);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "CategoriaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriaForm";
            Load += CategoriaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblDescricao;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dgvCategorias;
        private Button btnVoltar;
        private Label label2;
        private TextBox txtDescricao;
    }
}