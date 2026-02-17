using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCardapio.View
{
    public partial class TelaInicialForm : Form
    {
        public TelaInicialForm()
        {
            InitializeComponent();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            CategoriaForm categoriaForm = new CategoriaForm();
            categoriaForm.Show();
            this.Hide();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.Show();
            this.Hide();
        }
    }
}
