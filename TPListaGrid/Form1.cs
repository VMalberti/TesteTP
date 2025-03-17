using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPListaGrid
{
    public partial class Form1 : Form
    {
        private ProdutoController controller = new ProdutoController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AtualizarLista()
        {
            List<Produto> produtos = controller.ObterProdutos();
            dataGridViewLista.DataSource = null; // Limpa a fonte de dados
            dataGridViewLista.DataSource = produtos; // Atualiza com os novos dados
        }

        //private void btSalvar_Click(object sender, EventArgs e)
        //{
        //    string nome = txtNome.Text;
        //    string preco = txtPreco.Text;

        //    string mensagem = controller.SalvarProduto(nome, preco);
        //    MessageBox.Show(mensagem);

        //    AtualizarLista();
        //}

        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string preco = txtPreco.Text;

            string mensagem = controller.SalvarProduto(nome, preco);
            MessageBox.Show(mensagem);

            AtualizarLista();

        }
    }
}
