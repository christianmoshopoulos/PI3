using
    System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Entrega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Botão fechar

            if (MessageBox.Show("Deseja mesmo sair?","CONTROLLER COMERCIAL",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }


            // Botão Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Botão início
        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear(); // limpa o painel, para não ficar carregando um painel em cima do outro.
            panelSelecao.Top = btnInicio.Top; // Aplica a posição do botão da seleçao " Marcador", e chama a tela do botão vinculado.
        }


         // Botão marca, chama a tela Form2 a ser apresentada.
        private void btnMarca_Click(object sender, EventArgs e)
        {
            Form2 Marca = new Form2(); // Cria a instância do objeto, e/ou instancia seu formulário.
            Marca.TopLevel = false; // Para não sobrepor o formulário, diz que não é o formulário de topo.
            Marca.Dock = DockStyle.Fill; // Para ele ficar preso no preenchimento selecionado.
            panelCentral.Controls.Clear(); // limpa o painel, para não ficar carregando um painel em cima do outro.
            panelCentral.Controls.Add(Marca); //Adiciona o form no painel.
            Marca.Show(); // Manda ele aparecer.
            panelSelecao.Top = btnMarca.Top; // Aplica a posição do botão da seleçao " Marcador", e chama a tela do botão vinculado.

        }


        // Botão produto, chama a tela Form3 a ser apresentada.
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Form3 Cadastro = new Form3(); // Cria a instância do objeto, e/ou instancia seu formulário.
            Cadastro.TopLevel = false; // Para não sobrepor o formulário, diz que não é o formulário de topo.
            Cadastro.Dock = DockStyle.Fill; // Para ele ficar preso no preenchimento selecionado.
            panelCentral.Controls.Clear(); // limpa o painel, para não ficar carregando um painel em cima do outro.
            panelCentral.Controls.Add(Cadastro); //Adiciona o form no painel
            Cadastro.Show(); // Manda ele aparecer.
            panelSelecao.Top = btnCadastro.Top; // Aplica a posição do botão da seleçao " Marcador", e chama a tela do botão vinculado.

        }


        // Botão estoque, chama a tela Form4 a ser apresentada.
        private void btnEstoque_Click(object sender, EventArgs e)
        {

            Form4 Estoque = new Form4(); // Cria a instância do objeto, e/ou instancia seu formulário.
            Estoque.TopLevel = false; // Para não sobrepor o formulário, diz que não é o formulário de topo.
            Estoque.Dock = DockStyle.Fill; // Para ele ficar preso no preenchimento selecionado.
            panelCentral.Controls.Clear(); // limpa o painel, para não ficar carregando um painel em cima do outro.
            panelCentral.Controls.Add(Estoque); //Adiciona o form no painel
            Estoque.Show(); // Manda ele aparecer.
            panelSelecao.Top = btnEstoque.Top; // Aplica a posição do botão da seleçao " Marcador", e chama a tela do botão vinculado.
        }


        // Botão registro, chama a tela Form5 a ser apresentada.
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form5 Registro = new Form5(); // Cria a instância do objeto, e/ou instancia seu formulário.
            Registro.TopLevel = false; // Para não sobrepor o formulário, diz que não é o formulário de topo.
            Registro.Dock = DockStyle.Fill; // Para ele ficar preso no preenchimento selecionado.
            panelCentral.Controls.Clear(); // limpa o painel, para não ficar carregando um painel em cima do outro.
            panelCentral.Controls.Add(Registro); // Adiciona o form no painel
            Registro.Show(); // Manda ele aparecer.
            panelSelecao.Top = btnRegistro.Top; // Aplica a posição do botão da seleçao " Marcador", e chama a tela do botão vinculado.
        }


        // Botão vendas, chama a tela Form6 a ser apresentada.
        private void btnVendas_Click(object sender, EventArgs e)
        {
            Form6 Vendas = new Form6(); // Cria a instância do objeto, e/ou instancia seu formulário.
            Vendas.TopLevel = false; // Para não sobrepor o formulário, diz que não é o formulário de topo.
            Vendas.Dock = DockStyle.Fill; // Para ele ficar preso no preenchimento selecionado.
            panelCentral.Controls.Clear(); // limpa o painel, para não ficar carregando um painel em cima do outro.
            panelCentral.Controls.Add(Vendas); //adiciona o form no painel
            Vendas.Show(); // Manda ele aparecer.
            panelSelecao.Top = btnVendas.Top; // Aplica a posição do botão da seleçao " Marcador", e chama a tela do botão vinculado.
        }
    }
}
