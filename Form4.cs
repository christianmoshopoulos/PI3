using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_conexaoDataSet.estoque'.
            // Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.db_conexaoDataSet.estoque);

        }

        // Botão Salvar
        private void estoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Para evitar erros no sistema, utilizamos o "tratamento de erros try, catch".

            try  // Tente realizar o que está dentro das chaves dos comandos a seguir.
            {

                this.Validate(); // Valida, o controlador verifica e exibi a entrada de dados para o usuário.
                this.estoqueBindingSource.EndEdit(); // Confirma e conclui a operação de edição na célula atual.
                estoqueTableAdapter.Update(db_conexaoDataSet.estoque); // Entende que efetuará uma atualização na tabela definida, e salva os dados.
                groupBox1.Enabled = false; // Bloqueia a box após salvar
                MessageBox.Show("Registro salvo", "CONTROLLER COMERCIAL"); // Exibe a mensagem registro salvo.


            }
            catch (Exception) //Caso captura o erro, exibirá a mensagem.

            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }

        }


        // Botão editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true; // Libera a box para editar apoós clicar no botão editar
        }


        // Botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estoqueBindingSource.CancelEdit(); // Cancela a operação atual.
            groupBox1.Enabled = false; // Bloqueia a box após cancelar
        }


        // Botão Delete
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            try
            {    // Tente realizar a seguir.
                // Para evitar erros e travar o sistema se não puder excluir, criamos dentro da estrutura de decisão if a pergunta de confirmação,

                if (MessageBox.Show("Confirme exclusão do registro", "CONTROLE DE LOJA", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    estoqueBindingSource.RemoveCurrent(); // Se o usuário clicar em sim, executa o " remove current" e remove,
                    estoqueTableAdapter.Update(db_conexaoDataSet.estoque); // atualiza, salva.
                }

            }
            catch (Exception) // Se der erro, não travar e trazer de volta o que deu erro com o comando (.Fill)
            {

                estoqueTableAdapter.Fill(db_conexaoDataSet.estoque);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        // Botão adicionar
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            estoqueBindingSource.AddNew();// O BindingSource tem o método de adicionar, cria o espaço em branco, aí o usuário poderá cancelar ou salvar.
            groupBox1.Enabled = true; // Libera a box para adicionar após clicar no botão adicionar
        }
    }
}