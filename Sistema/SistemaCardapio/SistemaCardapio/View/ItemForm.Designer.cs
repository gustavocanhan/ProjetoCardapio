namespace SistemaCardapio.View
{
    partial class ItemForm
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
            lblPreco = new Label();
            txtPreco = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dgvItens = new DataGridView();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(13, 66);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(13, 85);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(220, 23);
            txtNome.TabIndex = 1;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(246, 66);
            lblPreco.Margin = new Padding(4, 0, 4, 0);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preco:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(249, 85);
            txtPreco.Margin = new Padding(4, 3, 4, 3);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(112, 23);
            txtPreco.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(13, 121);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(13, 140);
            txtDescricao.Margin = new Padding(4, 3, 4, 3);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(740, 48);
            txtDescricao.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(372, 66);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(375, 85);
            cmbCategoria.Margin = new Padding(4, 3, 4, 3);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(176, 23);
            cmbCategoria.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(571, 81);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 27);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(667, 82);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 27);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvItens
            // 
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Location = new Point(13, 207);
            dgvItens.Margin = new Padding(4, 3, 4, 3);
            dgvItens.Name = "dgvItens";
            dgvItens.Size = new Size(737, 374);
            dgvItens.TabIndex = 12;
            dgvItens.CellClick += dgvItens_CellClick;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(13, 12);
            btnVoltar.Margin = new Padding(4, 3, 4, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(88, 27);
            btnVoltar.TabIndex = 14;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 593);
            Controls.Add(btnVoltar);
            Controls.Add(dgvItens);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item";
            Load += ItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btnVoltar;
    }
}