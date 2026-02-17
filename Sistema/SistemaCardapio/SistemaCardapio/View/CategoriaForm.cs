using SistemaCardapio.Models;
using SistemaCardapio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCardapio.View
{
    public partial class CategoriaForm : Form
    {
        private readonly CategoriaService _categoriaService;
        private Guid _categoriaSelecionadaPublicId;


        public CategoriaForm()
        {
            InitializeComponent();
            _categoriaService = new CategoriaService();
        }

        private async void CategoriaForm_Load(object sender, EventArgs e)
        {
            await CarregarGrid();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var categoria = new CategoriaDTO
            {
                PublicId = _categoriaSelecionadaPublicId,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text
            };

            if (_categoriaSelecionadaPublicId == Guid.Empty)
            {
                await _categoriaService.CriarAsync(categoria);
            }
            else
            {
                await _categoriaService.AtualizarAsync(_categoriaSelecionadaPublicId, categoria);
            }

            LimparFormulario();
            await CarregarGrid();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_categoriaSelecionadaPublicId == Guid.Empty)
            {
                MessageBox.Show("Selecione uma categoria para excluir.");
                return;
            }

            await _categoriaService.ExcluirAsync(_categoriaSelecionadaPublicId);

            LimparFormulario();
            await CarregarGrid();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var categoria = (CategoriaDTO)dgvCategorias.Rows[e.RowIndex].DataBoundItem;

            _categoriaSelecionadaPublicId = categoria.PublicId;
            txtNome.Text = categoria.Nome;
            txtDescricao.Text = categoria.Descricao;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicialForm telaInicial = new TelaInicialForm();
            telaInicial.Show();
            this.Close();
        }

        private async Task CarregarGrid()
        {
            dgvCategorias.DataSource = await _categoriaService.ObterTodasAsync();

            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCategorias.Columns["PublicId"].FillWeight = 30;
            dgvCategorias.Columns["Nome"].FillWeight = 20;
            dgvCategorias.Columns["Descricao"].FillWeight = 50;
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            _categoriaSelecionadaPublicId = Guid.Empty;
        }
    }
}
