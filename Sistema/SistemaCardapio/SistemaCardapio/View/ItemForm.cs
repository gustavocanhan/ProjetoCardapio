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
    public partial class ItemForm : Form
    {
        private readonly ItemService _itemService;
        private readonly CategoriaService _categoriaService;
        private Guid _itemSelecionadoPublicId;
        public ItemForm()
        {
            InitializeComponent();
            _itemService = new ItemService();
            _categoriaService = new CategoriaService();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicialForm telaInicial = new TelaInicialForm();
            telaInicial.Show();
            this.Close();

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var item = new ItemDTO
            {
                PublicId = _itemSelecionadoPublicId,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Preco = decimal.TryParse(txtPreco.Text, out var preco) ? Math.Round(preco, 2) : 0,
                CategoriaPublicId = Guid.Parse(cmbCategoria.SelectedValue.ToString())
            };

            if(_itemSelecionadoPublicId == Guid.Empty)
            {
                await _itemService.CriarAsync(item);
            }
            else
            {
                await _itemService.AtualizarAsync(_itemSelecionadoPublicId, item);
            }

            LimparFormulario();
            await CarregarGrid();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if(_itemSelecionadoPublicId == Guid.Empty)
            {
                MessageBox.Show("Selecione um item para excluir.");
                return;
            }

            await _itemService.ExcluirAsync(_itemSelecionadoPublicId);

            LimparFormulario();
            await CarregarGrid();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarCategorias();
        }

        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }

            var item = (ItemDTO)dgvItens.Rows[e.RowIndex].DataBoundItem;

            _itemSelecionadoPublicId = item.PublicId;
            txtNome.Text = item.Nome;
            txtDescricao.Text = item.Descricao;
            txtPreco.Text = item.Preco.ToString("F2");
            cmbCategoria.SelectedValue = item.CategoriaPublicId;
        }

        private async Task CarregarGrid()
        {
            var itens = await _itemService.ObterTodosAsync();

            dgvItens.DataSource = itens;

            // Ocultar PublicGuid
            dgvItens.Columns["PublicId"].Visible = false;

            // Ocultar Guid
            dgvItens.Columns["CategoriaPublicId"].Visible = false;

            // Ocultar objeto Categoria para evitar exibição de ToString()
            dgvItens.Columns["Categoria"].Visible = false;

            // Formatar preço
            dgvItens.Columns["Preco"].DefaultCellStyle.Format = "N2";

            // Adicionar coluna para exibir o nome da categoria
            if (!dgvItens.Columns.Contains("CategoriaNome"))
            {
                dgvItens.Columns.Add("CategoriaNome", "Categoria");
            }

            // Preencher a coluna de nome da categoria
            foreach (DataGridViewRow row in dgvItens.Rows)
            {
                var item = (ItemDTO)row.DataBoundItem;

                row.Cells["CategoriaNome"].Value = item.Categoria?.Nome;
            }

            dgvItens.Columns["Nome"].FillWeight = 30;
            dgvItens.Columns["Descricao"].FillWeight = 40;
            dgvItens.Columns["Preco"].FillWeight = 10;
            dgvItens.Columns["CategoriaNome"].FillWeight = 20;
        }

        private async Task CarregarCategorias()
        {
            var categorias = await _categoriaService.ObterTodasAsync();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "PublicId";
            cmbCategoria.SelectedIndex = 0;
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            cmbCategoria.SelectedIndex = -1;
            _itemSelecionadoPublicId = Guid.Empty;
        }
    }
}
