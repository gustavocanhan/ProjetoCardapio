namespace SistemaCardapio.View
{
    partial class TelaInicialForm
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
            btnCategoria = new Button();
            btnItem = new Button();
            SuspendLayout();
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(12, 12);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(210, 114);
            btnCategoria.TabIndex = 0;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnItem
            // 
            btnItem.Location = new Point(239, 12);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(210, 114);
            btnItem.TabIndex = 1;
            btnItem.Text = "Item";
            btnItem.UseVisualStyleBackColor = true;
            btnItem.Click += btnItem_Click;
            // 
            // TelaInicialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 146);
            Controls.Add(btnItem);
            Controls.Add(btnCategoria);
            Name = "TelaInicialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaInicialForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategoria;
        private Button btnItem;
    }
}